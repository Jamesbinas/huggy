import unittest.mock as mock
import pytest
import os

import numpy as np
from mlagents.tf_utils import tf
import yaml

from mlagents.trainers.bc.models import BehavioralCloningModel
import mlagents.trainers.tests.mock_brain as mb
from mlagents.trainers.bc.policy import BCPolicy
from mlagents.trainers.bc.offline_trainer import BCTrainer

from mlagents.envs.mock_communicator import MockCommunicator
from mlagents.trainers.tests.mock_brain import make_brain_parameters
from mlagents.trainers.tests.test_trajectory import make_fake_trajectory
from mlagents.envs.environment import UnityEnvironment
from mlagents.trainers.brain_conversion_utils import (
    step_result_to_brain_info,
    group_spec_to_brain_parameters,
)


@pytest.fixture
def dummy_config():
    return yaml.safe_load(
        """
            hidden_units: 32
            learning_rate: 3.0e-4
            num_layers: 1
            use_recurrent: false
            sequence_length: 32
            memory_size: 32
            batches_per_epoch: 100 # Force code to use all possible batches
            batch_size: 32
            summary_freq: 2000
            max_steps: 4000
            """
    )


def create_bc_trainer(dummy_config, is_discrete=False, use_recurrent=False):
    mock_env = mock.Mock()
    if is_discrete:
        mock_brain = mb.create_mock_pushblock_brain()
        mock_braininfo = mb.create_mock_braininfo(
            num_agents=12, num_vector_observations=70
        )
    else:
        mock_brain = mb.create_mock_3dball_brain()
        mock_braininfo = mb.create_mock_braininfo(
            num_agents=12, num_vector_observations=8
        )
    mb.setup_mock_unityenvironment(mock_env, mock_brain, mock_braininfo)
    env = mock_env()

    trainer_parameters = dummy_config
    trainer_parameters["summary_path"] = "tmp"
    trainer_parameters["model_path"] = "tmp"
    trainer_parameters["demo_path"] = (
        os.path.dirname(os.path.abspath(__file__)) + "/test.demo"
    )
    trainer_parameters["use_recurrent"] = use_recurrent
    trainer = BCTrainer(
        mock_brain, trainer_parameters, training=True, load=False, seed=0, run_id=0
    )
    trainer.demonstration_buffer = mb.simulate_rollout(env, trainer.policy, 100)
    return trainer, env


@pytest.mark.parametrize("use_recurrent", [True, False])
def test_bc_trainer_step(dummy_config, use_recurrent):
    trainer, env = create_bc_trainer(dummy_config, use_recurrent=use_recurrent)
    # Test get_step
    assert trainer.get_step == 0
    # Test update policy
    trainer.update_policy()
    assert len(trainer.stats["Losses/Cloning Loss"]) > 0
    # Test increment step
    trainer.increment_step(1)
    assert trainer.step == 1


def test_bc_trainer_process_trajectory(dummy_config):
    trainer, _ = create_bc_trainer(dummy_config)
    # Test process_trajectory
    agent_id = "test_agent"
    trajectory = make_fake_trajectory(length=15)
    trainer.process_trajectory(trajectory)
    assert len(trainer.stats["Environment/Cumulative Reward"]) > 0
    # Assert that the done reset the steps
    assert trainer.episode_steps[agent_id] == 0
    assert trainer.cumulative_rewards[agent_id] == 0

    # Create a trajectory without a done
    trajectory = make_fake_trajectory(length=15, max_step_complete=True)
    trainer.process_trajectory(trajectory)
    assert trainer.episode_steps[agent_id] == 15
    assert trainer.cumulative_rewards[agent_id] > 0


def test_bc_trainer_end_episode(dummy_config):
    trainer, _ = create_bc_trainer(dummy_config)
    trajectory = make_fake_trajectory(length=15)
    trainer.process_trajectory(trajectory)
    # Should set everything to 0
    trainer.end_episode()
    agent_id = "test_agent"
    assert trainer.episode_steps[agent_id] == 0
    assert trainer.cumulative_rewards[agent_id] == 0


@mock.patch("mlagents.envs.environment.UnityEnvironment.executable_launcher")
@mock.patch("mlagents.envs.environment.UnityEnvironment.get_communicator")
def test_bc_policy_evaluate(mock_communicator, mock_launcher, dummy_config):
    tf.reset_default_graph()
    mock_communicator.return_value = MockCommunicator(
        discrete_action=False, visual_inputs=0
    )
    env = UnityEnvironment(" ")
    env.reset()
    brain_name = env.get_agent_groups()[0]
    brain_info = step_result_to_brain_info(
        env.get_step_result(brain_name), env.get_agent_group_spec(brain_name)
    )
    brain_params = group_spec_to_brain_parameters(
        brain_name, env.get_agent_group_spec(brain_name)
    )

    trainer_parameters = dummy_config
    model_path = brain_name
    trainer_parameters["model_path"] = model_path
    trainer_parameters["keep_checkpoints"] = 3
    policy = BCPolicy(0, brain_params, trainer_parameters, False)
    run_out = policy.evaluate(brain_info)
    assert run_out["action"].shape == (3, 2)

    env.close()


def test_cc_bc_model():
    tf.reset_default_graph()
    with tf.Session() as sess:
        with tf.variable_scope("FakeGraphScope"):
            model = BehavioralCloningModel(
                make_brain_parameters(discrete_action=False, visual_inputs=0)
            )
            init = tf.global_variables_initializer()
            sess.run(init)

            run_list = [model.sample_action, model.policy]
            feed_dict = {
                model.batch_size: 2,
                model.sequence_length: 1,
                model.vector_in: np.array([[1, 2, 3, 1, 2, 3], [3, 4, 5, 3, 4, 5]]),
            }
            sess.run(run_list, feed_dict=feed_dict)
            # env.close()


def test_dc_bc_model():
    tf.reset_default_graph()
    with tf.Session() as sess:
        with tf.variable_scope("FakeGraphScope"):
            model = BehavioralCloningModel(
                make_brain_parameters(discrete_action=True, visual_inputs=0)
            )
            init = tf.global_variables_initializer()
            sess.run(init)

            run_list = [model.sample_action, model.action_probs]
            feed_dict = {
                model.batch_size: 2,
                model.dropout_rate: 1.0,
                model.sequence_length: 1,
                model.vector_in: np.array([[1, 2, 3, 1, 2, 3], [3, 4, 5, 3, 4, 5]]),
                model.action_masks: np.ones([2, 2], dtype=np.float32),
            }
            sess.run(run_list, feed_dict=feed_dict)


def test_visual_dc_bc_model():
    tf.reset_default_graph()
    with tf.Session() as sess:
        with tf.variable_scope("FakeGraphScope"):
            model = BehavioralCloningModel(
                make_brain_parameters(discrete_action=True, visual_inputs=2)
            )
            init = tf.global_variables_initializer()
            sess.run(init)

            run_list = [model.sample_action, model.action_probs]
            feed_dict = {
                model.batch_size: 2,
                model.dropout_rate: 1.0,
                model.sequence_length: 1,
                model.vector_in: np.array([[1, 2, 3, 1, 2, 3], [3, 4, 5, 3, 4, 5]]),
                model.visual_in[0]: np.ones([2, 40, 30, 3], dtype=np.float32),
                model.visual_in[1]: np.ones([2, 40, 30, 3], dtype=np.float32),
                model.action_masks: np.ones([2, 2], dtype=np.float32),
            }
            sess.run(run_list, feed_dict=feed_dict)


def test_visual_cc_bc_model():
    tf.reset_default_graph()
    with tf.Session() as sess:
        with tf.variable_scope("FakeGraphScope"):
            model = BehavioralCloningModel(
                make_brain_parameters(discrete_action=False, visual_inputs=2)
            )
            init = tf.global_variables_initializer()
            sess.run(init)

            run_list = [model.sample_action, model.policy]
            feed_dict = {
                model.batch_size: 2,
                model.sequence_length: 1,
                model.vector_in: np.array([[1, 2, 3, 1, 2, 3], [3, 4, 5, 3, 4, 5]]),
                model.visual_in[0]: np.ones([2, 40, 30, 3], dtype=np.float32),
                model.visual_in[1]: np.ones([2, 40, 30, 3], dtype=np.float32),
            }
            sess.run(run_list, feed_dict=feed_dict)


if __name__ == "__main__":
    pytest.main()

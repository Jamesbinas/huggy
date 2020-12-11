using System;
using UnityEngine;
using UnityEngine.Serialization;
using Unity.MLAgents.Actuators;

namespace Unity.MLAgents.Policies
{
    /// <summary>
    /// Whether the action space is discrete or continuous.
    /// </summary>
    public enum SpaceType
    {
        /// <summary>
        /// Discrete action space: a fixed number of options are available.
        /// </summary>
        Discrete,

        /// <summary>
        /// Continuous action space: each action can take on a float value.
        /// </summary>
        Continuous
    }

    /// <summary>
    /// Holds information about the brain. It defines what are the inputs and outputs of the
    /// decision process.
    /// </summary>
    /// <remarks>
    /// Set brain parameters for an <see cref="Agent"/> instance using the
    /// <seealso cref="BehaviorParameters"/> component attached to the agent's [GameObject].
    ///
    /// [GameObject]: https://docs.unity3d.com/Manual/GameObjects.html
    /// </remarks>
    [Serializable]
    public class BrainParameters : ISerializationCallbackReceiver
    {
        /// <summary>
        /// The number of the observations that are added in
        /// <see cref="Agent.CollectObservations(Sensors.VectorSensor)"/>
        /// </summary>
        /// <value>
        /// The length of the vector containing observation values.
        /// </value>
        [FormerlySerializedAs("vectorObservationSize")]
        public int VectorObservationSize = 1;

        /// <summary>
        /// Stacking refers to concatenating the observations across multiple frames. This field
        /// indicates the number of frames to concatenate across.
        /// </summary>
        [FormerlySerializedAs("numStackedVectorObservations")]
        [Range(1, 50)] public int NumStackedVectorObservations = 1;

        [SerializeField]
        internal int m_NumContinuousActions = 0;
        [SerializeField]
        internal int[] m_DiscreteBranchSizes = null;

        /// <summary>
        /// The specification of the Action space for the BrainParameters.
        /// </summary>
        public ActionSpec ActionSpec
        {
            get { return new ActionSpec(m_NumContinuousActions, m_DiscreteBranchSizes); }
            set
            {
                m_NumContinuousActions = value.NumContinuousActions;
                m_DiscreteBranchSizes = value.BranchSizes;
                if (m_NumContinuousActions == 0)
                {
                    VectorActionSize = value.BranchSizes;
                    VectorActionSpaceType = SpaceType.Discrete;
                }
                else if (m_DiscreteBranchSizes == null || m_DiscreteBranchSizes.Length == 0)
                {
                    VectorActionSize = new[] { m_NumContinuousActions };
                    VectorActionSpaceType = SpaceType.Continuous;
                }
            }
        }

        /// <summary>
        /// (Deprecated) The size of the action space.
        /// </summary>
        /// <remarks>The size specified is interpreted differently depending on whether
        /// the agent uses the continuous or the discrete action space.</remarks>
        /// <value>
        /// For the continuous action space: the length of the float vector that represents
        /// the action.
        /// For the discrete action space: the number of branches in the action space.
        /// </value>
        /// [Obsolete("VectorActionSize has been deprecated, please use ActionSpec instead.")]
        [FormerlySerializedAs("vectorActionSize")]
        public int[] VectorActionSize = new[] { 1 };

        /// <summary>
        /// The list of strings describing what the actions correspond to.
        /// </summary>
        [FormerlySerializedAs("vectorActionDescriptions")]
        public string[] VectorActionDescriptions;

        /// <summary>
        /// (Deprecated) Defines if the action is discrete or continuous.
        /// </summary>
        /// [Obsolete("VectorActionSpaceType has been deprecated, please use ActionSpec instead.")]
        [FormerlySerializedAs("vectorActionSpaceType")]
        public SpaceType VectorActionSpaceType = SpaceType.Discrete;

        [SerializeField]
        [HideInInspector]
        internal bool hasUpgradedBrainParametersWithActionSpec;

        /// <summary>
        /// (Deprecated) The number of actions specified by this Brain.
        /// </summary>
        /// [Obsolete("NumActions has been deprecated, please use ActionSpec instead.")]
        public int NumActions
        {
            get
            {
                return ActionSpec.NumContinuousActions > 0 ? ActionSpec.NumContinuousActions : ActionSpec.NumDiscreteActions;
            }
        }

        /// <summary>
        /// Deep clones the BrainParameter object.
        /// </summary>
        /// <returns> A new BrainParameter object with the same values as the original.</returns>
        public BrainParameters Clone()
        {
            return new BrainParameters
            {
                VectorObservationSize = VectorObservationSize,
                NumStackedVectorObservations = NumStackedVectorObservations,
                VectorActionDescriptions = (string[])VectorActionDescriptions.Clone(),
                ActionSpec = new ActionSpec(ActionSpec.NumContinuousActions, ActionSpec.BranchSizes),
                VectorActionSize = (int[])VectorActionSize.Clone(),
                VectorActionSpaceType = VectorActionSpaceType,
            };
        }

        /// <summary>
        /// Propogate ActionSpec fields from deprecated fields
        /// </summary>
        private void UpdateToActionSpec()
        {
            if (!hasUpgradedBrainParametersWithActionSpec)
            {
                if (VectorActionSpaceType == SpaceType.Continuous)
                {
                    m_NumContinuousActions = VectorActionSize[0];
                    m_DiscreteBranchSizes = null;
                }
                if (VectorActionSpaceType == SpaceType.Discrete)
                {
                    m_NumContinuousActions = 0;
                    m_DiscreteBranchSizes = VectorActionSize;
                }

                hasUpgradedBrainParametersWithActionSpec = true;
            }
        }

        private void SyncDeprecatedActionFields()
        {
            if (m_NumContinuousActions == 0)
            {
                VectorActionSize = ActionSpec.BranchSizes;
                VectorActionSpaceType = SpaceType.Discrete;
            }
            else if (m_DiscreteBranchSizes == null || m_DiscreteBranchSizes.Length == 0)
            {
                VectorActionSize = new[] { m_NumContinuousActions };
                VectorActionSpaceType = SpaceType.Continuous;
            }
            else
            {
                VectorActionSize = null;
            }
        }

        /// <summary>
        /// Called by Unity immediately before serializing this object.
        /// </summary>
        public void OnBeforeSerialize()
        {
            UpdateToActionSpec();
            SyncDeprecatedActionFields();
        }

        /// <summary>
        /// Called by Unity immediately after deserializing this object.
        /// </summary>
        public void OnAfterDeserialize()
        {
            UpdateToActionSpec();
            SyncDeprecatedActionFields();
        }
    }
}

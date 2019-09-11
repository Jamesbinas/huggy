﻿using System;
using System.Collections.Generic;
using System.Linq;
using Barracuda;
using MLAgents.InferenceBrain.Utils;
using UnityEngine;

namespace MLAgents.InferenceBrain
{
    /// <summary>
    /// The Applier for the Continuous Action output tensor. Tensor is assumed to contain the
    /// continuous action data of the agents in the batch.
    /// </summary>
    public class ContinuousActionOutputApplier : TensorApplier.Applier
    {
        public void Apply(TensorProxy tensorProxy, Dictionary<Agent, AgentInfo> agentInfo)
        {
            var actionSize = tensorProxy.shape[tensorProxy.shape.Length - 1];
            var agentIndex = 0;
            foreach (var agent in agentInfo.Keys)
            {
                var action = new float[actionSize];
                for (var j = 0; j < actionSize; j++)
                {
                    action[j] = tensorProxy.data[agentIndex, j];
                }
                agent.UpdateVectorAction(action);
                agentIndex++;
            }
        }
    }

    /// <summary>
    /// The Applier for the Discrete Action output tensor. Uses multinomial to sample discrete
    /// actions from the logits contained in the tensor.
    /// </summary>
    public class DiscreteActionOutputApplier : TensorApplier.Applier
    {
        private readonly int[] _actionSize;
        private readonly Multinomial _multinomial;
        private readonly ITensorAllocator _allocator;

        public DiscreteActionOutputApplier(int[] actionSize, int seed, ITensorAllocator allocator)
        {
            _actionSize = actionSize;
            _multinomial = new Multinomial(seed);
            _allocator = allocator;
        }

        public void Apply(TensorProxy tensorProxy, Dictionary<Agent, AgentInfo> agentInfo)
        {
            //var tensorDataProbabilities = tensorProxy.Data as float[,];
            var batchSize = agentInfo.Keys.Count;
            var actions = new float[batchSize, _actionSize.Length];
            var startActionIndices = Utilities.CumSum(_actionSize);
            for (var actionIndex=0; actionIndex < _actionSize.Length; actionIndex++)
            {
                var nBranchAction = _actionSize[actionIndex];
                var actionProbs = new TensorProxy()
                {
                    valueType = TensorProxy.TensorType.FloatingPoint,
                    shape = new long[]{batchSize, nBranchAction},
                    data = _allocator.Alloc(new TensorShape(batchSize, nBranchAction))
                };

                for (var batchIndex = 0; batchIndex < batchSize; batchIndex++)
                {
                    for (var branchActionIndex = 0;
                        branchActionIndex < nBranchAction;
                        branchActionIndex++)
                    {
                        actionProbs.data[batchIndex, branchActionIndex] =
                            tensorProxy.data[batchIndex, startActionIndices[actionIndex] + branchActionIndex];
                    }
                }

                var outputTensor = new TensorProxy()
                {
                    valueType = TensorProxy.TensorType.FloatingPoint,
                    shape = new long[]{batchSize, 1},
                    data = _allocator.Alloc(new TensorShape(batchSize, 1))
                };

                Eval(actionProbs, outputTensor, _multinomial);

                for (var ii = 0; ii < batchSize; ii++)
                {
                    actions[ii, actionIndex] = outputTensor.data[ii, 0];
                }
                actionProbs.Data.Dispose();
                outputTensor.Data.Dispose();
            }
            var agentIndex = 0;
            foreach (var agent in agentInfo.Keys)
            {
                var action = new float[_actionSize.Length];
                for (var j = 0; j < _actionSize.Length; j++)
                {
                    action[j] = actions[agentIndex, j];
                }
                agent.UpdateVectorAction(action);
                agentIndex++;
            }
        }

        /// <summary>
        /// Draw samples from a multinomial distribution based on log-probabilities specified
        /// in tensor src. The samples will be saved in the dst tensor.
        /// </summary>
        /// <param name="src">2-D tensor with shape batch_size x num_classes</param>
        /// <param name="dst">Allocated tensor with size batch_size x num_samples</param>
        /// <param name="multinomial">Multinomial object used to sample values</param>
        /// <exception cref="NotImplementedException">
        /// Multinomial doesn't support integer tensors
        /// </exception>
        /// <exception cref="ArgumentException">Issue with tensor shape or type</exception>
        /// <exception cref="ArgumentNullException">
        /// At least one of the tensors is not allocated
        /// </exception>
        public static void Eval(TensorProxy src, TensorProxy dst, Multinomial multinomial)
        {
            if (src.DataType != typeof(float))
            {
                throw new NotImplementedException("Only float tensors are currently supported");
            }

            if (src.valueType != dst.valueType)
            {
                throw new ArgumentException(
                    "Source and destination tensors have different types!");
            }

            if (src.data == null || dst.data == null)
            {
                throw new ArgumentNullException();
            }

            if (src.data.batch != dst.data.batch)
            {
                throw new ArgumentException("Batch size for input and output data is different!");
            }

            var cdf = new float[src.data.channels];

            for (var batch = 0; batch < src.data.batch; ++batch)
            {
                // Find the class maximum
                var maxProb = float.NegativeInfinity;
                for (var cls = 0; cls < src.data.channels; ++cls)
                {
                    maxProb = Mathf.Max(src.data[batch, cls], maxProb);
                }

                // Sum the log probabilities and compute CDF
                var sumProb = 0.0f;
                for (var cls = 0; cls < src.data.channels; ++cls)
                {
                    sumProb += Mathf.Exp(src.data[batch, cls] - maxProb);
                    cdf[cls] = sumProb;
                }

                // Generate the samples
                for (var sample = 0; sample < dst.data.channels; ++sample)
                {
                    dst.data[batch, sample] = multinomial.Sample(cdf);
                }
            }
        }
    }

    public class BarracudaMemoryOutputApplier : TensorApplier.Applier
    {
        private readonly int _memoriesCount;
        private readonly int _memoryIndex;

        public BarracudaMemoryOutputApplier(int memoriesCount, int memoryIndex)
        {
            _memoriesCount = memoriesCount;
            _memoryIndex = memoryIndex;
        }

        public void Apply(TensorProxy tensorProxy, Dictionary<Agent, AgentInfo> agentInfo)
        {
            var agentIndex = 0;
            var memorySize = (int)tensorProxy.shape[tensorProxy.shape.Length - 1];

            foreach (var agent in agentInfo.Keys)
            {
                var memory = agent.GetMemoriesAction();

                if (memory == null || memory.Count < memorySize * _memoriesCount)
                {
                    memory = new List<float>();
                    memory.AddRange(Enumerable.Repeat(0f, memorySize * _memoriesCount));
                }

                for (var j = 0; j < memorySize; j++)
                {
                    memory[memorySize * _memoryIndex + j] = tensorProxy.data[agentIndex, j];
                }

                agent.UpdateMemoriesAction(memory);

                agentIndex++;
            }
        }
    }

    /// <summary>
    /// The Applier for the Memory output tensor. Tensor is assumed to contain the new
    /// memory data of the agents in the batch.
    /// </summary>
    public class MemoryOutputApplier : TensorApplier.Applier
    {
        public void Apply(TensorProxy tensorProxy, Dictionary<Agent, AgentInfo> agentInfo)
        {
            var agentIndex = 0;
            var memorySize = tensorProxy.shape[tensorProxy.shape.Length - 1];
            foreach (var agent in agentInfo.Keys)
            {
                var memory = new List<float>();
                for (var j = 0; j < memorySize; j++)
                {
                    memory.Add(tensorProxy.data[agentIndex, j]);
                }

                agent.UpdateMemoriesAction(memory);
                agentIndex++;
            }
        }
    }

    /// <summary>
    /// The Applier for the Value Estimate output tensor. Tensor is assumed to contain the
    /// value estimates of the agents in the batch.
    /// </summary>
    public class ValueEstimateApplier : TensorApplier.Applier
    {
        public void Apply(TensorProxy tensorProxy, Dictionary<Agent, AgentInfo> agentInfo)
        {
            var agentIndex = 0;
            foreach (var agent in agentInfo.Keys)
            {
                agent.UpdateValueAction(tensorProxy.data[agentIndex, 0]);
                agentIndex++;
            }
        }
    }
}

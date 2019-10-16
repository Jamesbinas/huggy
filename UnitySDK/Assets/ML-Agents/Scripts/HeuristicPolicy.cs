using UnityEngine;
using Barracuda;
using MLAgents.InferenceBrain;
using System;

namespace MLAgents
{

    public delegate float[] Heuristic();

    /// <summary>
    /// The Heuristic Policy uses a hards coded Heuristic method
    /// to take decisions each time the RequestDecision method is
    /// called.
    /// </summary>
    public class HeuristicPolicy : IPolicy
    {
        private Heuristic m_Heuristic;
        private Agent m_Agent;

        /// <inheritdoc />
        public HeuristicPolicy(Heuristic heuristic)
        {
            m_Heuristic = heuristic;
        }

        /// <inheritdoc />
        public void RequestDecision(Agent agent)
        {
            m_Agent = agent;
        }

        /// <inheritdoc />
        public void DecideAction()
        {
            if (m_Agent != null)
            {
                m_Agent.UpdateVectorAction(m_Heuristic.Invoke());
            }
        }

        public void Dispose()
        {

        }
    }
}

using System;

namespace AI.BehaviorTree
{
    public class Inverter : INode
    {
        private readonly INode _nodeToInvert;

        public Inverter(INode nodeToInvert) => 
            _nodeToInvert = nodeToInvert;

        public NodeStatus Process() =>
            _nodeToInvert.Process() switch
            {
                NodeStatus.Success => NodeStatus.Failure,
                NodeStatus.Running => NodeStatus.Running,
                NodeStatus.Failure => NodeStatus.Success,
                _ => throw new ArgumentOutOfRangeException()
            };
    }
}
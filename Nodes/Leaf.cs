using System;

namespace AI.BehaviorTree
{
    public class Leaf : INode
    {
        private readonly Func<NodeStatus> _processMethod;

        public Leaf(Func<NodeStatus> processMethod)=> 
            _processMethod = processMethod;

        public NodeStatus Process() =>
            _processMethod?.Invoke() 
            ?? NodeStatus.Failure;
    }
}
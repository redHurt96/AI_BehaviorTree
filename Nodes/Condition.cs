using System;

namespace AI.BehaviorTree
{
    public class Condition : INode
    {
        private readonly Func<bool> _condition;

        public Condition(Func<bool> condition) => 
            _condition = condition;

        public NodeStatus Process() =>
            _condition()
                ? NodeStatus.Success
                : NodeStatus.Failure;
    }
}
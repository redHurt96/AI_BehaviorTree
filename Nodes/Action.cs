using System;

namespace AI.BehaviorTree
{
    public class Action : INode
    {
        private readonly Func<NodeStatus> _action;

        public Action(Func<NodeStatus> action) => 
            _action = action;

        public NodeStatus Process() => 
            _action();
    }
}
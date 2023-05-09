namespace AI.BehaviorTree
{
    public class Sequence : INode
    {
        private int _currentChild = 0;

        private readonly INode[] _children;
        
        public Sequence(params INode[] children) => 
            _children = children;

        public NodeStatus Process()
        {
            NodeStatus childStatus = _children[_currentChild].Process();

            if (childStatus == NodeStatus.Success)
            {
                _currentChild++;

                if (_currentChild >= _children.Length)
                {
                    _currentChild = 0;
                    return NodeStatus.Success;
                }
            
                return NodeStatus.Running;
            }

            return childStatus;
        }
    }
}
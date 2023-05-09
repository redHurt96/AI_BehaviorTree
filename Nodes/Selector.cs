namespace AI.BehaviorTree
{
    public class Selector : INode
    {
        private int _currentChild = 0;
        
        private readonly INode[] _children;

        public Selector(params INode[] children)=> 
            _children = children;

        public NodeStatus Process()
        {
            NodeStatus childStatus = _children[_currentChild].Process();

            if (childStatus == NodeStatus.Running)
                return childStatus;

            if (childStatus == NodeStatus.Success)
            {
                _currentChild = 0;
                return childStatus;
            }
            
            _currentChild++;

            if (_currentChild >= _children.Length)
            {
                _currentChild = 0;
                return NodeStatus.Failure;
            }

            return NodeStatus.Running;
        }
    }
}
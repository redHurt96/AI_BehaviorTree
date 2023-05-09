namespace AI.BehaviorTree
{
    public class Tree : INode
    {
        private readonly INode _root;
        public Tree(INode root) => 
            _root = root;

        public NodeStatus Process() => 
            _root.Process();
    }
}
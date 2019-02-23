using System;

namespace InterviewCake.binary_trees.traversal_algorithms.depth_first_using_recursion
{
    public static class PostOrderRecursiveTraversal
    {
        public static void ProcessNode(BinaryTreeNode n)
        {
            if (n == null) return;

            if (n.Left != null) ProcessNode(n.Left);

            if (n.Right != null) ProcessNode(n.Right);

            Console.Write($"{n.Value}, ");
        }
    }
}

using System;

namespace InterviewCake.binary_trees.traversal_algorithms.depth_first_using_recursion
{
    public static class PreOrderTraversal
    {
        public static void ProcessNode(BinaryTreeNode n)
        {
            if (n == null) return;

            Console.Write($"{n.Value}, ");

            if (n.Left != null) ProcessNode(n.Left);

            if (n.Right != null) ProcessNode(n.Right);
        }
    }
}

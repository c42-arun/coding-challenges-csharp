using System;

namespace InterviewCake.binary_trees.traversal_algorithms.depth_first_using_recursion
{
    public static class InOrderRecursiveTraversal
    {
        public static void ProcessNode(BinaryTreeNode n)
        {
            if (n == null) return;

            if (n.Left != null) ProcessNode(n.Left);

            Console.Write($"{n.Value}, ");

            if (n.Right != null) ProcessNode(n.Right);
        }
    }
}

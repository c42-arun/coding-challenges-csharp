using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCake.binary_trees.traversal_algorithms.depth_first_using_stack_iterative
{
    public class InOrderStackTraversal
    {
        public static void Traverse(BinaryTreeNode node)
        {
            if (node == null) return;

            var stack = new Stack<BinaryTreeNode>();
            stack.Push(node);

            while(stack.Any())
            {
                var n = stack.Pop();

                if (n.Right != null)
                {
                    stack.Push(n.Right);
                }

                Console.WriteLine(n.Value);

                if (n.Left != null)
                {
                    stack.Push(n.Left);
                }
            }
        }
    }
}

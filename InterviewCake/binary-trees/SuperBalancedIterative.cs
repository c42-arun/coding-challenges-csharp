using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.binary_trees
{
    public class SuperBalancedIterative
    {
        static int _min = 0;
        static int _max = 0;

        public static bool IsBalanced(BinaryTreeNode treeRoot)
        {
            return false;
            //Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();

            //stack.Push(treeRoot);

            //while (stack.Any())
            //{
            //    BinaryTreeNode node = stack.Pop();

            //    if (node.Left == null && node.Right == null) // at leaf node
            //    {
            //        if (_max == 0 && _min == 0)
            //        {

            //        }
            //    }
            //    else
            //    {

            //    }

            //    if (node.Right != null)
            //    {
            //        stack.Push(node.Right);
            //    }

            //    if (node.Left != null)
            //    {
            //        stack.Push(node.Left);
            //    }
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.binary_trees
{
    public static class SuperBalanced
    {
        static int _min;
        static int _max;

        public static bool IsBalanced(BinaryTreeNode treeRoot)
        {
            // Determine if the tree is superbalanced
            _min = 0;
            _max = 0;

            ProcessNode(treeRoot, 0);

            return (_max - _min) <= 1;
        }

        private static void ProcessNode(BinaryTreeNode n, int level)
        {
            if (n == null) return;

            if (n.Left == null && n.Right == null)
            {
                // we are at a leaf node

                if (_min == 0 && _max == 0)
                {
                    _min = level;
                    _max = level;
                }
                else
                {
                    if (level > _max)
                        _max = level;
                    else if (level < _min)
                        _min = level;
                }
            }

            if (n.Left != null) ProcessNode(n.Left, level + 1);

            if (n.Right != null) ProcessNode(n.Right, level + 1);
        }
    }
}

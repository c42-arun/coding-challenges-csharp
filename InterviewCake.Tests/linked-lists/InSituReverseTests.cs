using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewCake.linked_lists;
using InterviewCake.linked_lists.singly_linked;
using Xunit;

namespace InterviewCake.Tests.linked_lists
{
    public class InSituReverseTests
    {
        [Fact]
        public void ShortLinkedListTest()
        {
            var nodes = ValuesToLinkedListNodes(new int[] { 1, 2 });
            var result = ReverseList.InPlaceReverse(nodes[0]);
            Assert.True(IsListReversed(result, nodes));
        }

        [Fact]
        public void LongLinkedListTest()
        {
            var nodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4, 5, 6 });
            var result = ReverseList.InPlaceReverse(nodes[0]);
            Assert.True(IsListReversed(result, nodes));
        }

        [Fact]
        public void OneElementLinkedListTest()
        {
            var node = new LinkedListNode(1);
            var result = ReverseList.InPlaceReverse(node);
            Assert.Same(node, result);
        }

        [Fact]
        public void EmptyLinkedListTest()
        {
            var result = ReverseList.InPlaceReverse(null);
            Assert.Null(result);
        }

        private static LinkedListNode[] ValuesToLinkedListNodes(int[] values)
        {
            var nodes = new LinkedListNode[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                nodes[i] = new LinkedListNode(values[i]);
                if (i > 0)
                {
                    nodes[i - 1].Next = nodes[i];
                }
            }
            return nodes;
        }

        private static bool IsListReversed(LinkedListNode list, LinkedListNode[] originalNodes)
        {
            int i = originalNodes.Length - 1;
            while (list != null && i >= 0)
            {
                if (originalNodes[i] != list)
                {
                    return false;
                }
                list = list.Next;
                i--;
            }
            return list == null && i == -1;
        }
    }
}

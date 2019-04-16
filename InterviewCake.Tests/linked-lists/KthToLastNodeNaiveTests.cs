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
    public class KthToLastNodeNaiveTests
    {
        [Fact]
        public void FirstToLastNodeTest()
        {
            var listNodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            var k = 1;
            var actual = KthToLastNode.GetNodeByNaiveMethod(k, listNodes[0]);
            var expected = listNodes[listNodes.Length - k];
            Assert.Same(expected, actual);
        }

        [Fact]
        public void SecondToLastNodeTest()
        {
            var listNodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            var k = 2;
            var actual = KthToLastNode.GetNodeByNaiveMethod(k, listNodes[0]);
            var expected = listNodes[listNodes.Length - k];
            Assert.Same(expected, actual);
        }

        [Fact]
        public void FirstNodeTest()
        {
            var listNodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            var k = 4;
            var actual = KthToLastNode.GetNodeByNaiveMethod(k, listNodes[0]);
            var expected = listNodes[listNodes.Length - k];
            Assert.Same(expected, actual);
        }

        [Fact]
        public void KIsGreaterThanLinkedListLengthTest()
        {
            var listNodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            var k = 5;
            Assert.Throws<ArgumentException>(() => KthToLastNode.GetNodeByNaiveMethod(k, listNodes[0]));
        }

        [Fact]
        public void KIsZeroTest()
        {
            var listNodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            var k = 0;
            Assert.Throws<ArgumentException>(() => KthToLastNode.GetNodeByNaiveMethod(k, listNodes[0]));
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
    }
}

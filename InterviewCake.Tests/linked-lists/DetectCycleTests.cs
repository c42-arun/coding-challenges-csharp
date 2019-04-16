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
    public class DetectCycleTests
    {
        [Fact]
        public void LinkedListWithNoCycleBruteForceTest()
        {
            var nodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            var result = DetectCycle.ContainsCycleBruteForceUsingSet(nodes[0]);
            Assert.False(result);
        }

        [Fact]
        public void CycleLoopsToBeginningBruteForceTest()
        {
            var nodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            nodes[3].Next = nodes[0];
            var result = DetectCycle.ContainsCycleBruteForceUsingSet(nodes[0]);
            Assert.True(result);
        }

        [Fact]
        public void CycleLoopsToMiddleBruteForceTest()
        {
            var nodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4, 5 });
            nodes[4].Next = nodes[2];
            var result = DetectCycle.ContainsCycleBruteForceUsingSet(nodes[0]);
            Assert.True(result);
        }

        [Fact]
        public void TwoNodeCycleAtEndBruteForceTest()
        {
            var nodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4, 5 });
            nodes[4].Next = nodes[3];
            var result = DetectCycle.ContainsCycleBruteForceUsingSet(nodes[0]);
            Assert.True(result);
        }

        [Fact]
        public void EmptyListBruteForceTest()
        {
            var result = DetectCycle.ContainsCycleBruteForceUsingSet(null);
            Assert.False(result);
        }

        [Fact]
        public void OneElementLinkedListNoCycleBruteForceTest()
        {
            var node = new LinkedListNode(1);
            var result = DetectCycle.ContainsCycleBruteForceUsingSet(node);
            Assert.False(result);
        }

        [Fact]
        public void OneElementLinkedListCycleBruteForceTest()
        {
            var node = new LinkedListNode(1);
            node.Next = node;
            var result = DetectCycle.ContainsCycleBruteForceUsingSet(node);
            Assert.True(result);
        }

        [Fact]
        public void LinkedListWithNoCycleTwoRunnersTest()
        {
            var nodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            var result = DetectCycle.ContainsCycleEfficientUsingFastSlowRunners(nodes[0]);
            Assert.False(result);
        }

        [Fact]
        public void CycleLoopsToBeginningTwoRunnersTest()
        {
            var nodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            nodes[3].Next = nodes[0];
            var result = DetectCycle.ContainsCycleEfficientUsingFastSlowRunners(nodes[0]);
            Assert.True(result);
        }

        [Fact]
        public void CycleLoopsToMiddleTwoRunnersTest()
        {
            var nodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4, 5 });
            nodes[4].Next = nodes[2];
            var result = DetectCycle.ContainsCycleEfficientUsingFastSlowRunners(nodes[0]);
            Assert.True(result);
        }

        [Fact]
        public void TwoNodeCycleAtEndTwoRunnersTest()
        {
            var nodes = ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4, 5 });
            nodes[4].Next = nodes[3];
            var result = DetectCycle.ContainsCycleEfficientUsingFastSlowRunners(nodes[0]);
            Assert.True(result);
        }

        [Fact]
        public void EmptyListTwoRunnersTest()
        {
            var result = DetectCycle.ContainsCycleEfficientUsingFastSlowRunners(null);
            Assert.False(result);
        }

        [Fact]
        public void OneElementLinkedListNoCycleTwoRunnersTest()
        {
            var node = new LinkedListNode(1);
            var result = DetectCycle.ContainsCycleEfficientUsingFastSlowRunners(node);
            Assert.False(result);
        }

        [Fact]
        public void OneElementLinkedListCycleTwoRunnersTest()
        {
            var node = new LinkedListNode(1);
            node.Next = node;
            var result = DetectCycle.ContainsCycleEfficientUsingFastSlowRunners(node);
            Assert.True(result);
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

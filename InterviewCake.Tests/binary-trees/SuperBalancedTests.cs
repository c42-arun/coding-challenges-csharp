using InterviewCake.binary_trees;
using Xunit;

namespace InterviewCake.Tests.binary_trees
{
    public class SuperBalancedTests
    {
        [Fact]
        public void FullTreeTest()
        {
            var root = new BinaryTreeNode(5);
            var a = root.InsertLeft(8);
            var b = root.InsertRight(6);
            a.InsertLeft(1);
            a.InsertRight(2);
            b.InsertLeft(3);
            b.InsertRight(4);
            var result = SuperBalanced.IsBalanced(root);
            Assert.True(result);
        }

        [Fact]
        public void BothLeavesAtTheSameDepthTest()
        {
            var root = new BinaryTreeNode(3);
            root.InsertLeft(4).InsertLeft(1);
            root.InsertRight(2).InsertRight(9);
            var result = SuperBalanced.IsBalanced(root);
            Assert.True(result);
        }

        [Fact]
        public void LeafHeightsDifferByOneTest()
        {
            var root = new BinaryTreeNode(6);
            root.InsertLeft(1);
            root.InsertRight(0).InsertRight(7);
            var result = SuperBalanced.IsBalanced(root);
            Assert.True(result);
        }

        [Fact]
        public void LeafHeightsDifferByTwoTest()
        {
            var root = new BinaryTreeNode(6);
            root.InsertLeft(1);
            root.InsertRight(0).InsertRight(7).InsertRight(8);
            var result = SuperBalanced.IsBalanced(root);
            Assert.False(result);
        }

        [Fact]
        public void BothSubTreesSuperbalancedTest()
        {
            var root = new BinaryTreeNode(1);
            root.InsertLeft(5);
            var b = root.InsertRight(9);
            b.InsertLeft(8).InsertLeft(7);
            b.InsertRight(5);
            var result = SuperBalanced.IsBalanced(root);
            Assert.False(result);
        }

        [Fact]
        public void OnlyOneNodeTest()
        {
            var root = new BinaryTreeNode(1);
            var result = SuperBalanced.IsBalanced(root);
            Assert.True(result);
        }

        [Fact]
        public void TreeIsLinkedListTest()
        {
            var root = new BinaryTreeNode(1);
            root.InsertRight(2).InsertRight(3).InsertRight(4);
            var result = SuperBalanced.IsBalanced(root);
            Assert.True(result);
        }
    }
}

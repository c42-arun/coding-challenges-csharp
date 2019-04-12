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
    public class DeleteNodeTests
    {
        [Fact]
        public void NodeAtBeginningTest()
        {
            var head = new LinkedListNode(1);
            AppendToList(head, 2);
            AppendToList(head, 3);
            AppendToList(head, 4);

            SinglyLinkedListOps.DeleteNode(head);

            var node = head;
            Assert.Equal(2, node.Value);

            node = node.Next;
            Assert.Equal(3, node.Value);

            node = node.Next;
            Assert.Equal(4, node.Value);

            Assert.Null(node.Next);
        }

        [Fact]
        public void NodeInTheMiddleTest()
        {
            var head = new LinkedListNode(1);
            var nodeToDelete = AppendToList(head, 2);
            AppendToList(head, 3);
            AppendToList(head, 4);

            SinglyLinkedListOps.DeleteNode(nodeToDelete);

            var node = head;
            Assert.Equal(1, node.Value);

            node = node.Next;
            Assert.Equal(3, node.Value);

            node = node.Next;
            Assert.Equal(4, node.Value);

            Assert.Null(node.Next);
        }

        [Fact]
        public void NodeAtTheEndTest()
        {
            var head = new LinkedListNode(1);
            AppendToList(head, 2);
            AppendToList(head, 3);
            var nodeToDelete = AppendToList(head, 4);

            Assert.Throws<InvalidOperationException>(() => SinglyLinkedListOps.DeleteNode(nodeToDelete));
        }

        [Fact]
        public void OneNodeListTest()
        {
            var head = new LinkedListNode(1);
            Assert.Throws<InvalidOperationException>(() => SinglyLinkedListOps.DeleteNode(head));
        }

        private static LinkedListNode AppendToList(LinkedListNode head, int value)
        {
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new LinkedListNode(value);
            return current.Next;
        }
    }
}

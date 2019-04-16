using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.linked_lists.singly_linked
{
    public class ReverseList
    {
        public static LinkedListNode InPlaceReverse(LinkedListNode headOfList)
        {
            // InPlaceReverse the linked list in place
            if (headOfList == null) return null;

            if (headOfList.Next == null) return headOfList;

            LinkedListNode prevNode = headOfList;
            LinkedListNode currentNode = headOfList.Next;

            headOfList.Next = null; // set the head as tail

            // when node == null we have moved past the last node
            // (would be pointed by prevNode at that point)
            while (currentNode != null)
            {
                LinkedListNode currentNext = currentNode.Next;

                currentNode.Next = prevNode; // reverse the pointer on this node

                // move pointers down the list
                prevNode = currentNode;
                currentNode = currentNext;
            }

            return prevNode;
        }

        public static LinkedListNode OutOfPlaceReverse(LinkedListNode headOfList)
        {
            // InPlaceReverse the linked list in place
            if (headOfList == null) return null;

            if (headOfList.Next == null) return new LinkedListNode(headOfList.Value);

            LinkedListNode origCurrNode = headOfList;

            LinkedListNode newPrevNode = null; // is null to start with as would be set as "Next" node for the tail

            while (origCurrNode != null)
            {
                LinkedListNode newCurrentNode = new LinkedListNode(origCurrNode.Value) {Next = newPrevNode};

                newPrevNode = newCurrentNode;
                origCurrNode = origCurrNode.Next;
            }

            return newPrevNode;
        }
    }
}

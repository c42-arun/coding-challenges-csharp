using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.linked_lists.singly_linked
{
    public class KthToLastNode
    {
        public static LinkedListNode GetNodeByNaiveMethod(int k, LinkedListNode head)
        {
            // Return the kth to last node in the linked list

            if (k == 0) throw new ArgumentException();

            // Get length of the LL
            int length = 0;

            LinkedListNode currNode = head;
            while (currNode != null)
            {
                length++;
                currNode = currNode.Next;
            }

            if (k > length) throw new ArgumentException();

            int countFromHead = length - k;
            int counter = 0; // should start from 0 not 1 eg if length is 4 and k is 4 then we need the first item at counter == (length - k) == 0

            currNode = head;

            while (currNode != null)
            {
                if (counter == countFromHead) break;

                currNode = currNode.Next;
                counter++;
            }

            return currNode;
        }

        public static LinkedListNode GetNodeByEfficientStickMethod(int k, LinkedListNode head)
        {
            if (k == 0) throw new ArgumentException();

            LinkedListNode trailingPointer = head;
            LinkedListNode forwardPointer = head;

            for (int counter = 2; counter <= k; counter++)
            {
                forwardPointer = forwardPointer.Next;
                if (forwardPointer == null) throw new ArgumentException();
            }

            while (forwardPointer.Next != null)
            {
                forwardPointer = forwardPointer.Next;
                trailingPointer = trailingPointer.Next;
            }

            return trailingPointer;
        }
    }
}

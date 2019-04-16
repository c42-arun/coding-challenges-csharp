using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.linked_lists.singly_linked
{
    public class DetectCycle
    {
        // O(n) time (which is OK ) & space (can be improved)
        public static bool ContainsCycleBruteForceUsingSet(LinkedListNode firstNode)
        {
            // Check if the linked list contains a cycle
            HashSet<LinkedListNode> set = new HashSet<LinkedListNode>();

            LinkedListNode node = firstNode;

            while (node != null)
            {
                if (set.Contains(node)) return true;

                set.Add(node);

                node = node.Next;
            }

            return false;
        }

        public static bool ContainsCycleEfficientUsingFastSlowRunners(LinkedListNode firstNode)
        {
            LinkedListNode slowRunner = firstNode;
            LinkedListNode fastRunner = firstNode;

            while (fastRunner != null && fastRunner.Next != null)
            {
                slowRunner = slowRunner.Next;
                fastRunner = fastRunner.Next.Next;

                if (fastRunner == slowRunner) return true;
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.linked_lists.singly_linked
{
    public static class SinglyLinkedListOps
    {
       public static void DeleteNode(LinkedListNode node)
       {
           if (node.Next == null) throw new InvalidOperationException();
           node.Value = node.Next.Value;
           node.Next = node.Next.Next;
       }
    }
}

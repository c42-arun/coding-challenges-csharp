namespace InterviewCake.linked_lists
{
    public class LinkedListNode
    {
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }
        public LinkedListNode(int value)
        {
            Value = value;
        }
        public static LinkedListNode AppendToList(LinkedListNode head, int value)
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

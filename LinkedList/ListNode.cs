namespace LinkedList
{
    public class ListNode<T>
    {
        public ListNode(T data)
        {
            Data = data;
        }

        public T Data;
        public ListNode<T> NextNode;
    }
}

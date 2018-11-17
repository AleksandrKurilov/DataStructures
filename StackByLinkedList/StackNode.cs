namespace StackByLinkedList
{
    public class StackNode<T>
    {
        public StackNode(T data)
        {
            Data = data;
        }

        public T Data;
        public StackNode<T> NextNode;
    }
}

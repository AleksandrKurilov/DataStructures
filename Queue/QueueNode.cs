namespace Queue
{
    public class QueueNode<T>
    {
        public QueueNode(T data)
        {
            Data = data;
        }

        public QueueNode<T> NextNode;
        public T Data;
    }
}

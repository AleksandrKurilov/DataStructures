using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    public class QueueStructure<T> : IEnumerable<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;
        private int count;

        public bool IsEmpty => count == 0;
        public int Count => count;

        public void Enqueue(T data)
        {
            var node = new QueueNode<T>(data);
            var tmpNode = tail;
            tail = node;
            if (IsEmpty)
                head = tail;
            else
                tmpNode.NextNode = tail;
            count++;
        }

        public T Dequeue()
        {
            if(IsEmpty)
                throw new InvalidOperationException("Очередь пуста");

            var data = head.Data;

            head = head.NextNode;

            count--;

            return data;
        }

        public void Clear()
        {
            count = 0;
            head = null;
            tail = null;
        }

        public bool Contains(T data)
        {
            var currentNode = head;

            while(currentNode != null)
            {
                if(currentNode.Data.Equals(data))
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.NextNode;
            }
        }
    }
}

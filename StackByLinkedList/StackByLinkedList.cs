using System;
using System.Collections;
using System.Collections.Generic;

namespace StackByLinkedList
{
    public class StackByLinkedList<T> : IEnumerable<T>
    {
        private StackNode<T> head;
        private int count;


        public bool IsEmpty => count < 1;
        public int Count => count;

        public void Push(T item)
        {
            var node = new StackNode<T>(item);
            node.NextNode = head;
            head = node;
            count++;
        }

        public T Pop()
        {
            if(IsEmpty)
                throw new Exception("Стек пуст");

            StackNode<T> tempNode = head;
            head = head.NextNode;
            count--;
            return tempNode.Data;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            StackNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.NextNode;
            }
        }
    }


}

using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;
        private int count;


        public bool IsEmpty => count == 0;
        public int Count => count;

        public void Add(T item)
        {
            var node = new ListNode<T>(item);

            if(head == null)
                head = node;
            else
                tail.NextNode = node;

            tail = node;

            count++;
        }

        public bool Remove(T item)
        {
            ListNode<T> current = head;
            ListNode<T> previous = null;

            while(current != null)
            {
                if(current.Data.Equals(item))
                {
                    if(previous != null)
                    {
                        previous.NextNode = current.NextNode;

                        if(current.NextNode == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.NextNode;

                        if(head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.NextNode;
            }

            return false;
        }

        public bool Contains(T item)
        {
            var node = head;

            while(node != null)
            {
                if(node.Data.Equals(item))
                    return true;

                node = node.NextNode;
            }

            return false;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AppendFirst(T item)
        {
            var node = new ListNode<T>(item);
            node.NextNode = head;
            head = node;
            if(count == 0)
                tail = head;
            count++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            ListNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.NextNode;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    /// <summary>
    /// Стек реализованный при помощи односвязного списка
    /// </summary>
    public class StackByLinkedList<T> : IEnumerable<T>
    {
        private StackNode<T> head;
        private int count;


        public bool IsEmpty => count < 1;
        public int Count => count;

        /// <summary>
        /// Добавляем элемент в стек
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            var node = new StackNode<T>(item);
            node.NextNode = head;
            head = node;
            count++;
        }

        /// <summary>
        /// Возвращает верхний елемент стека
        /// </summary>
        /// <returns></returns>
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

    /// <summary>
    /// Класс описывает единицу Стека, которая хранит в себе данные и указатель на следующую единицу
    /// </summary>
    public class StackNode<T>
    {
        public StackNode(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Данные
        /// </summary>
        public T Data;

        /// <summary>
        /// Указывает на следующий элемент в Стеке
        /// </summary>
        public StackNode<T> NextNode;
    }
}

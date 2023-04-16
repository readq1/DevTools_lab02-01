using System;
using System.Collections;
using System.Collections.Generic;

namespace Wintellect.PowerCollections
{
    public class Stack<T>
    {
        private T[] items;
        private int count;
        const int n = 10;
        public Stack()
        {
            i = new T[n];
        }
        public Stack(int Capacity = 100)
        {
            items = new T[Capacity];
        }
        public int Capacity
        {
            get { return items.Length; }
        }
        // пуст ли стек
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        // размер стека
        public int Count
        {
            get { return count; }
        }
        // добвление элемента
        public void Push(T item)
        {
            // если стек заполнен, выбрасываем исключение
            if (count == Capacity)
                throw new System.InvalidOperationException("Переполнение");
            items[count++] = item;
        }

        public T Pop()
        {

            if (IsEmpty)
                throw new System.InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T);
            return item;
        }

        public T Peek()
        {

            if (IsEmpty)
                throw new System.InvalidOperationException("Стек пуст");
            return items[count - 1];
        }

    }
}

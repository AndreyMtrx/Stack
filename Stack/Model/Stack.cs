using System;

namespace Stack.Model
{
    public class Stack<T>
    {
        private T[] items;
        private int count;
        private const int n = 10;
        public int Count => items.Length;
        public bool IsEmpty => count == 0;

        public Stack()
        {
            items = new T[n];
        }

        public Stack(int length)
        {
            items = new T[length];
        }

        public void Push(T item)
        {
            if (count == items.Length)
            {
                Resize(items.Length + 10);
            }
            items[count++] = item;
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                T item = items[--count];
                items[count] = default(T);
                return item;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public T Peek()
        {
            return items[count - 1];
        }

        public void Resize(int max)
        {
            T[] tempItems = new T[max];
            for (int i = 0; i < count; i++)
            {
                tempItems[i] = items[i];
            }
            items = tempItems;
        }

        public override string ToString()
        {
            return "Stack";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXercise6
{
    public class Stack<T>
    {
        private T[] items;
        private int top; // Index pointing to the top of the stack

        public Stack(int capacity)
        {
            items = new T[capacity];
            top = -1; // Initialize top to -1 (empty stack)
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                Console.WriteLine("Stack overflow!"); // Check if the stack is full
                return;
            }

            top++;
            items[top] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T poppedItem = items[top];
            top--;
            return poppedItem;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return items[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}

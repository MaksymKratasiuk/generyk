using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generyk
{

    public class Stack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            int lastIndex = items.Count - 1;
            T lastItem = items[lastIndex];
            items.RemoveAt(lastIndex);

            return lastItem;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return items[items.Count - 1];
        }

        public int Count
        {
            get { return items.Count; }
        }
    }
    internal class Task4
    {
        public static void task4()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Peek()); // 3

            int topItem = stack.Pop();
            Console.WriteLine(topItem); // 3
            Console.WriteLine(stack.Peek()); // 2

            Console.WriteLine(stack.Count); // 2
        }
    }
}
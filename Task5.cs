using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generyk
{
    public class Queue<T>
    {
        private List<T> items = new List<T>();

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            T firstItem = items[0];
            items.RemoveAt(0);

            return firstItem;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            return items[0];
        }

        public int Count
        {
            get { return items.Count; }
        }
    }

    internal class Task5
    {
        public static void task5()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Peek()); // 1

            int firstItem = queue.Dequeue();
            Console.WriteLine(firstItem); // 1
            Console.WriteLine(queue.Peek()); // 2

            Console.WriteLine(queue.Count); // 2

        }
    }
}

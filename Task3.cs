using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generyk
{
    class Sum<T>
    {
        public static T sum(T[] arr)
        {
            dynamic sum = 0;
            dynamic i; 
            foreach (var item in arr)
            {
                i = item;
                sum += i;
            }
            return sum;
        }
    }
    internal class Task3
    {
        public static void task3()
        {
            int[] arr = { 1, 2, 3, 4, 5};

            Console.WriteLine("Array : ");
            foreach(var item in arr)
            {
                Console.Write(item+" ");
            }


            Console.WriteLine($"sum = {Sum<int>.sum(arr)}");
        }
    }
}

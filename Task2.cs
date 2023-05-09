using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generyk
{
    class Min<T>
    {
        public T Minimum(T first, T second, T third)
        {
            T[] arr = new T[3];
            arr[0] = first;
            arr[1] = second;
            arr[2] = third;
            return arr.Min();
        }
    }
    internal class Task2
    {
        public static void task2()
        {

            Console.WriteLine("enter three int numbers : ");
            int one_int, two_int, three_int;
            one_int = int.Parse(Console.ReadLine());
            two_int = int.Parse(Console.ReadLine());
            three_int = int.Parse(Console.ReadLine());

            Min<int> max_int = new Min<int>();
            Console.WriteLine($"Minimum : {max_int.Minimum(one_int, two_int, three_int)}");



            Console.WriteLine("enter three int double : ");
            double one_double, two_double, three_double;

            one_double = double.Parse(Console.ReadLine());
            two_double = double.Parse(Console.ReadLine());
            three_double = double.Parse(Console.ReadLine());


            Min<double> max_double = new Min<double>();
            Console.WriteLine($"Minimum : {max_double.Minimum(one_double, two_double, three_double)}");



        }
    }
}

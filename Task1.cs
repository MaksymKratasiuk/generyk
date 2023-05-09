using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace generyk
{
    class Max<T>
    {
        public T Maximum(T first,T second,T third)
        {
            T []arr = new T[3];
            arr[0] = first;
            arr[1] = second;
            arr[2] = third;
            return arr.Max();
        }
    }
    internal class Task1
    {
        public static void task1()
        {
            
            Console.WriteLine("enter three int numbers : ");
            int one_int, two_int, three_int;
            one_int = int.Parse(Console.ReadLine());
            two_int = int.Parse(Console.ReadLine());
            three_int = int.Parse(Console.ReadLine());

            Max<int> max_int = new Max<int>();
            Console.WriteLine($"Maximum : {max_int.Maximum(one_int,two_int,three_int)}");



            Console.WriteLine("enter three int double : ");
            double one_double, two_double, three_double;

            one_double = double.Parse(Console.ReadLine());
            two_double = double.Parse(Console.ReadLine());
            three_double = double.Parse(Console.ReadLine());


            Max<double> max_double = new Max<double>();
            Console.WriteLine($"Maximum : {max_double.Maximum(one_double, two_double, three_double)}");



        }
    }
}

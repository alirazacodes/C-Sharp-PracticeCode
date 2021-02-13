using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysV2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Types of Arrays:

            // 1. Rectangular Array
            // 2. Jagged Array (array of arrays) or (no. rows != no. columns)

            var numbers = new int[] {2, 3, 4, 1, 2, 4, 23, 2};

            //Length
            Console.WriteLine("length: " + numbers.Length);

            // IndexOf()
            // Note: when there are different ways to call a method that is called as method overloading
            Console.WriteLine(Array.IndexOf(numbers, 23));

            //Clear()
            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of the copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of sorting()");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Reverse()

            Array.Reverse(numbers);
            Console.WriteLine("Effect of reverse()");

            foreach(var n in numbers)
                Console.WriteLine(n);
        }
    }
}

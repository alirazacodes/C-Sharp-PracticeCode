using System;


namespace Varibales
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 10.23f;
            var character = 'a';
            var firstName = "ALi";
            var working = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(working);
            Console.WriteLine("\n");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            const float pi = 3.14f;

            pi = 32.1f; // using constants keywords causes no further change in the value of the value of the varibale or identifier
                        // for security purposes.
        }
    }
}

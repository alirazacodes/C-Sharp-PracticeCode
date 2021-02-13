using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Ali Raza ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Ali", "Ghost"));

            if (string.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25"; 
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 23.23f;
            Console.WriteLine(price.ToString("C"));

        }
    }
}

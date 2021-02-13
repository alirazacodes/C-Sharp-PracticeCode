using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Math;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            person ali = new person();
            ali.Firstname = "Ali";
            ali.LastName = "Raza";
            ali.Introduce();

            calculator calculators = new calculator();

            var result = calculator.Add(1, 2);
            Console.WriteLine(result); 
        }
    }
}

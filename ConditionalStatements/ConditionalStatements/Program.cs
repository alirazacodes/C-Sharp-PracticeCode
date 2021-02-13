using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn and beautiful.");
                    break;
                case Season.Summer:
                    Console.WriteLine("Its got it's own colors.");
                    break;
                default:
                    Console.WriteLine("I dont understand");
                    break;
            }
        }
    }
}

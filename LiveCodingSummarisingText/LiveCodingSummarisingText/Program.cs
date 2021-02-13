using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSumarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "Is this is the End to everything that is gone now????????";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);


        }

        

    }
}

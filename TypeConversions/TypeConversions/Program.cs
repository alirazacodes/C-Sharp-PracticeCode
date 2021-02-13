using System;


namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Types of type conversions:

            // Implicit Conversion:  no data loss happens
            /*  In implicit due to no data loss the data type can be converted following ways;
             *  
             *  int a = 12;
             *  float b = a;
                */

            int a = 12;
            float b = a;
            Console.WriteLine(b);
            // Explicit Conversion (type casting): there is data loss
            /*  In explicit due to the data loss, when we are trying to convert a varibale of smaller data type to a higher data
             *  type then we use type casting like;
              
                byte a = 12;
                int b = (int)a;*/

            int b1 = 12;
            byte c = (byte)b1;
            Console.WriteLine(c);

            // Conversion between non-Compatible types.
            /* like;
             
                string a = "1";
                int i = Convert.ToInt32(a);
                int j = parse.(a)
            
                byte ==> ToByte()
                Integer ==> ToInt32()
                shortByte ==> ToInt16()
                long ==> ToInt64()*/

            string abc = "1234";
            int bbc = Convert.ToInt32(abc);
            Console.WriteLine(bbc);

            //try and catch exception: in order to avoid unwantede exceptions

            try
            {
                string abc1 = "1234";
                byte bbc1 = Convert.ToByte(abc1);
                Console.WriteLine(bbc);
            }
            catch (Exception)
            {
                Console.WriteLine("there is an overflow in the values while converting from one type to another!");
            }

        }
    }
}

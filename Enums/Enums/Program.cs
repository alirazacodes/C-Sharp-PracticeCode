using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum ShippingMehtod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMehtod.Express;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((ShippingMehtod)methodID);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMehtod = (ShippingMehtod) Enum.Parse(typeof(ShippingMehtod), methodName);
        }
    }
}

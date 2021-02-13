using System;

namespace Classes
{
    public class person
    {
        public string Firstname;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + Firstname + " " + LastName);
        }
    }
}

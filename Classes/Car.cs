using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public string Name { get; set; }

        public string Make { get; set; }

        public int Year { get; set; }

        public string Model { get; set; }

        public void CustomerGreeting()
        {
            Console.WriteLine($"Welcome {Name}. We have you checked in.");
        }
        public void CusotmerCheckOut()
        {
            Console.WriteLine($"{Name} we have a your car as a {Year} {Make} {Model} ready to go.");
        }

    }
}

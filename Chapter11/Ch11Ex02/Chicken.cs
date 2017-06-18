using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex02
{
    class Chicken:Animal
    {
        public void LayEggs()
        {
            Console.WriteLine($"{name} has layed an egg.");
        }

        public Chicken(string newName) : base(newName)
        {

        }
    }
}

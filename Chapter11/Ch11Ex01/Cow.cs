using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex01
{
    class Cow:Animal
    {
        public void Mild(string newName)
        {
            Console.WriteLine($"{name} has been milked.");
        }

        public Cow(string newName) : base(newName)
        {

        }
    }
}

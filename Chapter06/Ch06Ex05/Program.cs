using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{args.Length} command lin arguments were specified:");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}

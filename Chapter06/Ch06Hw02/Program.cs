using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Hw02
{
    class Program
    {
        static void Main(string[] args)
        {
            string argString;
            int argInt;

            argString = args[0];
            argInt = Convert.ToInt32(args[1]);

            Console.WriteLine(argString);
            Console.WriteLine(argInt);
        }
    }
}

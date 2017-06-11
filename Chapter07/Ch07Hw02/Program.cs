using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07Hw02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 10000 ; i++)
            {
                Console.WriteLine(intArray[(int)(i / 1000)]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes pirmesFrom2to1000 = new Primes(2, 100000);
            foreach (long i in pirmesFrom2to1000)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

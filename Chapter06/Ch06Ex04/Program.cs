using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex04
{
    class Program
    {
        static string myString;
        static void Write()
        {
            string myString = "String defined in Write()";
            Console.WriteLine("Now in Write()");
            Console.WriteLine($"myString ={myString}");
        }
        static void Main(string[] args)
        {
            string myString = "String defined in Main()";
            Program.myString = "Global myString";
            Write();
            Console.WriteLine("now in main()");
            Console.WriteLine($"myString = {myString}");
            Console.WriteLine($"global myString = {Program.myString}");
        }
    }
}

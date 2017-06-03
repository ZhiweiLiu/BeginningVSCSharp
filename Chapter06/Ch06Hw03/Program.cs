using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Hw03
{
    class Program
    {
        delegate string inputDelegate();
        static void Main(string[] args)
        {
            inputDelegate inputdelegate;
            inputdelegate =new inputDelegate(Console.ReadLine);
            string input = inputdelegate();
            Console.WriteLine(input);
        }
    }
}

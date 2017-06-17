using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Hw01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass baseclass = new MyClass();
            baseclass.ContainedString = "lalalalala";
            MyDerivedClass testClass = new MyDerivedClass();
            string output1 = testClass.getString();
            Console.WriteLine(output1);
        }
    }
}

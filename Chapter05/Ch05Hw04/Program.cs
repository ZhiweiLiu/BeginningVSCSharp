using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Hw04
{
    class Program
    {
        static void ReverseOutput(string str)
        {
            string myString = str;
            char[] myChar = myString.ToCharArray();
            Array.Reverse(myChar);
            myString = String.Concat(myChar);
            Console.WriteLine(myString);
        }
        static void yes2no(string str)
        {
            string myString = str;
            myString = myString.Replace("no", "yes");
            Console.WriteLine(myString);
        }
        static void addquote(string str)
        {
            string[] strArray = str.Split(' ');
            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = "\"" + strArray[i] + "\"";
            }

            string myString;
            myString = String.Join(" ", strArray);
            Console.WriteLine(myString);
        }
        static void Main(string[] args)
        {
            Console.WriteLine( "please input a string:");
            string myString = Console.ReadLine();
            ReverseOutput(myString);
            yes2no(myString);
            addquote("this is test");
        }
    }
}

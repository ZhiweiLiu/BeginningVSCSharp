using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendName = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            int i;
            Console.WriteLine($"Here are {friendName.Length} of my friends:");
            //for (i = 0; i < friendName.Length; i++)
            //{
            //    Console.WriteLine(friendName[i]);
            //}

            foreach (string name in friendName)
            {
                Console.WriteLine(name);
            }
        }
    }
}

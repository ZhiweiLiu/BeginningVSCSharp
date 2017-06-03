using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex02
{
    class Program
    {
        static int MaxValue(int[] intArray,out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] >maxVal)
                {
                    maxVal = intArray[i];
                    maxIndex = i;
                }

            }
            return maxVal;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxIndex;
            int maxVal = MaxValue(myArray,out maxIndex);
            Console.WriteLine($"The maximum value in myArray is {maxVal}");
            Console.WriteLine($"The first occurrence of this value is at element {maxIndex + 1}");
        }

    }
}

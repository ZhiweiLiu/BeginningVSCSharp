using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Hw02
{
    enum color : byte
    {
        red,yellow, green,blue,pink,purple,brown,black,white
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"彩虹的颜色有{color.black},{color.red},{color.yellow},{color.green},{color.blue},{color.pink},{color.purple},{color.white},{color.brown}");
            byte black_short = (byte)color.black;
            Console.WriteLine(black_short);
        }
    }
}

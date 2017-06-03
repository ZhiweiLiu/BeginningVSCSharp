using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex02
{
    enum orientation : byte
    {
        north=1,
        south=2,
        east=3,
        west=4
    }

    class Program
    {
        static void Main(string[] args)
        {
            byte directionByte;
            string directionString;
            orientation myDirection = orientation.north;
            Console.WriteLine($"myDirection = {myDirection}");
            //枚举中的值转换为其他类型，必须使用显式转换。即使orientation的基本类型是byte，也必须使用（byte）强制实现类型转换。
            //同样的如果将下面的directionByte再转化为orientation类型，也是需要显式（orientation）来转化
            directionByte = (byte)myDirection;
            //要获得枚举的字符串值，可以使用Convert.ToString();或者使用变量本身的ToString()命令
            //不能通过（string）进行强制转换
            directionString = Convert.ToString(myDirection);
            Console.WriteLine("byte equivalent = {0}", directionByte);
            Console.WriteLine("string equivalent = {0}", directionString);
            //也可以把string转换为枚举值
            string myWest = "west";
            myDirection = (orientation)Enum.Parse(typeof(orientation), myWest);
            Console.WriteLine("通过字符串转换为枚举值，myWest={0}", myWest);
        }
    }
}

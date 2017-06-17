using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Hw04
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCopyableClass obj1 = new MyCopyableClass();
            obj1.myIntPro = 5;
            MyCopyableClass obj2 = obj1.GetCopy();
            obj1.myIntPro = 9;

            //结果是5和9，说明通过该方法复制的类是一个新的位置，改变原来的类的属性不会改变复制的这个对象的属性
            Console.WriteLine(obj2.myIntPro);
            Console.WriteLine(obj1.myIntPro);
        }
    }
}

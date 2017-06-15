using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Ex01
{
    class MyClass
    {
        //只读的字符串字段 name
        public readonly string Name;
        private string myString;
        
        //私有的int字段 
        private int intVal;
        //私有的int 属性
        public int Val
        {
            get { return intVal; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    intVal = value;
                }
                else
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10."));
            }
        }
        //重载的方法 
        public override string ToString() => "Name:" + Name + "\nVal:" + Val;
        //构造函数
        private MyClass():this("Default Name") { }
        //构造函数
        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
        }
        //私有的字段
        private int myDoubledInt=5;
        //私有的属性，使用表达式创建
        public int myDoubledIntProp => (myDoubledInt * 2);

        public string MyString
        {
            get
            {
                return myString;
            }

            set
            {
                myString = value;
            }
        }
    }
   
}

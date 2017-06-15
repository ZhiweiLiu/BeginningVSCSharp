using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Ex02
{
    public class ClassA
    {
        private int state = -1;
        public int State
        {
            get { return state; }
        }  
        public class ClassB
        {
            public void SetPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个ClassA的对象
            ClassA myObject = new ClassA();
            Console.WriteLine($"myObject.State = {myObject.State}");
            //创建一个ClassB的对象
            ClassA.ClassB myOtherObject = new ClassA.ClassB();
            //调用B的方法来改变对象A中的成员
            myOtherObject.SetPrivateState(myObject, 999);
            Console.WriteLine($"myObject.State = {myObject.State}");
            //目的是为了说明，嵌套类可以访问被嵌套类中的成员，即使该成员是私有的
            Console.ReadKey();
        }
    }
}

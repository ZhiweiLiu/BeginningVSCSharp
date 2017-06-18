using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用数组形式来定义动物的集合
            Console.WriteLine("Create an Array type collection of animal objcets and use it.");
            //数组的初始化中必须确定数组的长度
            Animal[] animalArray = new Animal[2];
            Cow cow1 = new Cow("Deirdre");
            //给数组中的元素赋值的方式
            animalArray[0] = cow1;
            animalArray[1] = new Chicken("Ken");
            foreach (Animal myanimal in animalArray)
            {
                Console.WriteLine("New {0} object added to Array collection, Name = {1}", myanimal.ToString(), myanimal.Name);
            }
            Console.WriteLine("Array collection contains {0} objects.", animalArray.Length);
            //简单数组是强类型的，可以直接访问它们所包含的类的类型
            //因为数组的类型是抽象类型Animal，所以不能直接调用由派生类提供的方法，必须使用数据类型转换
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEggs();
            Console.WriteLine();

            Console.WriteLine("Create an ArrayList type collection of animal objects and use it");
            ArrayList animalArrayList = new ArrayList();
            Cow cow2 = new Cow("Heyley");
            animalArrayList.Add(cow2);
            animalArrayList.Add(new Chicken("Roy"));

            foreach (Animal myAnimal in animalArrayList)
            {
                Console.WriteLine("New {0} object added to Array collection, Name = {1}", myAnimal.ToString(), myAnimal.Name);
            }

            Console.WriteLine("ArrayList collection contains {0} objects.", animalArrayList.Count);

            //ArrayList 集合是 System.Object 对象的集合(通过多态性赋给 Animal 对象)，所以必须用所有的项进行数据类型转换
            ((Animal)animalArrayList[0]).Feed();
            ((Chicken)animalArrayList[1]).LayEggs();
            Console.WriteLine();
            Console.WriteLine("Additionnal manipulation of Arraylist");
            animalArrayList.RemoveAt(0);
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);
            ((Chicken)animalArrayList[2]).LayEggs();
            Console.WriteLine("The animal called {0} is at index {1}.", cow1.Name, animalArrayList.IndexOf(cow1));
            cow1.Name = "Janice";
            Console.WriteLine("The animal is called {0} now.", ((Animal)animalArrayList[1]).Name);
            Console.ReadKey();

        }
    }
}

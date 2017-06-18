using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex02
{
    class Animals:CollectionBase
    {
        //添加一个元素
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }
        //移除一个元素
        public void Remove(Animal oldAnimal)
        {
            List.Remove(oldAnimal);
        }
        //增加索引符
        public Animal this[int animalIndex]
        {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
}

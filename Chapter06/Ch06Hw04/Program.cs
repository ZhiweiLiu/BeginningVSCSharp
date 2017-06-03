using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Hw04
{
    struct order
    {
        public string name;
        public int unitCount;
        public double unitCost;

        public double totalCost()
        {
            return unitCount * unitCost;
        }
        
        public void display()
        {
            Console.WriteLine($"{unitCount} {name} items at ${unitCost} each,");
            Console.WriteLine($"total cost ${totalCost()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            order myOrder = new order();
            myOrder.unitCost = 10.0;
            myOrder.unitCount = 5;
            myOrder.name = "pizza";

            myOrder.display();
            //Console.WriteLine("totalcost of myOrder is {0}", myOrder.totalCost());
        }
    }
}

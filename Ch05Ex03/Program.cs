﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex03
{
    enum orientation : byte
    {
        noth=1,
        south=2,
        east=3,
        west=4
    }
    struct route
    {
        public orientation direction;
        public double distance;
    }
    class Program
    {
        static void Main(string[] args)
        {
            route myRoute;
            int myDirection = -1;
            double myDistance;
            Console.WriteLine("1) noth\n2) south\n3) east\n4) west");
            do
            {
                Console.WriteLine("Select a direction:");
                myDirection = Convert.ToInt32(Console.ReadLine());
            }
            while(myDirection<1 || myDirection>4);

            Console.WriteLine("Input a distance:");
            myDistance = Convert.ToDouble(Console.ReadLine());
            myRoute.direction = (orientation)myDirection;
            myRoute.distance = myDistance;

            Console.WriteLine($"myRoute specifies a direction of {myRoute.direction} " + $"and a distance of {myRoute.distance}");
        }
    }
}

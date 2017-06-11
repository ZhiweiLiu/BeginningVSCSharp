using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    class Program
    {
        public static void AddPassenger(IPassengerCarrier vehicle)
        {
            Console.WriteLine(vehicle.ToString());
        }
        static void Main(string[] args)
        {
            AddPassenger(new PassengerTrain());
            AddPassenger(new Compact());
            AddPassenger(new SUV());
        }
    }
}

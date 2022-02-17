using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carType = { "Mazda", "Toyota", "Tesla" };
            Car c1 = new Car("Mazda", false, true);
            Car c2 = new Car("Toyota", false, true);
            Car c3 = new Car("Tesla", false, true);

            Garage garage = new Garage(carType);
            garage.AddCar(c1);
            garage.AddCar(c2);
            garage.FixCar(c1);
            garage.TakeOutCar(c1);
            Console.WriteLine(garage.Cars[0].Brand);
            Console.WriteLine(garage.Cars[1].Brand);
            Console.WriteLine(garage.Cars[3].Brand);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            Car car1 = new Car("Dacia", "Logan", "Beige", 170000, false);
            Car car2 = new Car("Toyota", "Yaris", "Rød", 89000, true);

            newCar.PrintInfo(car1);
            newCar.PrintInfo(car2);

            Car myCar = new Car("Honda", "Civic", "Hvid", 199999, false);
            myCar.PrintInfo(myCar);

            Console.ReadLine();

            // Opgave 18.3

            Console.WriteLine(myCar);

            Console.ReadLine();

        }


    }
}

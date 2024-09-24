using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Opgave 16
using CarHandler;

namespace Opgave_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LearnCar();
            //ListCar();
            AdministrateCar();

        }

        // Opgave 16.1
        static void LearnCar()
        {
            Car newCar = new Car ( "Ford", "Mustang", 1966, "Rød" );

            Console.WriteLine(newCar.ToString()); // Udskriver ikke "Rød"
            Console.WriteLine(newCar.GetInfo()); // Udskriver alt

            newCar.Color = "Blue";

            Console.WriteLine(newCar.ToString()); // Udskriver ikke "Blue"
            Console.WriteLine(newCar.GetInfo()); // Udskriver alt

            Console.ReadLine();

            Console.WriteLine(newCar.StartCar()); // True eller False

            Console.ReadLine();
        }

        // Opgave 16.2
        static void ListCar()
        {
            List<Car> cars = new List<Car>();

            Car car1 = new Car("Ford", "Mustang", 1966, "Rød");
            Car car2 = new Car("Porsche", "911", 2004, "Sølv");

            cars.Add(car1);
            cars.Add(car2);

            Console.WriteLine("informationer om bilerne:");
            foreach (Car c in cars)
            {
                Console.WriteLine(c.GetInfo());
            }
            Console.ReadLine();
            foreach (Car c in cars)
            {
                Console.WriteLine(c); // Udskriver ikke farverne
            }
            Console.ReadLine();
        }

        // Opgave 16.3
        static void AdministrateCar()
        {
            List<Car> cars = new List<Car>();

            Car car1 = new Car("Ford", "Mustang", 1966, "Rød");
            Car car2 = new Car("Porsche", "911", 2004, "Sølv");

            cars.Add(car1);
            cars.Add(car2);

            string input = "";
            string searchMake = "";
            bool ifTrue = false;
            int countLoop = 0;
            
            do
            {
                Console.WriteLine("Hej og velkommen til biladministrationen version 1997");
                Console.WriteLine("Du har nu to muligheder. Ønsker du at:");
                Console.WriteLine("Indtaste en bil (1)?");
                Console.WriteLine("Se informationer om alle biler (2)");
                Console.WriteLine("Søge efter et bilmærke (3)");
                Console.WriteLine("Luk programmet (4)");
                Console.Write("Tast dit ønske: ");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "1")
                {
                    Console.WriteLine("Du ville nu indtaste en ny bil.");
                    Console.Write("Indtast udvikler: ");
                    string make = Console.ReadLine();
                    Console.Write("Indtast model: ");
                    string model = Console.ReadLine();
                    Console.Write("Indtast produktionsår: ");
                    int productionYear = int.Parse(Console.ReadLine());
                    Console.Write("Indtast farve: ");
                    string color = Console.ReadLine();

                    Car newCar = new Car(make, model, productionYear, color);
                    cars.Add(newCar);

                    // Opgave 16.5
                    while (ifTrue == false)
                    {
                        ifTrue = newCar.StartCar();
                        countLoop++;
                    }

                    Console.WriteLine("{0} {1} ({2}) brugte {3} forsøg for at starte.", make, model, productionYear, countLoop);
                    countLoop = 0;

                }
                else if (input == "2")
                {
                    Console.WriteLine("Informationer om alle biler:");
                    foreach (Car c in cars)
                        Console.WriteLine(c.GetInfo());
                }
                // Opgave 16.4
                else if (input == "3")
                {
                    Console.Write("Vilket mærke vil du søge efter?: ");
                    searchMake = Console.ReadLine();
                    foreach (Car c in cars)
                    {
                        if (c.Make.ToLower() == searchMake.ToLower())
                            Console.WriteLine(c.GetInfo());
                    }
                }

                Console.ReadLine();
                Console.Clear();
            } while (input != "4");

            Console.WriteLine("Du har luket programmet.");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Opgave_18
{
    internal class Car
    {
        // Opgave 18.1
        public string Make;
        public string Model;
        public string Color;
        public int Price;
        public bool IsSold;
        public bool IsOnSale;

        public void PrintInfo(Car carName)
        {
            if (carName.IsSold == true)
                Console.WriteLine("SOLGT! Bilen er en {0} {1} i farven {2}. Prisen er {3} DKK", carName.Make, carName.Model, carName.Color, carName.Price);
            else
                Console.WriteLine("Bilen er en {0} {1} i farven {2}. Prisen er {3} DKK", carName.Make, carName.Model, carName.Color, carName.Price);
        }

        // Opgave 18.2

        public Car()
        {
            Make = "";
            Model = "";
            Color = "";
            Price = 0;
            IsSold = false;
            IsOnSale = false;
        }

        public Car(string inMake, string inModel, string inColor, int inPrice, bool inIsSold)
        {
            Make = inMake;
            Model = inModel;
            Color = inColor;
            Price = inPrice;
            IsSold = inIsSold;
            IsOnSale = false;
        }

        // Opgave 18.3
        public override string ToString()
        {
            return $"{Make} {Model}";
        }

        // Opgave 18.4
        public void PutOnSale(Car saleCar)
        {
            saleCar.IsOnSale = true;
            saleCar.Price = (Price / 100) * 90;
        }

    }
}

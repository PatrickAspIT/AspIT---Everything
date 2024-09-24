using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_15
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("Patrick");
            SayGoodbye("Patrick");

            int doubleValue = DoubleUp(10);
            Console.WriteLine(doubleValue);

            int addition = Addition(10, 4);
            Console.WriteLine(addition);

            int biggest = ReturnBiggest(13, 10);
            Console.WriteLine(biggest);

            string[] test = { "Patrick", "Oliver", "Chris", "Michael", "Noah" };
            PrintArray(test);

            Console.ReadLine();

        }

        // Opgave 15.1 + 15.2
        private static void SayHello(string name)
        {
            Console.WriteLine("Hejsa {0}", name);
        }

        private static void SayGoodbye(string name)
        {
            Console.WriteLine("Farvel {0}", name);
        }

        // Opgave 15.3
        private static int DoubleUp(int number)
        {
            number = number * 2;
            return number;
        }

        // Opgave 15.4
        private static int Addition(int a, int b)
        {
            int calc = a + b;
            return calc;
        }

        // Opgave 15.5
        private static int ReturnBiggest(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        // Opgave 15.6
        private static void PrintArray(string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }
    }
}

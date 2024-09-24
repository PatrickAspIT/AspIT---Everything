using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertArray();
            //ArrayClassName();
            //ArrayNumbers();
            AddNumber();

        }

        // Opgave 13.1
        static void InsertArray()
        {
            int[] intArray = new int[5];
            intArray[0] = 25;
            intArray[1] = 28;
            intArray[2] = 15;
            intArray[3] = 35;
            intArray[4] = 14;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.ReadLine();
        }

        // Opgave 13.2
        static void ArrayClassName()
        {
            string[] names = new string[6] { "Patrick", "Noah Obi", "Noah2", "Simon", "Oliver", "Mikkel" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            names[0] = "Kong Patrick";
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();
        }

        // Opgave 13.3
        static void ArrayNumbers()
        {
            int[] numbers = new int[10] { 7, 79, 95, 73, 78, 18, 76, 80, 60, 21 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();

            Array.Sort(numbers); // Sorteret dem i størrelse fra mindste til største

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine(); // Sorteret dem i størrelse fra største til mindste

            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }

        // Opgave 13.4
        static void AddNumber()
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += 5;
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}

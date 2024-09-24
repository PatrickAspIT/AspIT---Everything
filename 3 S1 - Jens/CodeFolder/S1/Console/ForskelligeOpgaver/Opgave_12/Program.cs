using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintTable1();
            //PrintTable2();
            //PrintTable3();
            SolveLoop();
        }

        // Opgave 12.1
        static void PrintTable1()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
            for (int k = 1; k < 21; k++)
            {
                if (k%2 == 0)
                    Console.WriteLine(k);
            }
            Console.ReadLine();
            for (int l = 1; l < 21; l++)
            {
                if (l % 2 != 0)
                    Console.WriteLine(l);
            }

            Console.ReadLine();
        }

        // Opgave 12.2
        static void PrintTable2()
        {
            int tableSeven = 7;
            int tableThirteen = 13;
            int currentTable = 0;

            for (int i = 0; i < 10; i++)
            {
                currentTable += tableSeven;
                Console.WriteLine(currentTable);
            }
            Console.ReadLine();
            Console.Clear();
            currentTable = 0;

            for (int i = 0; i < 10; i++)
            {
                currentTable += tableThirteen;
                Console.WriteLine(currentTable);
            }
            Console.ReadLine();
            Console.Clear();
            currentTable = 0;

            Console.Write("Skriv et tal som der udskrives som en tabel: ");
            int writtenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                currentTable += writtenNumber;
                Console.WriteLine(currentTable);
            }
            Console.ReadLine();


        }

        // Opgave 12.3
        static void PrintTable3()
        {
            int tableNumber = 1;
            int increaseNumber = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tableNumber.ToString().PadLeft(4));
                    tableNumber += increaseNumber;
                }
                Console.WriteLine();
                increaseNumber++;
                tableNumber = increaseNumber;
            }

            Console.ReadLine();
        }

        // Opgave 12.4
        static void SolveLoop()
        {
            // a:
            Console.WriteLine("Udskriver 10 slag med en terning:");
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(1,7));
            }
            Console.ReadLine();
            Console.Clear();

            // b:
            int checkNumber;
            Console.WriteLine("Slår med en terning indtil at du slår en 6'er.");
            do
            {
                checkNumber = rnd.Next(1, 7);
                Console.WriteLine(checkNumber);
            } while (checkNumber != 6);
            Console.ReadLine();
        }
    }
}

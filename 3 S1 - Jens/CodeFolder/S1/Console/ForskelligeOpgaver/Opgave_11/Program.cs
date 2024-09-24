using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintLoop1();
            //PrintLoop2();
            //PrintLoop3();
            AskNumber();
        }

        // Opgave 11.1
        static void PrintLoop1()
        {
            int oneToTen = 1;
            int tenToOne = 10;
            int evenNumber = 1;
            int unevenNumber = 1;

            while (oneToTen < 11)
            {
                Console.WriteLine(oneToTen);
                oneToTen++;
            }
            Console.WriteLine();
            while (tenToOne > 0)
            {
                Console.WriteLine(tenToOne);
                tenToOne--;
            }
            Console.WriteLine();
            while (evenNumber < 21)
            {
                if (evenNumber%2 == 0)
                    Console.WriteLine(evenNumber);
                evenNumber++;
            }
            Console.WriteLine();
            while (unevenNumber < 21)
            {
                if (unevenNumber%2 != 0)
                    Console.WriteLine(unevenNumber);
                unevenNumber++;
            }

            Console.ReadLine();
        }

        // Opgave 11.2
        static void PrintLoop2()
        {
            int tableCounter = 0;
            int tableSeven = 7;
            int tableThirteen = 13;
            int increaseValue = tableSeven;
            while (tableCounter < 10)
            {
                Console.WriteLine(tableSeven);
                tableSeven += 7;
                tableCounter++;
            }
            Console.WriteLine();
            tableCounter = 0;
            increaseValue = tableThirteen;
            while (tableCounter < 10)
            {
                Console.WriteLine(tableThirteen);
                tableThirteen += 13;
                tableCounter++;
            }
            Console.WriteLine();
            tableCounter = 0;
            Console.ReadLine();
            Console.Clear();

            Console.Write("Skriv et tal og programmet vil udskrive den tabel: ");
            int tableRandom = int.Parse(Console.ReadLine());
            increaseValue = tableRandom;
            while (tableCounter < 10)
            {
                Console.WriteLine(tableRandom);
                tableRandom += increaseValue;
                tableCounter++;
            }

            Console.ReadLine();
        }

        // Opgave 11.3
        static void PrintLoop3()
        {
            int loop = 1;
            int number = 1;
            int resetNumber = 1;
            int tableNumber = 1;
            while (loop < 11)
            {
                while (number < 11)
                {
                    Console.Write(tableNumber.ToString().PadLeft(4));
                    tableNumber += resetNumber;
                    number++;
                }
                resetNumber++;
                Console.WriteLine();
                tableNumber = resetNumber;
                number = 1;
                loop++;
            }
            

            Console.ReadLine();
        }

        // Opgave 11.4
        static void AskNumber()
        {
            int input = 0;
            bool inputCheck = false;
            do
            {
                Console.Write("Indtast et tal mellem 1 og 10: ");
                input = int.Parse(Console.ReadLine());

                if (input > 1 && input < 10)
                    inputCheck = true;
                else
                    Console.Clear();

            } while (inputCheck == false);
            Console.WriteLine("Du indtastede {0}!", input);
            Console.ReadLine();
            

        }
    }
}

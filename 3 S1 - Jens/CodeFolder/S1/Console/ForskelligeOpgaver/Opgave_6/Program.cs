using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //DiscountPrice();
            //RisingOrder1();
            //RisingOrder2();
            //IdenticalNumbers();
            //CalcDivision();
            //LetterPrice();
            LetterExpress();
        }

        // Opgave 6.1
        static void DiscountPrice()
        {
            Console.Write("Indtast beløb: ");
            double money = double.Parse(Console.ReadLine());

            double discount = 0;

            if (money > 1000)
                discount = money * 0.05;

            Console.WriteLine("Du får {0}kr i rabat!", discount);
            Console.ReadLine();
        }

        // Opgave 6.2
        static void RisingOrder1()
        {
            Console.WriteLine("Indtast to heltal og så ville jeg udskrive dem i stigende orden.");
            Console.Write("Indtast det første tal: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Indtast det andet tal: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number2);
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number1);
                Console.WriteLine(number2);
            }

            Console.ReadLine();
        }

        // Opgave 6.3
        static void RisingOrder2()
        {
            Console.WriteLine("Indtast tre heltal og så ville jeg udskrive dem i stigende orden.");
            Console.Write("Indtast det første tal: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Indtast det andet tal: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Indtast det tredje tal: ");
            int number3 = int.Parse(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                if (number2 > number3)
                {
                    Console.WriteLine(number3);
                    Console.WriteLine(number2);
                    Console.WriteLine(number1);
                }
                else
                {
                    Console.WriteLine(number2);
                    Console.WriteLine(number3);
                    Console.WriteLine(number1);
                }
            }
            else if (number2 > number1 && number2 > number3)
            {
                if (number1 > number3)
                {
                    Console.WriteLine(number3);
                    Console.WriteLine(number1);
                    Console.WriteLine(number2);
                }
                else
                {
                    Console.WriteLine(number1);
                    Console.WriteLine(number3);
                    Console.WriteLine(number2);
                }
            }
            else if (number3 > number1 && number3 > number2)
            {
                if (number2 > number1)
                {
                    Console.WriteLine(number1);
                    Console.WriteLine(number2);
                    Console.WriteLine(number3);
                }
                else
                {
                    Console.WriteLine(number2);
                    Console.WriteLine(number1);
                    Console.WriteLine(number3);
                }
            }

            Console.ReadLine();
        }

        // Opgave 6.4
        static void IdenticalNumbers()
        {
            Console.WriteLine("Skriv to heltal og så vil programmet se om de er ens.");
            Console.Write("Indtast det første tal: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast det andet tal: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
                Console.WriteLine("De to tal er ens");
            else
                Console.WriteLine("De to tal er ikke ens");

            Console.ReadLine();
        }

        // Opgave 6.5
        static void CalcDivision()
        {
            Console.WriteLine("Indtast to heltal og så vil programmet dividere de to heltal.");
            Console.Write("Indtast det første tal: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Indtast det andet tal: ");
            int b = int.Parse(Console.ReadLine());

            if (b != 0)
                Console.WriteLine(a / b);
            else
                Console.WriteLine("Det andet tal som du indtastede er 0 og kan derfor ikke beregnes.");

            Console.ReadLine();
        }

        // Opgave 6.6
        static void LetterPrice()
        {
            Console.WriteLine("Programmet udregner prisen på et brev.");
            Console.Write("Indtast vægt på brev i gram: ");
            int weight = int.Parse(Console.ReadLine());

            if (weight < 20)
                Console.WriteLine("Prisen er 5kr");
            else if (weight >= 20 && weight < 50)
                Console.WriteLine("Prisen er 7kr");
            else if (weight >= 50 && weight < 100)
                Console.WriteLine("Prisen er 10kr");
            else if (weight >= 100 && weight < 150)
                Console.WriteLine("Prisen er 15kr");
            else if (weight >= 150 && weight < 200)
                Console.WriteLine("Prisen er 20kr");
            else
                Console.WriteLine("Prisen er 30kr");

            Console.ReadLine();
        }

        // Opgave 6.7
        static void LetterExpress()
        {
            Console.WriteLine("Programmet udregner prisen på et brev og kan sendes som ekspres.");
            Console.Write("Indtast vægt på brev i gram: ");
            int weight = int.Parse(Console.ReadLine());

            Console.Write("Skal brevet sendet ekspres? (y/n): ");
            string express = Console.ReadLine();

            if (weight < 20)
            {
                if (express == "y")
                    Console.WriteLine("Prisen er 7,5kr");
                else
                    Console.WriteLine("Prisen er 5kr");
            }
            else if (weight >= 20 && weight < 50)
            {
                if (express == "y")
                    Console.WriteLine("Prisen er 10,5kr");
                else
                    Console.WriteLine("Prisen er 7kr");
            }
            else if (weight >= 50 && weight < 100)
            {
                if (express == "y")
                    Console.WriteLine("Prisen er 15kr");
                else
                    Console.WriteLine("Prisen er 10kr");
            }
            else if (weight >= 100 && weight < 150)
            {
                if (express == "y")
                    Console.WriteLine("Prisen er 22,5kr");
                else
                    Console.WriteLine("Prisen er 15kr");
            }   
            else if (weight >= 150 && weight < 200)
            {
                if (express == "y")
                    Console.WriteLine("Prisen er 30kr");
                else
                    Console.WriteLine("Prisen er 20kr");
            }
            else
            {
                if (express == "y")
                    Console.WriteLine("Prisen er 45kr");
                else
                    Console.WriteLine("Prisen er 30kr");
            }
                

            Console.ReadLine();
        }
    }
}

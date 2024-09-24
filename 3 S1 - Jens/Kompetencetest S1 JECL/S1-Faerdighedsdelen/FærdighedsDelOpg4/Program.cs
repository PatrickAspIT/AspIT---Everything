using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsDelOpg4
{
    internal class Program
    {
        /// <summary>
        /// The user inputs 2 hole numbers and then the program calculates.
        /// Addition, subtraction, multiplication, subtraction and modulus are saved in calcSign.
        /// The result is calculated in CalcNumbers and returned as a double.
        /// </summary>
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            string[] calcSign = new string[] {"+", "-", "*", "/", "%"};

            // Makes sure that the number that the user inputs, is a whole number.

            Console.Write("Indtast et heltal: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                firstNumber = number;
            }
            catch (Exception)
            {
                Console.WriteLine("Du indtastede ikke et heltal!");
                Console.WriteLine("Programmet afsluttes.");
                Console.ReadKey();
                return;
            }

            Console.Write("Indtast et mere heltal: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                secondNumber = number;
            }
            catch (Exception)
            {
                Console.WriteLine("Du indtastede ikke et heltal!");
                Console.WriteLine("Programmet afsluttes.");
                Console.ReadKey();
                return;
            }

            // Goes through each string in the array and writes to console and runs the method CalcNumbers
            foreach (string sign in calcSign)
            {
                Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {CalcNumbers(firstNumber, secondNumber, sign)}");
            }

            Console.ReadKey();
        }

        // Used to calculate the result of the numbers, with the given sign (calcSign)
        static double CalcNumbers(double firstNumber, double secondNumber, string calcSign)
        {
            switch (calcSign)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-": 
                    return firstNumber - secondNumber;
                case "*": 
                    return firstNumber * secondNumber;
                case "/": 
                    return firstNumber / secondNumber;
                case "%": 
                    return firstNumber % secondNumber;
                default:
                    return 0.123456789;
            }
        }
    }
}

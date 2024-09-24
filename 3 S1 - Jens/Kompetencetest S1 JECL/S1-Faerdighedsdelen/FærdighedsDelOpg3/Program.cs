using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsDelOpg3
{
    internal class Program
    {
        /// <summary>
        /// The user har to guess a number between 1 and 10.
        /// If the user guesses wrong, then the user guesses again, until they guess right.
        /// </summary>
        static void Main(string[] args)
        {
            bool continueLoop = true;
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            int guessNumber = 0;
            while (continueLoop)
            {
                Console.Write("Gæt et tilfældigt tal mellem 1 og 10: ");
                try
                {
                    guessNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Du angiv ikke et tal!");
                    Console.WriteLine("Tryk på en knap for at fortsætte.");
                    Console.ReadKey();
                }

                // The program checks the users guess
                if (guessNumber == randomNumber) 
                {
                    Console.WriteLine("Rigtigt - Tryk enter for at afslutte.");
                    continueLoop = false;
                    Console.ReadKey();
                }
                else if (guessNumber != randomNumber && guessNumber != 0)
                {
                    Console.WriteLine("Forkert - Prøv igen.");
                    Console.ReadKey();
                }
                Console.Clear();
            }

        }
    }
}

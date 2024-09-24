using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsDelOpg1
{
    internal class Program
    {
        /// <summary>
        /// The user has to assign a name and a lastname.
        /// Is is then outputted to the console.
        /// </summary>
        static void Main(string[] args)
        {

            Console.Write("Skriv Dit fornavn: ");
            string firstName = Console.ReadLine();

            Console.Write("Skriv dit efternavn: ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Du hedder {firstName} {lastName}");

            Console.ReadKey();

        }
    }
}

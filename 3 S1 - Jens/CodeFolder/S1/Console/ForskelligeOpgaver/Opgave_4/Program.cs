using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RepeatText();
            //WelcomeText();
            //RepeatNumber();
            //CalcArea();
            aWrite();
        }

        // Opgave 4.1
        static void RepeatText()
        {
            Console.Write("Indtast noget tekst: ");
            string input = Console.ReadLine();

            Console.WriteLine(input);
            Console.ReadLine();
        }

        // Opgave 4.2
        static void WelcomeText()
        {
            Console.Write("Indtast fornavn: ");
            string firstName = Console.ReadLine();

            Console.Write("Indtast efternavn: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Velkommen {0} {1}", firstName, lastName);
            Console.ReadLine();
        }

        // Opgave 4.3
        static void RepeatNumber()
        {
            Console.Write("Indtast et tal: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine(number);
            Console.ReadLine();
        }

        // Opgave 4.4
        static void CalcArea()
        {
            Console.Write("Indtast længden på firkanten: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast bredden på firkanten: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 * number2;

            Console.WriteLine("Arealet på firkaten er {0}", result);
            Console.ReadLine();
        }

        // Opgave 4.5
        static void aWrite()
        {
            Console.WriteLine("     AA          BBBBB       CCCCCC");
            Console.WriteLine("    A   A        B    BB    C");
            Console.WriteLine("   A     A       BBBBB      C");
            Console.WriteLine("  AAAAAAAAA      BBBBB      C");
            Console.WriteLine(" A         A     B    BB    C");
            Console.WriteLine("A           A    BBBBB       CCCCCC");

            // A B C

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Del 1

            // I C# er "string" en datatype, der bruges til at repræsentere en sekvens af tegn.
            // En "string" i C# er en reference type, hvilket betyder, at den er baseret på en objektreference
            // snarere end at være en værditype som "int" eller "float". Strenge i C# er uundgåeligt en vigtig
            // del af mange programmer, da de bruges til at håndtere tekst og karakterdata.
            // C# tilbyder også en række nyttige metoder og egenskaber til at arbejde med strenge,
            // såsom at finde længden af en streng, ændre tegn i en streng, opdele en streng i substrings, og meget mere.

            string fruit = "Pære";
            Console.WriteLine(fruit);
            Console.ReadLine();
            fruit = "Banan";
            Console.WriteLine(fruit);
            Console.ReadLine();


            // Del 2 

            // Part 1

            string firstName = "Patrick Sean";
            string lastName = "Lange-Nielsen";

            // Part 2

            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();

            // Part 3

            string interpolationName = $"My full name is: {firstName} {lastName}.";

            Console.WriteLine(interpolationName);
            Console.ReadLine();

            // Part 4

            string formatName = String.Format("My full name is: {0} {1}.", firstName, lastName);

            Console.WriteLine(formatName);
            Console.ReadLine();

            // Part 5 

            string opgaveTekst = "I C# er \"string\" en datatype, der bruges til at repræsentere en sekvens af tegn. " +
                "En \"string\" i C# er en reference type, hvilket betyder, at den er baseret på en objektreference " +
                "snarere end at være en værditype som \"int\" eller \"float\". Strenge i C# er uundgåeligt en vigtig " +
                "del af mange programmer, da de bruges til at håndtere tekst og karakterdata. " +
                "C# tilbyder også en række nyttige metoder og egenskaber til at arbejde med strenge, " +
                "såsom at finde længden af en streng, ændre tegn i en streng, opdele en streng i substrings, og meget mere.";

            // Part 6

            Console.WriteLine(opgaveTekst);
            Console.ReadLine();

            // Part 7

            opgaveTekst = opgaveTekst.ToUpper();
            Console.WriteLine(opgaveTekst);
            Console.ReadLine();

            // Part 8 

            opgaveTekst = opgaveTekst.ToLower();
            Console.WriteLine(opgaveTekst);
            Console.ReadLine();

            // Part 9

            string stringLength = opgaveTekst;
            stringLength = stringLength.Replace(" ", "");
            int result = stringLength.Length;
            Console.WriteLine(result);
            Console.ReadLine();

            // Part 10

            string temp = opgaveTekst;

            // Part 11

            temp = temp.Replace(" ", "¤");
            Console.WriteLine(temp);
            Console.ReadLine();

            // Part 12

            Console.WriteLine("First index number: {0}.", temp.IndexOf("¤"));
            Console.WriteLine("Last index number: {0}.", temp.LastIndexOf("¤"));
            Console.ReadLine();

            // Part 13

            result = opgaveTekst.Length;
            Console.WriteLine(result);
            Console.ReadLine();

            // Part 14

            Console.WriteLine("Part 14!!");

            string inputString = opgaveTekst;
            string searchSubstring = " at ";
            int firstIndex = inputString.IndexOf(searchSubstring);

            Console.WriteLine("First index number: {0}.", opgaveTekst.IndexOf(" at "));

            if (firstIndex != -1)
            {
                // Find the second occurrence starting from the position after the first occurrence
                int secondIndex = inputString.IndexOf(searchSubstring, firstIndex + 1);

                if (secondIndex != -1)
                {
                    Console.WriteLine($"The second occurrence of \"{searchSubstring}\" is at index {secondIndex}");
                }
            }

            // Part 15

            string[] seperateString = { " at " };
            string[] sentence = opgaveTekst.Split(seperateString, StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine(sentence[1]);
            Console.ReadLine();

        }
    }
}

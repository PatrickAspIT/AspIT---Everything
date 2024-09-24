using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcVersion1();
            //CalcVersion2();
            CalcVersion3();
        }

        // Opgave 5.1
        static void CalcVersion1()
        {
            Console.WriteLine("Velkomen til lommeregneren version 1.");
            Console.WriteLine("Jeg er en simpel lommeregner, som udelukkende kan lægge to tal sammen.");
            Console.WriteLine();

            Console.Write("Indtast et tal, efterfulgt af enter: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast endnu et tal, efterfulgt af enter: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 + number2;

            Console.WriteLine("Resultatet af de to tal lagt sammen er: {0}", result);
            Console.ReadLine();
        }

        // Opgave 5.2
        static void CalcVersion2()
        {
            Console.WriteLine("Velkomen til lommeregneren version 2.");
            Console.WriteLine("Jeg er en simpel lommeregner, kan plus, minus, gange og division.");
            Console.WriteLine();

            Console.Write("Indtast et tal, efterfulgt af enter: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast endnu et tal, efterfulgt af enter: ");
            int number2 = int.Parse(Console.ReadLine());

            int addition = number1 + number2;
            int subtraction = number1 - number2;
            int multiplication = number1 * number2;

            double div1 = number1;
            double div2 = number2;
            double division = div1 / div2;
            // Opgave 5.3
            int modulo = number1 % number2;

            Console.WriteLine("Resultatet af de to tal lagt sammen er: {0}", addition);
            Console.WriteLine("Resultatet af de to tal trukket fra hinanden er: {0}", subtraction);
            Console.WriteLine("Resultatet af de to tal ganget sammen er: {0}", multiplication);
            Console.WriteLine("Resultatet af de to tal divideret med hinanden er: {0}", division);
            Console.WriteLine("Resultatet af de to tal modulo med hinanden er: {0}", modulo);
            Console.ReadLine();
        }

        // Opgave 5.4
        static void CalcVersion3()
        {
            Console.WriteLine("Velkomen til lommeregneren version 3.");
            Console.WriteLine("Jeg er en simpel lommeregner, kan plus, minus, gange og division med kommatal(,).");
            Console.WriteLine();

            Console.Write("Indtast et tal, efterfulgt af enter: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Indtast endnu et tal, efterfulgt af enter: ");
            double number2 = double.Parse(Console.ReadLine());

            double addition = number1 + number2;
            double subtraction = number1 - number2;
            double multiplication = number1 * number2;
            double division = number1 / number2;
            double modulo = number1 % number2;

            Console.WriteLine("Resultatet af de to tal lagt sammen er: {0}", addition);
            Console.WriteLine("Resultatet af de to tal trukket fra hinanden er: {0}", subtraction);
            Console.WriteLine("Resultatet af de to tal ganget sammen er: {0}", multiplication);
            Console.WriteLine("Resultatet af de to tal divideret med hinanden er: {0}", division);
            Console.WriteLine("Resultatet af de to tal modulo med hinanden er: {0}", modulo);
            Console.ReadLine();
        }
    }
}

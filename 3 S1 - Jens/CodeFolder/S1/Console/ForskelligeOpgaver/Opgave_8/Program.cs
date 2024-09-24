using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //GuessX1();
            //GuessX2();
            //GuessX3();
            GuessX4();

        }

        // Opgave 8.1
        static void GuessX1()
        {
            // Guess: x = 3
            int a = 1;
            int b = 2;
            int c = 3;
            int x = 0;

            if (a == 1)
                x = 1;
            if (b == 1)
                x = 2;
            if (c == 3)
                x = 3;

            Console.WriteLine(x);
            Console.ReadLine();
        }

        // Opgave 8.2
        static void GuessX2()
        {
            // Guess: x = 3
            int a = 1;
            int b = 2;
            int c = 3;
            int x = 0;

            if (a == 2)
                x = 1;
            else if (b == 3)
                x = 2;
            else if (c == 3)
                x = 3;

            Console.WriteLine(x);
            Console.ReadLine();
        }

        // Opgave 8.3
        static void GuessX3()
        {
            // Guess: x = 0
            int a = 1;
            int b = 2;
            int c = 3;
            int x = 0;

            if (a == 2)
            {
                x = 1;
                if (b == 2)
                    x = 2;
            }
            else if (c == 2)
                x = 3;

            Console.WriteLine(x);
            Console.ReadLine();
        }

        // Opgave 8.4
        static void GuessX4()
        {
            // Guess: x = 2
            int a = 1;
            int b = 2;
            int c = 3;
            int x = 0;

            if (a + b == b)
                x = 1;
            else
            {
                if (b - a == a)
                    x = 2;
                if (c - b == b)
                    x = 3;
            }

            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}

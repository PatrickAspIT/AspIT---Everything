using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //FalseOrTrue1();
            FalseOrTrue2();

        }

        // Opgave 7.1
        static void FalseOrTrue1()
        {
            int a = 2;
            int b = 4;

            Console.WriteLine(a == b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a - b > 0);
            Console.WriteLine(a + b > 0);
            Console.WriteLine(a > 1 - b);

            Console.ReadLine();
        }

        // Opgave 7.2
        static void FalseOrTrue2()
        {
            // 1. true
            // 2. true
            // 3. false
            // 4. false
            // 5. false
            // 6. true
            // 7. true
            // 8. true
            // 9. false
            // 10. false ----- Den var true
            // 11. false

            int a = 2;
            int b = 4;

            Console.WriteLine(a == b || a > 0);
            Console.WriteLine(a + b > 0 && a > 0);
            Console.WriteLine(a == 5 && a + b > 0);
            Console.WriteLine((true || false) && a > b);
            Console.WriteLine(3 > 5 && true || a == b);
            Console.WriteLine(b > a && true || false || b > 4);
            Console.WriteLine(b < 4 && a < b || a + b > 4 && true);
            Console.WriteLine(true && true || false);
            Console.WriteLine(true && false && true);
            Console.WriteLine(true || false || false); // ---- 10.
            Console.WriteLine(false && false);

            Console.ReadLine();
        }
    }
}

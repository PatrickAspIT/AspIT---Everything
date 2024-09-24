using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsDelOpg2
{
    internal class Program
    {
        /// <summary>
        /// Table of 7 is written to console.
        /// Uses a for-loop that runs 10 times and each time tableNumber is multiplied with i.
        /// </summary>
        static void Main(string[] args)
        {
            int tableNumber = 7;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(tableNumber * i);
            }

            Console.ReadKey();
        }
    }
}

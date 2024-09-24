using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListNumbers();
            //InsertElement();
            RemoveElement();

        }

        // Opgave 14.1
        static void ListNumbers()
        {
            List<int> ages = new List<int>();
            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);

            List<string> names = new List<string>();
            names.Add("Jens");
            names.Add("Karl");
            names.Add("Johannes");
            names.Add("Anton");
            names.Add("Nicklas");

            // Opgave 14.2

            List<double> percentages = new List<double>() { 0.75, 0.23, 0.86, 0.17 };

            List<bool> areMarried = new List<bool> { true, false, false, true, true };

            // Opgave 14.3

            for (int i = 0; i < ages.Count; i++)
                Console.WriteLine(ages[i]);

            for (int i = 0; i < names.Count; i++)
                Console.WriteLine(names[i]);

            foreach (double percentage in percentages)
                Console.WriteLine(percentage);

            foreach (bool isMarried in areMarried)
                Console.WriteLine(isMarried);

            Console.ReadLine();
        }

        // Opgave 14.4
        static void InsertElement()
        {
            List<string> names = new List<string> { "Hans", "Kristian", "Jens", "Karsten", "Ib" };

            for (int i = 0; i < names.Count; i++)
                Console.WriteLine(names[i]);

            Console.ReadLine();

            names.Insert( 3, "Anders" );
            names.Insert( 2, "Lars" );
            // Hans, Kristian, Lars, Anders, Ib
            // ----- De overskriver ikke tidligere navne, de laver nye!

            for (int i = 0; i < names.Count; i++)
                Console.WriteLine(names[i]);


            Console.ReadLine();
        }

        // Opgave 14.5
        static void RemoveElement()
        {
            List<int> age = new List<int> { 13, 14, 13, 15, 13, 14, 14, 15 };

            for (int i = 0; i < age.Count; i++)
                Console.WriteLine(age[i]);

            Console.ReadLine();
            // ---------------------
            age.Remove(13);
            age.Remove(15);

            for (int i = 0; i < age.Count; i++)
                Console.WriteLine(age[i]);

            Console.ReadLine();
            // ---------------------
            age.RemoveAt(3);

            for (int i = 0; i < age.Count; i++)
                Console.WriteLine(age[i]);

            Console.ReadLine();
            // ---------------------


            Console.ReadLine();
        }
    }
}

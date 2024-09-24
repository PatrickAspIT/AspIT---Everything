using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestStreamWriter();
            RandomDiceWriter();
            //RandomGenerator(20, "C:\\Users\\39323\\Desktop\\MyFile.txt");
            SortList();

        }

        // Opgave 20.1
        static void TestStreamWriter()
        {          
            using (StreamWriter writer = new StreamWriter("C:\\Users\\39323\\Desktop\\MyFile.txt"))
            {
                writer.Write("Dette bliver skrevet på en linje");
                writer.Write(".. og det her fortsætter på samme linje");

                writer.WriteLine(".. det her står på samme linje, men afsluttes med nyt linjeskift");
                writer.WriteLine("Forskellen på Write og WriteLine er altså om den bliver afsluttet med nyt linjeskift eller ej");
                writer.WriteLine("1");
                writer.WriteLine("2");
            }

            Console.ReadLine();
        }

        // Opgave 20.2
        static void RandomDiceWriter()
        {
            Random rnd = new Random();
            int randomNumber = 0;
            using (StreamWriter writer = new StreamWriter("C:\\Users\\39323\\Desktop\\MyFile.txt"))
            {
                for (int i = 0; i < 100; i++)
                {
                    randomNumber = rnd.Next(1, 7);
                    writer.WriteLine(randomNumber);
                }
            }
            Console.ReadLine();
        }

        // Opgave 20.2 Ekstra
        static void RandomGenerator(int loopNumber, string url)
        {
            Random rnd = new Random();
            int randomNumber = 0;
            using (StreamWriter writer = new StreamWriter(url))
            {
                for (int i = 0; i < loopNumber; i++)
                {
                    randomNumber = rnd.Next(1, 7);
                    writer.WriteLine(randomNumber);
                }
            }
            Console.ReadLine();
        }

        // Oopgave 20.3
        static void SortList()
        {
            List<int> readFile = new List<int>();
            StreamReader streamReader = new StreamReader("C:\\Users\\39323\\Desktop\\MyFile.txt");
            string line = "";

            try
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    readFile.Add(int.Parse(line));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            streamReader.Close();

            readFile.Sort();

            using (StreamWriter writer = new StreamWriter("C:\\Users\\39323\\Desktop\\Sorted-File.txt"))
            {
                foreach (int number in readFile)
                {
                    writer.WriteLine(number);
                }
            }

            // Ekstra
            int oneNumber = 0;
            int twoNumber = 0;
            int threeNumber = 0;
            int fourNumber = 0;
            int fiveNumber = 0;
            int sixNumber = 0;

            foreach (int number in readFile)
            {
                if (number == 1)
                    oneNumber++;
                else if (number == 2)
                    twoNumber++;
                else if (number == 3)
                    threeNumber++;
                else if (number == 4)
                    fourNumber++;
                else if (number == 5)
                    fiveNumber++;
                else if (number == 6)
                    sixNumber++;
            }

            Console.WriteLine("Der var: ");
            Console.WriteLine("1-taller: {0}", oneNumber);
            Console.WriteLine("2-taller: {0}", twoNumber);
            Console.WriteLine("3-taller: {0}", threeNumber);
            Console.WriteLine("4-taller: {0}", fourNumber);
            Console.WriteLine("5-taller: {0}", fiveNumber);
            Console.WriteLine("6-taller: {0}", sixNumber);


            Console.ReadLine();
        }
    }
}

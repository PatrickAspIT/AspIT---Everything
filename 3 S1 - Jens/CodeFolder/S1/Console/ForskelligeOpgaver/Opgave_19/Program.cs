using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LearningStreamReader(); 

            //-----------------------------

            // Opgave 19.1 Ekstra Ekstra
            //string url = "C:\\CodeFolder\\S1\\Console\\ForskelligeOpgaver\\Opgave_19\\Values.txt";

            //List<int> test = GetNumbersFromFile(url);

            //int total = test.Sum();

            //Console.WriteLine("Summen af alle tal: {0} - Gennemsnit af alle tal: {1}.", total, total / test.Count);
            //Console.ReadLine();

            //-----------------------------

            //Boxes();

            //-----------------------------

            // Opgave 19.2 Ekstra Ekstra
            //string url = "C:\\CodeFolder\\S1\\Console\\ForskelligeOpgaver\\Opgave_19\\Boxes.txt";
            //List<Box> box = GetBoxesFromFile(url);

            //List<int> volume = new List<int>();
            //List<int> surface = new List<int>();

            //foreach (Box boxes in box)
            //{
            //    volume.Add(boxes.CalculateVolume());
            //    surface.Add(boxes.CalculateSurface());
            //    boxes.PrintInfo();
            //    Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("Mindste volume: {0}", volume.Min());
            //Console.WriteLine("Højeste volume: {0}", volume.Max());
            //Console.WriteLine("Mindste overfladeareal: {0}", surface.Min());
            //Console.WriteLine("Højeste overfladeareal: {0}", surface.Max());

            //Console.ReadLine();

            //-----------------------------

            People();

            //-----------------------------
        }

        // Opgave 19.1
        static void LearningStreamReader()
        {
            StreamReader streamReader = new StreamReader("C:\\CodeFolder\\S1\\Console\\ForskelligeOpgaver\\Opgave_19\\Values.txt");

            int sum = 0;
            int counter = 0;
            string line = "";

            List<int> sumList = new List<int>();

            try
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    sum += int.Parse(line);
                    counter++;
                    sumList.Add(int.Parse(line));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            streamReader.Close();
            int total = sumList.Sum();
            

            Console.WriteLine("Summen af alle tal: {0} - Gennemsnit af alle tal: {1}.", sum, sum / counter);
            Console.WriteLine("Summen af alle tal: {0} - Gennemsnit af alle tal: {1}.", total, total / sumList.Count);
            Console.ReadLine();
        }

        // Opgave 19.1 Ekstra Ekstra
        static List<int> GetNumbersFromFile(string url)
        {
            StreamReader streamReader = new StreamReader(url);

            string line = "";

            List<int> sumList = new List<int>();

            try
            {
                while ((line = streamReader.ReadLine()) != null)
                    sumList.Add(int.Parse(line));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            streamReader.Close();

            return sumList;
        }

        // Opgave 19.2
        static void Boxes()
        {
            StreamReader streamReader = new StreamReader("C:\\CodeFolder\\S1\\Console\\ForskelligeOpgaver\\Opgave_19\\Boxes.txt");
            string line = "";
            List<Box> holdNumber = new List<Box>();
            string[] newArray = new string[3];
            int[] arrayNumbers = new int[3];
            int foreachLoop = 0;
            int Height = 0;
            int Length = 0;
            int Width = 0;

            try
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    newArray = line.Split(',');
                    foreach (string value in newArray)
                    {
                        arrayNumbers[foreachLoop] = int.Parse(value);
                        foreachLoop++;
                    }
                    foreachLoop = 0;
                    Height = arrayNumbers[0];
                    Length = arrayNumbers[1];
                    Width = arrayNumbers[2];
                    Box newBoxes = new Box( Height, Length, Width );
                    holdNumber.Add(newBoxes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            streamReader.Close();

            List<int> volume = new List<int>();
            List<int> surface = new List<int>();

            foreach  (Box boxes in holdNumber)
            {
                volume.Add(boxes.CalculateVolume());
                surface.Add(boxes.CalculateSurface());
                boxes.PrintInfo();
                Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Mindste volume: {0}", volume.Min());
            Console.WriteLine("Højeste volume: {0}", volume.Max());
            Console.WriteLine("Mindste overfladeareal: {0}", surface.Min());
            Console.WriteLine("Højeste overfladeareal: {0}", surface.Max());

            Console.ReadLine();
        }

        // Opgave 19.2 Ekstra Ekstra
        static List<Box> GetBoxesFromFile(string url)
        {
            StreamReader streamReader = new StreamReader(url);
            string line = "";
            List<Box> holdNumber = new List<Box>();
            string[] newArray = new string[3];
            int[] arrayNumbers = new int[3];
            int foreachLoop = 0;
            int Height = 0;
            int Length = 0;
            int Width = 0;

            try
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    newArray = line.Split(',');
                    foreach (string value in newArray)
                    {
                        arrayNumbers[foreachLoop] = int.Parse(value);
                        foreachLoop++;
                    }
                    foreachLoop = 0;
                    Height = arrayNumbers[0];
                    Length = arrayNumbers[1];
                    Width = arrayNumbers[2];
                    Box newBoxes = new Box(Height, Length, Width);
                    holdNumber.Add(newBoxes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            streamReader.Close();

            return holdNumber;
        }

        // Opgave 19.3
        static void People()
        {
            StreamReader streamReader = new StreamReader("C:\\CodeFolder\\S1\\Console\\ForskelligeOpgaver\\Opgave_19\\Person.txt");
            string line = "";
            List<Person> holdNumber = new List<Person>();
            string[] newArray = new string[3];
            string[] arrayNumbers = new string[3];
            int foreachLoop = 0;
            string firstName = "";
            string secondName = "";
            int age = 0;

            try
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    newArray = line.Split(',');
                    foreach (string value in newArray)
                    {
                        arrayNumbers[foreachLoop] = value;
                        foreachLoop++;
                    }
                    foreachLoop = 0;
                    firstName = arrayNumbers[0].ToString();
                    secondName = arrayNumbers[1].ToString();
                    age = int.Parse(arrayNumbers[2]);
                    Person allPeople = new Person(firstName, secondName, age);
                    holdNumber.Add(allPeople);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            streamReader.Close();
            
            List<string> listFirstName = new List<string>();
            List<string> listSecondName = new List<string>();
            List<int> listAge = new List<int>();
            List<string> listFullName = new List<string>();

            foreach (Person people in holdNumber)
            {
                listFirstName.Add(people.FirstName);
                listSecondName.Add(people.SecondName);
                listAge.Add(people.Age);
                listFullName.Add(people.FirstName + people.SecondName);
                //Console.ReadLine();
            }

            Console.WriteLine();
            //Console.WriteLine("Ældst: {0}", listAge.Max());
            //Console.WriteLine("Yngst: {0}", listAge.Min());
            //Console.WriteLine("Længste fornavn: {0}", listFirstName.OrderByDescending(x => x.Length).First());
            //Console.WriteLine("Korteste fornavn: {0}", listFirstName.OrderBy(c => c.Length).FirstOrDefault());
            //Console.WriteLine("Længeste navn: {0}", listFullName.OrderByDescending(x => x.Length).First());
            //Console.WriteLine("Korteste navn: {0}", listFullName.OrderBy(c => c.Length).FirstOrDefault());


            // Opgave 19.3 Ekstra
            FindOldestPerson(listAge);
            FindYoungestPerson(listAge);
            FindLongestFirstName(listFirstName);
            FindShortestFirstName(listFirstName);
            FindLongestName(listFullName);
            FindShortestName(listFullName);


            Console.ReadLine();
        }

        // Opgave 19.3 Ekstra
        static void FindOldestPerson(List<int> age)
        {
            Console.WriteLine("Ældst: {0}", age.Max());
        }

        static void FindYoungestPerson(List<int> age)
        {
            Console.WriteLine("Yngst: {0}", age.Min());
        }

        static void FindLongestFirstName(List<string> firstName)
        {
            Console.WriteLine("Længste fornavn: {0}", firstName.OrderByDescending(x => x.Length).First());
        }

        static void FindShortestFirstName(List<string> firstName)
        {
            Console.WriteLine("Korteste fornavn: {0}", firstName.OrderBy(c => c.Length).FirstOrDefault());
        }

        static void FindLongestName(List<string> fullName)
        {
            Console.WriteLine("Længeste navn: {0}", fullName.OrderByDescending(x => x.Length).First());
        }

        static void FindShortestName(List<string> fullName)
        {
            Console.WriteLine("Korteste navn: {0}", fullName.OrderBy(c => c.Length).FirstOrDefault());
        }
    }
}

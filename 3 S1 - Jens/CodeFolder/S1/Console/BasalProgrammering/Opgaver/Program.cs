using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Opgave 6.3 - While loop
            ///
            //while (true)
            //{
            //    //Hello();
            //    //Trylleri();
            //    //NiceWriting();
            //    //Digt();
            //    //CountUp();
            //    //TaxaSelskab();
            //    //SumNumber();
            //    //NameAndHobby();
            //    //CompareSize();
            //    //BMI();
            //    //CantLie();

            //    Console.ReadLine();
            //}

            // Opgave 6.5
            int value = 0;

            do
            {
                Console.WriteLine("What program would you like to run?");
                Console.WriteLine("Remember to write a number from 0 - 99.");
                Console.WriteLine("You can see the command numbers by pressing 0.");
                value = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (value == 0)
                {
                    Console.WriteLine("Commands and the corresponding numbers:");
                    Console.WriteLine("");
                    Console.WriteLine("0 - Command numbers (here)");
                    Console.WriteLine("1 - Hello()");
                    Console.WriteLine("2 - Trylleri()");
                    Console.WriteLine("3 - NiceWriting()");
                    Console.WriteLine("4 - Digt()");
                    Console.WriteLine("5 - CountUp()");
                    Console.WriteLine("6 - TaxaSelskab()");
                    Console.WriteLine("7 - SumNumber()");
                    Console.WriteLine("8 - NameAndHobby()");
                    Console.WriteLine("9 - CompareSize()");
                    Console.WriteLine("10 - BMI()");
                    Console.WriteLine("11 - CantLie()");
                    Console.WriteLine("12 - RepeatSentence()");
                    Console.WriteLine("13 - Birthday()");
                    Console.WriteLine("14 - Division()");
                    Console.WriteLine("15 - NameIndex()");
                    Console.WriteLine("16 - Game500()");
                    Console.WriteLine("17 - Bowling()");
                    Console.WriteLine("18 - NewBMI()");
                    Console.WriteLine("19 - TestRest()");
                    Console.WriteLine("");
                    Console.WriteLine("99 - Stop program...");
                }
                else if (value == 1)
                    HelloMan();
                else if (value == 2)
                    Trylleri();
                else if (value == 3)
                    NiceWriting();
                else if (value == 4)
                    Digt();
                else if (value == 5)
                    CountUp();
                else if (value == 6)
                    TaxaSelskab();
                else if (value == 7)
                    SumNumber();
                else if (value == 8)
                    NameAndHobby();
                else if (value == 9)
                    CompareSize();
                else if (value == 10)
                    BMI();
                else if (value == 11)
                    CantLie();
                else if (value == 12)
                    RepeatSentence();
                else if (value == 13)
                    Birthday();
                else if (value == 14)
                    Division();
                else if (value == 15)
                    NameIndex();
                else if (value == 16)
                    Game500();
                else if (value == 17)
                    Bowling();
                else if (value == 18)
                    NewBMI();
                else if (value == 19)
                    TestRest();
                else if (value == 99)
                    Console.WriteLine("Du har lukket programmet...");

                Console.ReadLine();
                Console.Clear();
            } while (value != 99);
        }

        //Opgave 2
        static void Hello(string name, string praise)
        {
            Console.WriteLine("Hello world");
            //Opgave 2.3
            Console.WriteLine("Simsalabim");

            // Opgave 9.2

            Console.WriteLine("Hej {0}, dejlig(t) {1}.", name, praise);
        }

        // Opgave 2.4
        static void Trylleri()
        {
            Console.WriteLine("hokus pokus");
        }

        // Opgave 3.2
        static void NiceWriting()
        {
            Console.Write("Dig og mig ");
            Console.Write("og vi ");
            Console.Write("to sejled ");
            Console.WriteLine("i en træsko");
            Console.WriteLine("Da vi kom til Langeland var vor træsko fuld af vand");
        }

        // Opgave 3.4
        static void Digt()
        {
            int count = 0;

            Console.Write("Indtast naveord: ");
            string navneord1 = Console.ReadLine();
            if (navneord1 == "succes")
                count++;

            Console.Write("Indtast udsagnsord i nutid: ");
            string udsagnsordNutid = Console.ReadLine();
            if (udsagnsordNutid == "hører")
                count++;

            Console.Write("Indtast tillægsord i flertal (f.eks. smukke): ");
            string tillægsordFlertal = Console.ReadLine();
            if (tillægsordFlertal == "fede")
                count++;

            Console.Write("Indtast navneord: ");
            string navneord2 = Console.ReadLine();
            Console.WriteLine();

            if (navneord2 == "musik")
                count++;

            if (count == 4)
            {
                Console.WriteLine("Masser af succes");
                Console.WriteLine("Og det der hører til");
                Console.WriteLine("Masser af fede spotlights");
                Console.WriteLine("Privatliv og musik");
            }
            else
            {
                Console.WriteLine("Noget andet");
            }
        }

        // Opgave 4.4.3
        static void CountUp()
        {
            Console.Write("Indtast et tal: ");
            int writtenNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Variablen er nu øget med 16 og har fået værdien {0}", writtenNumber + 16);
        }

        // Opgave 4.4.4
        static void TaxaSelskab()
        {
            // Virker kun for hverdagskørsel fra kl. 04 til kl. 20
            Console.WriteLine(">>>Velkommen til taxaberegner<<<");

            Console.Write("Indtast antal kilometer: ");
            int numberKilomiters = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pris for taxatur: {0}", 29 + (numberKilomiters*9));
        }

        // Opgave 4.5.3
        static void SumNumber()
        {
            Console.Write("Indtast tal: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast tal: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Summen af {0} og {1} er {2}", value1, value2, value1 + value2);
        }

        // Opgave 4.6
        static void NameAndHobby()
        {
            int year = DateTime.Now.Year;

            Console.Write("Indtast fornavn: ");
            string firstName = Console.ReadLine();

            Console.Write("Indtast alder: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast hobby: ");
            string hobby = Console.ReadLine();

            Console.Write("Indtast længde af hobby i år: ");
            int hobbyTime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hej {0}, din hobby er {1}. Du begyndte at dyrke {2} i {3} i en alder af {4} år.", firstName, hobby, hobby, year - hobbyTime, age - hobbyTime);
        }

        // Opgave 5.5
        static void CompareSize()
        {
            Console.Write("Indtast skostørrelse: ");
            int shoeSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (shoeSize > 45)
                Console.WriteLine("Store plader");
            else if (shoeSize <= 45 && shoeSize >= 38)
                Console.WriteLine("Gennemsnitlige fødder");
            else
                Console.WriteLine("Små fødder");
        }

        // Opgave 5.7
        static void BMI()
        {
            Console.Write("Indtast din højde i meter: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast din vægt i kilo: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast køn M/K: ");
            char character = Convert.ToChar(Console.ReadLine());
            string gender;

            if (character == 'M' || character == 'm')
                gender = "mand";
            else
                gender = "kvinde";

            double BMI = weight / (height*height);
            Console.WriteLine("BMI: {0}", BMI);

            if (BMI < 18.5)
                Console.WriteLine("Undervægtig {0}", gender);
            else if (BMI >= 18.5 && BMI <= 24.9)
                Console.WriteLine("Normalvægtig {0}", gender);
            else if (BMI >= 25 && BMI <= 29.9)
                Console.WriteLine("Overvægtig {0}", gender);
            else
                Console.WriteLine("Stærk overvægtig {0}", gender);
        }

        // Opgave 6.2
        static void CantLie()
        {
            int count = 0;

            while (count != 6)
            {
                count++;
                Console.WriteLine("Jeg må ikke lyve");
            }
        }

        // Opgave 6.3 er i main - En while løkke

        // Opgave 6.5 er i main - En do-while løkke

        // Opgave 6.7
        static void RepeatSentence()
        {
            Console.Write("Hvilken sætning: ");
            string sentence = Console.ReadLine();

            Console.Write("Hvor mange gentagelser: ");
            int times = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(sentence);
            }
        }

        // Opgave 6.8
        static void Birthday()
        {
            Console.Write("Indtast alder: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast køn M/K: ");
            char character = Convert.ToChar(Console.ReadLine());
            string gender = "det";

            if (character == 'M' || character == 'm')
                gender = "han";
            else if (character == 'K' || character == 'k')
                gender = "hun";

            if (age == 1)
                Console.WriteLine(char.ToUpper(gender[0]) + gender.Substring(1) + " blev 1 år, HURAAAA ...");
            else
            {
                for (int i = 0; i < age; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(char.ToUpper(gender[0]) + gender.Substring(1) + " blev {0} år, hurra,", i + 1);
                    }
                    else if (i != 0 && i != age - 1)
                        Console.WriteLine("og {0} blev {1} år, hurra,", gender, i + 1);
                    else if (i == age - 1)
                        Console.WriteLine("og {0} blev {1} år, HURAAAA ...", gender, i + 1);
                }
            }
        }

        // Opgave 6.9
        static void Division()
        {
            Console.Write("Indtast et tal som skal divideres: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast det andet tal som skal divideres: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int calc = number1;
            while (calc - number2 >= 0)
            {
                i++;
                calc -= number2;
            }

            Console.WriteLine("{0} diveres med {1} = {2}", number1, number2, i);
        }

        // Opgave 7.4
        static void NameIndex()
        {
            string[] names = { "James", "Johannes", "Tim", "Jessica", "Treya", "Susan"};
            int indexNumber = 0;

            do
            {
                Console.WriteLine("What name would you like to print?");
                Console.WriteLine("Remember to write a number from 0 - 5.");
                Console.WriteLine("You can close the program by typing 99.");
                indexNumber = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (indexNumber < 6 && indexNumber >= 0)
                {
                    Console.WriteLine(names[indexNumber]);
                    Console.ReadLine();
                    Console.Clear();
                }

                if (indexNumber == 99)
                    Console.WriteLine("Du har lukket programmet...");

            } while ( indexNumber != 99);
        }

        // Opgave 8.1
        static void Game500()
        {
            Console.Write("Indtast hvor mange spillere i er: ");
            int amountPlayers = Convert.ToInt32(Console.ReadLine());

            string[] playerNames = new string[amountPlayers];

            for (int i = 0; i < playerNames.Length; i++)
            {
                Console.Write("Giv navn til spiller {0}: ", i + 1);
                playerNames[i] = Console.ReadLine();
            }
        }

        // Opgave 8.3 /// 8.4 - Ekstraopga som jeg springer over /// 8.6 
        static void Bowling()
        {
            Console.Write("Indtast antal spillere i bowling: ");
            int amountPlayers = Convert.ToInt32(Console.ReadLine());

            string[] playerName = new string[amountPlayers];
            int[] playerScore = new int[amountPlayers];
            int highestScore = 0;
            int lowestScore = Int32.MaxValue;
            int highestScorePlayer = 0;
            int lowestScorePlayer = 0;
            string longestName = "";
            string shortestName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            for (int i = 0; i < playerName.Length; i++)
            {
                Console.Write("Indtast navn for spiller {0}: ", i + 1);
                playerName[i] = Console.ReadLine();

                if (longestName.Length < playerName[i].Length)
                    longestName = playerName[i];

                if (shortestName.Length > playerName[i].Length)
                    shortestName = playerName[i];

                Console.Write("Indtast point for spiller {0}: ", i + 1);
                playerScore[i] = Convert.ToInt32(Console.ReadLine());

                if (highestScore < playerScore[i])
                {
                    highestScore = playerScore[i];
                    highestScorePlayer = i + 1;
                }
                    

                if (lowestScore > playerScore[i])
                {
                    lowestScore = playerScore[i];
                    lowestScorePlayer = i + 1;
                }
            }

            Console.WriteLine("Spiller {0} har de fleste points som er {1} med en score på {2}.", highestScorePlayer, playerName[highestScorePlayer], highestScore);
            Console.WriteLine("Spiller {0} har de færreste points som er {1} med en score på {2}.", lowestScorePlayer, playerName[lowestScorePlayer], lowestScore);
            Console.WriteLine("Det navn med fleste karakterer er: {0}.", longestName);
            Console.WriteLine("Det navn med færreste karakterer er: {0}", shortestName);

            //Opgave 8.6

            //foreach (string elem in playerName)
            //{
            //    Console.WriteLine(elem);
            //}

            // En foreach kan kune køre igennem 1 array, ikke 2.
        }

        // Opgave 9.2 + i opgave 2
        static void HelloMan()
        {
            Console.Write("Indtast dit navn: ");
            string name = Console.ReadLine();

            Console.Write("Hvad vil du gerne have ros for (ét ord)? ");
            string praise = Console.ReadLine();

            Hello(name, praise);
        }

        // Opgave 9.3 + 9.4

        static void NewBMI()
        {
            Console.Write("Indtast din højde i meter: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast din vægt i kilo: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast køn M/K: ");
            char character = Convert.ToChar(Console.ReadLine());
            string gender;

            if (character == 'M' || character == 'm')
                gender = "mand";
            else
                gender = "kvinde";

            double BMI = CalcBMI(weight, height);

            PrintBMI(BMI, gender);
        }

        static void PrintBMI(double BMI, string gender)
        {
            if (BMI < 18.5)
                Console.WriteLine("Undervægtig {0}", gender);
            else if (BMI >= 18.5 && BMI <= 24.9)
                Console.WriteLine("Normalvægtig {0}", gender);
            else if (BMI >= 25 && BMI <= 29.9)
                Console.WriteLine("Overvægtig {0}", gender);
            else
                Console.WriteLine("Stærk overvægtig {0}", gender);
        }

        // Opgave 9.6
        static double CalcBMI(int weight, double height)
        {
            double BMI = weight / (height * height);
            Console.WriteLine("BMI: {0}", BMI);

            return BMI;
        }

        // Opgave 9.7
        static int Rest(int number1, int number2)
        {
            int i = 0;
            int calc = number1;
            while (calc - number2 >= 0)
            {
                i++;
                calc -= number2;
            }

            Console.WriteLine("{0} diveres med {1} = {2}", number1, number2, i);
            return calc;
        }

        static void TestRest()
        {
            Console.Write("Indtast et tal som skal divideres: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast det andet tal som skal divideres: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int rest = Rest(number1, number2);

            Console.WriteLine("Resterende tilbage: {0}", rest);
        }

    }
}

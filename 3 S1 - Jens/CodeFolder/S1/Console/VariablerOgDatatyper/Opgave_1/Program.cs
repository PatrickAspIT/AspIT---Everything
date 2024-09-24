using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string myName = "Patrick Sean Lange-Nielsen";
            string myAdress = "Ringdams Kobbel 153";
            string mySchoolMail = "39323@edu.campusvejle.dk";
            string myProjectFolder = "C:\\CodeFolder\\S1\\Console";
            int myAge = 24;
            int myBirthYear = 1999;
            int middleTemp2019 = 1; // Tirsdag d. 19. marts 2019 - 09:00 --- dmi.dk/vejrarkiv/
            double representPromille = 0.6;
            int percentVariable1 = 100; // 100%
            int percentVariable2 = 125; // 125%
            int percentVariable3 = 25; //25%
            double epsilonValue = double.Epsilon;

            //---------------------------------------- WRITING THE VARIABLE TO CONSOLE BELOW

            Console.WriteLine("{0}, {1}, {2}, \n {3}, \n {4}, {5}, \n {6}°C, \n {7}, \n {8}%, {9}%, {10}%, \n {11}.",
                myName, myAdress, mySchoolMail,
                myProjectFolder,
                myAge, myBirthYear,
                middleTemp2019,
                representPromille,
                percentVariable1, percentVariable2, percentVariable3,
                epsilonValue);
            Console.ReadLine();


        }
    }
}

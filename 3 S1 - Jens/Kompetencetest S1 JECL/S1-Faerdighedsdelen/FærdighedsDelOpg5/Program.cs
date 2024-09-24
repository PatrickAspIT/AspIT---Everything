using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FærdighedsDelOpg5
{
    internal class Program
    {
        /// <summary>
        /// The user is presented with a menu that has several options.
        /// See content in the textdocument, write something that gets added to the textdocument and finish the program.
        /// </summary>
        static void Main(string[] args)
        {
            string filePath = "C:\\CodeFolder\\S1\\Opgave5.txt";

            // Checks if the file dosent exist, if true, create a blank textdocument.
            if (!File.Exists(filePath))
            {
                // Create a new blank textdocument.
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(filePath))
                    {

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"En fejl skete ved skabelse af textdokument: {ex.Message}");
                }
            }

            // What program to run based on the users input.
            // Display content in textdocument, add content to textdocument or close program.
            bool continueLoop = true;
            while (continueLoop)
            {
                char menuChar = DisplayMenu(filePath);
                if (menuChar == 'a' || menuChar == 'A')
                {
                    DisplayTextFileContent(filePath);
                }
                else if (menuChar == 'b' || menuChar == 'B')
                {
                    AddContentToTextFile(filePath);
                }
                else
                {
                    continueLoop = false;
                    Console.WriteLine("Du har afsluttet programmet.");
                    Console.ReadKey();
                }
            }
        }

        // Menu where the user can choose what part of the program they want to run.
        static char DisplayMenu(string filePath)
        {
            char menuChar = 'k';
            bool continueLoop = true;
            while (continueLoop)
            {
                Console.WriteLine("A: Se indhold i textfilen.");
                Console.WriteLine("B: Skriv noget som skal gemmes/tilføjes til textfilen.");
                Console.WriteLine("C: Afslut programmet.");
                Console.Write("Indtast bogstav for den metode som du ville køre: ");

                try
                {
                    menuChar = char.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Du indtastede ikke et bogstav!");
                    Console.WriteLine("Tryk på en knap for at prøve igen.");
                    Console.ReadKey();  
                }
                
                // Checks if the user has inputted an acceptable char value.
                if (menuChar == 'a' || menuChar == 'A' || menuChar == 'b' || menuChar == 'B' || menuChar == 'c' || menuChar == 'C')
                {
                    continueLoop = false;
                }
                Console.Clear();
            }

            return menuChar;
        }

        // Prints content of textdocument to console.
        static void DisplayTextFileContent(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                // Vis hver linje i consollen
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"En fejl skete ved læselse af textdokument til consollen: {ex.Message}");
            }

            Console.ReadKey();
            Console.Clear();
        }

        // The user writes text, that gets added to the textdocument.
        static void AddContentToTextFile(string filePath)
        {
            Console.WriteLine("Indtast tekst som du vil tilføje til dit tekstdokument.");
            string textToAdd = Console.ReadLine();

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    // Tilføjer tekst til tekstdokument
                    sw.WriteLine(textToAdd);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"En fejl skete ved indsættelse af tekst i tekstdokumentet: {ex.Message}");
            }
            Console.Clear();
        }
    }
}

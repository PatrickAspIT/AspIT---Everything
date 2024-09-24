using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    internal class Program
    {
        /// <summary>
        /// The user is presented with a menu that has several options.
        /// Save a new film that the user inputs down in the textdocument, print a list to console over all films in the textdocument,
        /// Search for at films titel through the users input and finish the program.
        /// </summary>
        static void Main(string[] args)
        {
            string filePath = "C:\\CodeFolder\\S1\\MovieTextFile.txt";

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

                // Adds the 2 start movies to the textdocument.
                StartMovies(filePath);
            }

            // Menu where the user can choose what part of the program they want to run.
            bool continueLoop = true;
            while (continueLoop)
            {
                Console.WriteLine("A: Gem en ny film hvor brugeren indtaster dataen.");
                Console.WriteLine("B: Print en liste over alle film i tekstdokumentet.");
                Console.WriteLine("C: Søg på en films titel.");
                Console.WriteLine("D: Afslut programmet.");
                Console.Write("Indtast bogstav for den metode som du ville køre: ");
                string userInput = Console.ReadLine();

                Console.Clear();

                switch (userInput)
                {
                    case "a":
                    case "A":
                        SaveNewMovie(filePath);
                        break;
                    case "b":
                    case "B":
                        ListOfMovies(filePath);
                        break;
                    case "c": 
                    case "C":
                        SearchTitle(filePath);
                        break;
                    case "d": 
                    case "D":
                        continueLoop = false;
                        Console.WriteLine("Du har afsluttet programmet.");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }

        // Writes text to the textdocument. Gets called when a movie is added to the textdocument.
        static void AddTextToDocument(string filePath, string title, int publication, string instructor, string company)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath, true))
                {
                    // Adds text to the textdoucment.
                    streamWriter.WriteLine(title + " - " + publication + " - " + instructor + " - " + company);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"En fejl skete ved indsættelse af tekst i tekstdokumentet: {ex.Message}");
            }
        }

        // Adds the 2 start movies to the textdocument.
        static void StartMovies(string filePath)
        {
            // Star Trek Beyond.
            AddTextToDocument(filePath, "Star Trek Beyond", 2016, "Justin Lin", "Paramount Pictures");

            // Star Wars Rise of Skywalker.
            AddTextToDocument(filePath, "Star Wars Rise of Skywalker", 2019, "J. J. Abrams", "Walt Disney Studios");
        }

        // Lets the user add a movie to the textdocument.
        static void SaveNewMovie(string filePath)
        {
            string title = "";
            int publication = 2000;
            string instructor = "";
            string company = "";

            Console.WriteLine("Du har valgt at tilføje en ny film til textfilen.");
            Console.Write("Indtast titel: ");
            title = Console.ReadLine();
            Console.Write("Indtast udgivelsesår: ");
            try
            {
                publication = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Du indtastede ikke et tal!");
                Console.WriteLine("Udgivelsesåret er sat til 2000.");
                Console.WriteLine("Tryk på en knap for at fortsætte.");
                Console.ReadKey();
                Console.Clear();
            }
            Console.Write("Indtast instruktør: ");
            instructor = Console.ReadLine();
            Console.Write("Indtast filmselskab: ");
            company = Console.ReadLine();

            // Runs method that adds the movie to the textdocument.
            AddTextToDocument(filePath, title, publication, instructor, company);
        }

        // Prints every line of the textdocument to the console.
        static void ListOfMovies(string filePath)
        {
            Console.WriteLine("Du har valgt at læse alle linjer fra textfilen.");
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                // Prints to console every line from textdocument.
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
        }

        // Searches through the text document for a specific word in the first textstring in every line.
        // Goes to the next line, when a '-' appears.
        static void SearchTitle(string filePath)
        {
            // Let the user search for a title.
            Console.WriteLine("Du har valgt at søge efter en specifik titel textfilen.");
            Console.Write("Indtast titlen som du søger efter: ");
            string specificWord = Console.ReadLine();

            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    bool foundSpecificWord = false;

                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();

                        // Split the line into words.
                        string[] words = line.Split('-', (char)StringSplitOptions.RemoveEmptyEntries);

                        // Check if the first word in the line contains the specific word.
                        if (words.Length > 0 && words[0].Contains(specificWord))
                        {
                            Console.WriteLine("Fandt titel: " + line);
                            foundSpecificWord = true;
                        }
                    }

                    // If the title dosent exist in the textdocument.
                    if (!foundSpecificWord)
                    {
                        Console.WriteLine("Titlen var ikke fundet.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("En fejl skete da den søgede efter en titel: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}

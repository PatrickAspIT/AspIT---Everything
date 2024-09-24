using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_i_C_sharp
{

    // Opgave 3.3
    public class Player
    {
        // Ændring for opgave 6.2
        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                {
                    Console.WriteLine("Value cannot be null or empty.");
                    Console.ReadLine();
                }
            }
        }
        public int score { get; set; }
        // Ændring for opgave 6.4
        public int Score
        {
            get { return score; }
        }

        public Player()
        {

        }

        // Opgave 5.4
        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        // Opgave 4.2 ------ HEAVILY rewritten for 5.5
        public static void Play(int amountPlayers, Player[] player)
        {
            // Initialize variables and clearing the console
            Console.Clear();
            Random rnd = new Random();
            int dice = 0;
            int value = 0;
            string input = "";
            int numberPlayer = 0;
            bool nameAndScore = true;

            do
            {
                // Writing score and name to console for all players
                if (nameAndScore == true)
                {
                    Console.WriteLine("Navn og score for alle spillere:");
                    foreach (var item in player)
                        Console.WriteLine("Navn: {0} - Score: {1}", item.name, item.score); 
                    Console.ReadLine();
                    Console.Clear();
                    nameAndScore = false;
                }

                // Dice roll code
                Console.WriteLine("1. {0} kan trykke på en knap for at slå en terning.", player[numberPlayer].name);
                Console.WriteLine("2. {0} kan skrive 'tilføj' for at tilføje din value til din score.", player[numberPlayer].name);
                Console.WriteLine("Det betyder også at det er næste spillers tur.");
                Console.WriteLine("2. {0} kan ændre navn ved at skrive 'ændre'.", player[numberPlayer].name);
                Console.WriteLine("4. {0} kan skrive 99 for at afslutte programmet.", player[numberPlayer].name);
                input = Console.ReadLine();

                // Check input with if-loop
                if (input != "99" && input != "tilføj" && input != "ændre")
                {
                    dice = rnd.Next(1, 6);
                    Console.WriteLine("{0} slog: {1}!", player[numberPlayer].name, dice);
                    value += dice;

                    // Moves to the next player and resets variables
                    if (dice == 1)
                    {
                        value = 0;
                        numberPlayer++;
                        nameAndScore = true;
                    }
                    if (dice != 1)
                        Console.WriteLine("Din værdi er på {0}.", value);
                }
                // Adds value to your score and resets variables
                else if (input == "tilføj")
                {
                    Console.WriteLine("Du tilføjer {0} til din score!", value);
                    player[numberPlayer].score = value;
                    value = 0;
                    numberPlayer++;
                    nameAndScore = true;
                }
                // Change name of current player - Opgave 6.2
                else if (input == "ændre")
                {
                    // Opgave 6.4
                    if (player[numberPlayer].score != 0)
                    {
                        Console.WriteLine("Spiller {0} har allerede point og kan derfor ikke ændre navn.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Indtast nyt navn: ");
                        player[numberPlayer].name = Console.ReadLine();
                    }
                }
                // If you want to close the program
                else
                    Console.WriteLine("Du lukker for programmet.");


                Console.ReadLine();
                Console.Clear();
                // Reset player turn
                if (numberPlayer == amountPlayers - 1)
                    numberPlayer = 0;
            } while (input != "99");

            // Print finished results
            Console.Clear();
            Console.WriteLine("Færdige Resultater:");
            Console.WriteLine("Name and score for all players:");
            foreach (var item in player)
                Console.WriteLine("Navn: {0} - Score: {1}", item.name, item.score);
            Console.ReadLine();
        }
    }
}

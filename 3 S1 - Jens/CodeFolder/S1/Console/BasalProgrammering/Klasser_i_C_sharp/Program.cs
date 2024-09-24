using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_i_C_sharp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast antal spillere: ");
            int amountPlayers = Convert.ToInt32(Console.ReadLine());
            Player[] player = CreatePlayers(amountPlayers);
            Player.Play(amountPlayers, player);
        }

        // Opgave 5.5  ---------- 3.5 rewritten
        static Player[] CreatePlayers(int amountPlayers)
        {
            Player[] player = new Player[amountPlayers];
            for (int i = 0; i < amountPlayers; i++)
            {
                Console.Write("Indtast navn på spiller {0}: ", i + 1);
                Player p = new Player();
                p.name = Console.ReadLine();
                p.score = 0;
                player[i] = p;
            }

            //foreach (var item in player)
            //{
            //    Console.WriteLine($"name= {item.name} - point: {item.score}");
            //}
            //Console.ReadLine();

            return player;
            

            // Opgave 3.7
            //Console.WriteLine("Name: {0}, Score: {1}", player1.name, player1.score);
            //Console.WriteLine("Name: {0}, Score: {1}", player2.name, player2.score);
            //Console.WriteLine("Name: {0}, Score: {1}", player3.name, player3.score);
            //Console.WriteLine("Name: {0}, Score: {1}", player4.name, player4.score);
            //Console.WriteLine("Name: {0}, Score: {1}", player5.name, player5.score);
            //Console.ReadLine();
        }
    }
}

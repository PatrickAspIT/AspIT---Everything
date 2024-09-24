using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMenu();

        }

        // Opgave 10.2
        static void SimpleMenu()
        {
            int loop = 0;
            do
            {
                Console.WriteLine("Velkommen til denne fantastiske menu. Du har nu fure muligheder:");
                Console.WriteLine();
                Console.WriteLine("Tryk a for at høre en historie.");
                Console.WriteLine("Tryk mellemrum for at høre en joke.");
                Console.WriteLine("Tryk 9 for at få et matematik spørgsmål.");
                Console.WriteLine("Tryk escape for at afslutte programmet.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.Clear();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Ørnen og alliken");
                        Console.WriteLine("En ørn, dykkede ned på sine kraftfulde vinger, greb et lam i sine klør og fløj " +
                            "væk med det til sin rede. En allike så gerningen og dens skøre hovede blev fyldt med idéen om, " +
                            "at han var stor og stærk nok til at gøre som ørnen havde gjort. Så med meget raslen af fjer og i " +
                            "et stejlt dyk, landede han på ryggen af en stor buk. Men da han forsøgte at lette igen, gik det op " +
                            "for ham at han ikke kunne komme væk, for hans klør var blevet filtret ind i ulden. Og så langt var " +
                            "han fra at kunne flyve væk med bukken, at bukken næsten ikke havde bemærket, at han var der.");
                        Console.WriteLine("Hyrden så den baskende allike og gættede omgående hvad der var sket. Han løb hen og fangede " +
                            "fuglen og stækkede dens vinger. Den aften gav han alliken til sine børn.");
                        Console.WriteLine("\"Sikke en sjov fugl det her er!\" Sagde de grinende, \"hvad kalder du den far ? \"");
                        Console.WriteLine("\"Det er en allike, mine børn.Men hvis du spørger ham, siger han nok at han er en ørn.\"");
                        Console.WriteLine("Morale: Overvurder ikke dine kræfter pga. din forfængelighed");
                        break;
                    case ConsoleKey.Spacebar:
                        Console.WriteLine("En røver kommer ind i butikken og stjæler et TV. blondinen løber efter ham og råber, “Vent, du har glemt fjernbetjeningen!”");
                        break;
                    case ConsoleKey.D9:
                        Console.WriteLine("Hvad er 2 + 2?");
                        int guess = int.Parse(Console.ReadLine());
                        if (guess == 4)
                            Console.WriteLine("Rigtigt!");
                        else
                            Console.WriteLine("Forkert!");
                        break;
                    case ConsoleKey.Escape:
                        loop = 1;
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            } while (loop == 0);
            
        }
    }
}

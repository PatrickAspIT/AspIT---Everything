using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //AnimalInfo();
            GradeInfo();

        }

        // Opgave 9.1
        static void AnimalInfo()
        {
            Console.WriteLine("Du kan få info omkring: Undulat, Papegøje, Hund, Kat og Gris.");
            Console.Write("Whilket dyr hvil du høre mere om (husk at skrive det første bogstav med stort): ");
            string animal = Console.ReadLine();

            if (animal == "Undulat")
                Console.WriteLine("Undulaten (Melopsittacus undulatus) er en lille papegøje, der stammer fra Australien. " +
                    "Arten er den eneste i slægten Melopsittacus. Der findes den lille australske undulat (den man finder i naturen), " +
                    "og den store engelske undulat, som er opdrættet mhp. udstilling.");
            else if (animal == "Papegøje")
                Console.WriteLine("De mange arter af papegøjer lever i store dele af troperne og har desuden traditionelt været " +
                    "holdt som kæledyr i bur.");
            else if (animal == "Hund")
                Console.WriteLine("Tamhunden (Canis lupus familiaris) er det husdyr, som tidligst blev tæmmet af mennesket, " +
                    "og som derfor har den længste historie til fælles med os. Den har gennem historien været brugt til jagt, " +
                    "som vagthund, krigshund (eks. anti-tank-hunde), sporhund, redningshund, eller som 'følgesvend'.");
            else if (animal == "Kat")
                Console.WriteLine("Tamkatten (Felis catus[1][2] eller Felis silvestris catus[3]) er et lille, tæmmet, kødædende " +
                    "pattedyr oftest med pels. Den kaldes huskat eller bare kat, når der ikke er grund til at skelne den fra andre kattedyr. " +
                    "Katten er værdsat af mennesker for dens selskab og evne til at jage mus og rotter. Mange huskatte bliver op mod 20 år gamle.");
            else if (animal == "Gris")
                Console.WriteLine("Svin anvendes til menneskeføde og opdrættes som slagtesvin på svinefarme. Svin kan bruges til en række fødevarer " +
                    "som flæskesteg, koteletter, fars, bacon og blodet kan anvendes til blodpølse. Huden garves og anvendes som skind til især beklædning. " +
                    "Huden udnyttes også som fødevare for mennesker i form af snacks (flæskesvær) og fyldstoffer i fødevareindustrien sammen med " +
                    "fedt- og benafpuds, ligesom dele af svinet anvendes til dyrefoder for hunde. En so har op til 14 brystvorter [1] og kan avle " +
                    "flere unger (grise) end de fleste andre pattedyr.");
            else
                Console.WriteLine("Du har ikke skrevet et dyr som der er indsat info omkring.");

            Console.ReadLine();
        }

        // Opgave 9.2
        static void GradeInfo()
        {
            Console.WriteLine("Skriv en karakter som: -3, 00, 02, 4, 7, 10 eller 12 og få en beskrivelse.");
            Console.Write("Karakter: ");
            string grade = Console.ReadLine();

            if (grade == "-3")
                Console.WriteLine("-3: For den ringe præstation. Karakteren -3 gives for den helt uacceptable præstation.");
            else if (grade == "00")
                Console.WriteLine("00: For den utilstrækkelige præstation. Karakteren 00 gives for den utilstrækkelige præstation, " +
                    "der ikke demonstrerer en acceptabel grad af opfyldelse af fagets/fagelementets mål.");
            else if (grade == "02")
                Console.WriteLine("02: For den tilstrækkelige præstation. Karakteren 02 gives for den tilstrækkelige præstation, " +
                    "der demonstrerer den minimalt acceptable grad af opfyldelse af fagets/fagelementets mål.");
            else if (grade == "4")
                Console.WriteLine("4: For den jævne præstation. Karakteren 4 gives for den jævne præstation, " +
                    "der demonstrerer en mindre grad af opfyldelse af fagets/fagelementets mål, med adskillige væsentlige mangler.");
            else if (grade == "7")
                Console.WriteLine("7: For den gode præstation. Karakteren 7 gives for den gode præstation, der demonstrerer opfyldelse " +
                    "af fagets/fagelementets mål, med en del mangler.");
            else if (grade == "10")
                Console.WriteLine("10: For den fortrinlige præstation. Karakteren 10 gives for den fortrinlige præstation, " +
                    "der demonstrerer omfattende opfyldelse af fagets/fagelementets mål, med nogle mindre væsentlige mangler.");
            else if (grade == "12")
                Console.WriteLine("12: For den fremragende præstation. Karakteren 12 gives for den fremragende præstation, der demonstrerer " +
                    "udtømmende opfyldelse af fagets/fagelementets mål, med ingen eller få uvæsentlige mangler.");
            else
                Console.WriteLine("Du har skrevet forkert.");

            Console.ReadLine();
        }
    }
}

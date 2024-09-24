using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassRolingCryptText
    {
        private List<string> key;
        private ClassDummyText CDT;
        private int keyJump = 3;

        public ClassRolingCryptText()
        {
            CDT = new ClassDummyText();
        }

        public ClassRolingCryptText(List<string> inKey)
        {
            key = inKey;
            CDT = new ClassDummyText(key);
        }

        public string RolingCryptString(string inString)
        {
            
            string res = CDT.MakeDummyString();
            Encoding enc1252 = Encoding.GetEncoding("Windows-1252");
            byte[] ascciBytes = enc1252.GetBytes(inString); // Konverterer input strengen til et array af bytes

            foreach (byte aByte in ascciBytes)
            {
                char aChar = (char)aByte;
                // Konverterer karakterer til tal baseret på key og tilføjer ekstra tegn fra MakeDummyString()
                res += MakeCodeOfChar(aChar) + CDT.MakeDummyString();
            }

            return res;
        }

        private string MakeCodeOfChar(char aChar)
        {
            string res = "";

            // Konverterer til string så vi kan lave en foreach
            int intChar = (int)aChar;
            string strChar = intChar.ToString();

            foreach (char aDigit in strChar)
            {
                //Tilføjer keyJump værdi til key placeringen og sørger for at værdien er fra 0 - 9 med modolus
                res += key[(int.Parse(aDigit.ToString()) + keyJump) % 10];
                keyJump += 3;
            }

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassRolingDecryptText
    {
        private List<string> listStringKey;
        private int keyJump = 3;
        private Encoding win1252 = Encoding.GetEncoding("Windows-1252");

        public ClassRolingDecryptText()
        {

        }

        public ClassRolingDecryptText(List<string> inKey)
        {
            listStringKey = inKey;
        }

        public string RolingDecryptString(string inString)
        {
            string res = "";
            string temp = "";

            Encoding enc1252 = Encoding.GetEncoding("Windows-1252");
            byte[] ascciBytes = enc1252.GetBytes(inString);

            // Gennemløber hele den krypterede tekststreng
            foreach (char asciiNO in ascciBytes)
            {
                // Udvælger de tegn der er en del af nøglen
                if (listStringKey.Contains(asciiNO.ToString()))
                {
                    // Gemmer den den af nøglen i en string objekt
                    temp += asciiNO.ToString();
                }
                else
                {
                    // Når der ikke er flere tegn der er en del af nøglen i den char og temp er givet en værdi
                    if (temp != "")
                    {
                        // Send temp til MakeCharOfCode og tilføj resultatet til res
                        res += MakeCharOfCode(temp);
                        temp = "";
                    }
                }
            }

            return res;
        }

        private string MakeCharOfCode(string inCharString)
        {
            string res = "";

            foreach (char inChar in inCharString)
            {
                // Omsæt tegn til tal der fremkommer ved at tegnet passer til en placering i List<string> key
                int intChar = listStringKey.IndexOf(inChar.ToString());
                intChar = GetRealRolingKey(intChar);
                res += intChar.ToString();
            }

            return $"{(char)Convert.ToInt32(res)}";
        }

        private int GetRealRolingKey(int inValue)
        {
            // Finder den originale værdi og sørger for at værdien går op i modolus
            int res = inValue - (keyJump % 10);

            // Sørger for at værdien ikke går i minus
            if (res < 0)
            {
                res = 10 - (res * -1);
            }
            keyJump += 3;

            return res;
        }
    }
}

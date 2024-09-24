using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassDummyText
    {
        private List<string> key;
        private Random ran = new Random();
        private Encoding win1252 = Encoding.GetEncoding("Windows-1252");

        public ClassDummyText()
        {
            
        }

        public ClassDummyText(List<string> inKey)
        {
            key = inKey;
        }

        public string MakeDummyString()
        {
            string res = "";
            int noOfChars = ran.Next(5, 16);

            for (int i = 1; i <= noOfChars; i++)
            {
                res += MakeDummyChar();
            }

            return res;
        }

        private string MakeDummyChar()
        {
            string res = "";
            bool foundInKey = false;

            do
            {
                res = win1252.GetString(new byte[] { (byte)ran.Next(33, 123) });
                foundInKey = key.Contains(res);

            } while (foundInKey);

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class ClassFileHandler
    {

        Encoding enc1252;
        Encoding encUTF8;

        public ClassFileHandler() 
        {
            enc1252 = Encoding.GetEncoding("Windows-1252");
            encUTF8 = Encoding.GetEncoding("UTF-8");
        }

        public string ReadTextFromFile(string path)
        {
            string res = "";
            if (path.Trim() == "")
            {
                return "Der er ikke angivet noget sti til filen.";
            }
            if (!System.IO.File.Exists(path))
            {
                return "Filen findes ikke.";
            }

            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Open)) 
                {
                    using (StreamReader reader = new StreamReader(fileStream, encUTF8))
                    {
                        res = reader.ReadToEnd();
                    }
                }
            }
            catch (IOException ex)
            {

                return ex.Message;
            }

            return res;
        }
    }
}

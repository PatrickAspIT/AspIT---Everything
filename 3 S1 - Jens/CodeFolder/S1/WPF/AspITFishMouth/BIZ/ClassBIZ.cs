using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;
using Repository;

namespace BIZ
{
    public class ClassBIZ
    {
        ClassFileHandler fileIO = new ClassFileHandler();
        ClassZIP zip = new ClassZIP();
        List<string> encryptionKey = new List<string>() { "T", "O", "R", "S", "K", "E", "M", "U", "N", "D"};

        public ClassBIZ()
        {
            clearText = new ClassText();
            cryptText = new ClassText();
        }

        /// <summary>
        /// Crypt knapperne krypterer teksten i clearText og sætter det ind i cryptText
        /// Decrypt knapperne dekrypterer teksten i cryptText og sætter det ind i cryptText
        /// Hvis begge sider er ens, efter at du har krypteret og dekrypteret, så virker det
        /// </summary>

        public ClassText clearText { get; set; }
        public ClassText cryptText { get; set; }

        public void MakeCryptText()
        {
            ClassCryptText CCT = new ClassCryptText(encryptionKey);
            cryptText.fishText = CCT.CryptString(clearText.fishText);
        }

        public void MakeDeCryptText()
        {
            ClassDecryptText CCT = new ClassDecryptText(encryptionKey);
            cryptText.fishText = CCT.DecryptString(cryptText.fishText);
        }

        public void MakeRolingCryptText()
        {
            ClassRolingCryptText CCT = new ClassRolingCryptText(encryptionKey);
            cryptText.fishText = CCT.RolingCryptString(clearText.fishText);
        }

        public void MakeRolingDecryptText()
        {
            ClassRolingDecryptText CCT = new ClassRolingDecryptText(encryptionKey);
            cryptText.fishText = CCT.RolingDecryptString(cryptText.fishText);
        }

        public void MakeExtraCryptText()
        {
            ClassRolingCryptText CCT = new ClassRolingCryptText(encryptionKey);
            cryptText.fishText = CCT.RolingCryptString(zip.CompressString(clearText.fishText));
        }

        public void DecryptExtraCryptText()
        {
            ClassRolingDecryptText CCT = new ClassRolingDecryptText(encryptionKey);
            cryptText.fishText = zip.DecompressString(CCT.RolingDecryptString(cryptText.fishText));
        }

        public void ReadClearTextFromFile(string path)
        {
            clearText.fishText = fileIO.ReadTextFromFile(path);
        }
        public void WriteClearTextToFile(string path)
        {
            fileIO.WriteTextToFile_StreamWriter(path, clearText.fishText);
        }

        public void ReadCryptTextFromFile(string path)
        {
            cryptText.fishText = fileIO.ReadTextFromFile(path);           
        }
        
        public void WriteCryptTextToFile(string path)
        {
            fileIO.WriteTextToFile_StreamWriter(path, cryptText.fishText);
        }
    }
}

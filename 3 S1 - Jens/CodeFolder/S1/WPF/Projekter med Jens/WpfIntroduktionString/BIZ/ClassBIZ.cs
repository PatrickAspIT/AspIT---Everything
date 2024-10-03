using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using IO;
using Repository;

namespace BIZ
{
    public class ClassBIZ : ClassNotify
    {

        ClassFileHandler fileHandler;
        private string _inText;
        private string _resText;
        private string _userInput;

        public ClassBIZ() 
        {
            fileHandler = new ClassFileHandler();
            inText = "";
            resText = "";
            userInput = "";
            ReadTextFromFile();
        }        

        public string userInput
        {
            get { return _userInput; }
            set
            {
                if (_userInput != value)
                {
                    _userInput = value;
                }
                Notify("userInput");
            }
        }

        public string resText
        {
            get { return _resText; }
            set
            {
                if (_resText != value)
                {
                    _resText = value;
                }
                Notify("resText");
            }
        }

        public string inText
        {
            get { return _inText; }
            set
            {
                if (_inText != value)
                {
                    _inText = value;
                }
                Notify("inText");
            }
        }

        public void Opgave1()
        {
            int count = 0;

            foreach (char character in inText)
            {
                if (character == 10)
                {
                    count++;
                }
            }
            resText = $"Der er {count} linjer i teksten";
        }

        public void Opgave2()
        {
            int count = 0;

            foreach(char character in inText)
            {
                if (character >= 32)
                {
                    count++;
                }
            }
            resText = $"Der er {count} karakterer i teksten";
        }

        public void Opgave3()
        {
            int count = 0;
            char[] charArray = {'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'y', 'Y', 'æ', 'Æ', 'ø', 'Ø', 'å', 'Å'};

            foreach (char c in inText)
            {
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (c == charArray[i])
                    {
                        count++;
                    }
                }
            }
            resText = $"Der er {count} vokaler i teksten";
        }

        public void Opgave4()
        {
            char[] charArray = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'y', 'Y', 'æ', 'Æ', 'ø', 'Ø', 'å', 'Å' };
            string newText = inText;

            foreach (char c in inText)
            {
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (c == charArray[i])
                    {
                        newText = newText.Replace(c.ToString(), "");
                    }
                }
            }
            resText = $"Ny tekst hvor alle vokaler er fjernet: \n\n {newText}";
        }

        public void Opgave5()
        {
            int count = 0;
            string newText = inText;

            if (userInput != "")
            {
                int i = newText.ToUpper().IndexOf(userInput.ToUpper());
                while (i != -1)
                {
                    newText = newText.Insert(i, "#>");
                    count++;
                    i = newText.ToUpper().IndexOf(userInput.ToUpper(), i + 3);
                }
                resText = $"Ordet {userInput} blev fundet {count} gange og er blevet markeret med #> \n\n {newText}";
            }
            else
            {
                resText = "Du har ikke indtastet et ord i tekstboksen!";
            }
        }

        public void Opgave6()
        {
            Dictionary<int, int> newDict = new Dictionary<int, int>();
            string[] allWords = inText.Split().Select(x => x.TrimEnd(",.;:-()".ToCharArray())).ToArray();
            string res = "";

            foreach (string word in allWords)
            {
                if (newDict.TryGetValue(word.Length, out int count))
                {
                    count++;
                    newDict[word.Length] = count;
                }
                else
                {
                    newDict.Add(word.Length, 1);
                }
            }

            var list = newDict.Keys.ToList();
            list.Sort();

            foreach ( int key in list)
            {
                string text = $"Ord med længde {key}: {newDict[key]} stk" + System.Environment.NewLine;
                res = res + text;
            }
            resText = res;
        }

        public void Opgave7()
        {
            Dictionary<string, int> newDict = new Dictionary<string, int>();
            string[] allWords = inText.Split().Select(x => x.TrimEnd(",.;:-".ToCharArray())).ToArray();
            string res = "";

            foreach (string word in allWords)
            {
                if (newDict.TryGetValue(word, out int count))
                {
                    count++;
                    newDict[word] = count;
                }
                else
                {
                    newDict.Add(word, 1);
                }
            }

            var list = newDict.Keys.ToList();
            list.Sort();

            foreach (string key in list)
            {
                string text = $"Ordet >> {key} << forekommer: {newDict[key]} antal gange" + System.Environment.NewLine;
                res += text;
            }

            resText = res;
        }

        public void Opgave8()
        {
            StringCollection lines = new StringCollection();
            string newFinalText = "";
            int lineCount = inText.Split('\n').Length;
            string[] stringArray = inText.Split('\n');

            for (int line = 0; line < lineCount; line++)
            {
                lines.Add(stringArray[line]);
            }  

            foreach (string line in lines)
            {
                string newLine = "";
                string[] allWords = line.Split().Select(x => x.TrimEnd(",.;:-".ToCharArray())).ToArray();
                foreach (string word in allWords)
                {
                    if (word.Length > 3)
                    {
                        newLine += $" {word.Substring(0, (word.Length - 1))}";
                    }
                    else
                    {
                        newLine += $" {word}";
                    }                      
                }

                newFinalText += newLine + System.Environment.NewLine;
            }

            resText = newFinalText;
        }

        private void ReadTextFromFile()
        {
            inText = fileHandler.ReadTextFromFile(@"C:\CodeFolder\S1\WPF\Admiralen.txt");
        }
    }
}

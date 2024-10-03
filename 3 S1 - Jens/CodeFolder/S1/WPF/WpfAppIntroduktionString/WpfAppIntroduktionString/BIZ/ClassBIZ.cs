using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfAppIntroduktionString.IO;

namespace WpfAppIntroduktionString.BIZ
{
    internal class ClassBIZ
    {
        ClassIO IO;
        public ClassBIZ()
        {
            IO = new ClassIO();
        }

        // Opgave 2.1
        public int CountAllLines(TextBox textBox)
        {
            int res = 0;
            int lineCount = textBox.LineCount;

            for (int line = 0; line < lineCount; line++)
            {
                if (textBox.GetLineText(line).Trim().Length > 0)
                    res++;
            }
            return res;
        }

        // Opgave 2.2
        public int CountAllChars(TextBox textBox)
        {
            int count = 0;

            foreach (char c in textBox.Text)
                count++;

            return count;
        }

        // Opgave 2.3
        public int CountAllVokals(TextBox textBox)
        {
            int count = 0;

            foreach(char c in textBox.Text)
            {
                switch (c)
                {
                    case 'a':
                    case 'A':
                        count++;
                        break;
                    case 'e':
                    case 'E':
                        count++;
                        break;
                    case 'i':
                    case 'I':
                        count++;
                        break;
                    case 'o':
                    case 'O':
                        count++;
                        break;
                    case 'u':
                    case 'U':
                        count++;
                        break;
                    case 'y':
                    case 'Y':
                        count++;
                        break;
                    case 'æ':
                    case 'Æ':
                        count++;
                        break;
                    case 'ø':
                    case 'Ø':
                        count++;
                        break;
                    case 'å':
                    case 'Å':
                        count++;
                        break;
                    default: break;
                }
            }

            return count;
        }

        // Opgave 2.4
        public string RemoveAllVokals(TextBox textBox)
        {
            string newText = textBox.Text;

            newText = newText.Replace("a", "");
            newText = newText.Replace("A", "");

            newText = newText.Replace("e", "");
            newText = newText.Replace("E", "");

            newText = newText.Replace("i", "");
            newText = newText.Replace("I", "");

            newText = newText.Replace("o", "");
            newText = newText.Replace("O", "");

            newText = newText.Replace("u", "");
            newText = newText.Replace("U", "");

            newText = newText.Replace("y", "");
            newText = newText.Replace("Y", "");

            newText = newText.Replace("æ", "");
            newText = newText.Replace("Æ", "");

            newText = newText.Replace("ø", "");
            newText = newText.Replace("Ø", "");

            newText = newText.Replace("å", "");
            newText = newText.Replace("Å", "");

            return newText;
        }

        // Opgave 2.5
        public string MarkAndCountWord(TextBox textBox, string word)
        {
            int count = 0;
            string textToSearch = textBox.Text;
            int i = textToSearch.IndexOf(word);
            while (i != -1)
            {
                textToSearch = textToSearch.Insert(i, "#>");
                count++;
                i = textToSearch.IndexOf(word, i + 3);
            }

            textToSearch = $"Ordet {word} blev fundet {count} gange og er blevet markeret med #> \n\n {textToSearch}";
            return textToSearch;
        }

        // Opgave 2.6
        public string CountNumberOfWordLength(TextBox textBox)
        {
            string res = "";
            Dictionary<int, int> dict = new Dictionary<int, int>();

            string[] allWords = textBox.Text.Split(' ');

            foreach (string word in allWords)
            {
                if (dict.TryGetValue(word.Length, out int count))
                {
                    count++;
                    dict[word.Length] = count;
                }
                else
                    dict.Add(word.Length, 1);
            }

            var list = dict.Keys.ToList();
            list.Sort();

            foreach (int key in list)
            {
                string text = $"Ord med længde {key}: {dict[key]} stk" + System.Environment.NewLine;
                res = res + text;
            }

            return res;
        }

        // Opgave 2.7
        public string CollectAllWords(TextBox textBox)
        {
            string res = "";
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string[] allWords = textBox.Text.Split().Select(x => x.TrimEnd(",.;:-".ToCharArray())).ToArray();

            foreach (string word in allWords)
            {
                if (dict.TryGetValue(word, out int count))
                {
                    count++;
                    dict[word] = count;
                }
                else
                    dict.Add(word, 1);
            }

            var list = dict.Keys.ToList();
            list.Sort();

            foreach (string key in list)
            {
                string text = $"Ordet >> {key} << forekommer: {dict[key]} antal gange" + System.Environment.NewLine;
                res = res + text;
            }

            return res;
        }

        // Opgave 2.8
        public void CutAwayLastLetterWhereWordIsLongerThan3Chars(TextBox oldText, TextBox newText)
        {
            StringCollection lines = new StringCollection();
            string newFinalText = "";
            int lineCount = oldText.LineCount;

            for (int line = 0; line < lineCount; line++)
                lines.Add(oldText.GetLineText(line));

            foreach (string line in lines)
            {
                string newLine = "";
                string[] allWords = line.Split().Select(x => x.TrimEnd(",.;:-".ToCharArray())).ToArray();
                foreach (string word in allWords)
                {
                    if (word.Length > 3)
                        newLine += $" {word.Substring(0, (word.Length - 1))}";
                    else
                        newLine += $" {word}";
                }

                newFinalText += newLine + System.Environment.NewLine;
            }

            newText.Text = newFinalText;
        }

        public string GetTextFromFile()
        {
            return IO.GetTextForTextBox();
        }
    }
}

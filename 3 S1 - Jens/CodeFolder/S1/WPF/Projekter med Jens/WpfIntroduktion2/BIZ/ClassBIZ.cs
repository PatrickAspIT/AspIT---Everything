using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace BIZ
{
    public class ClassBIZ
    {
        Random rnd = new Random();

        public ClassBIZ()
        {
                
        }

        public void Opgave1(ListBox inListBox)
        {
            for (int i = 4711; i < 4737; i++)
            {
                inListBox.Items.Add(i.ToString());
            }
        }

        public void Opgave2(ListBox inListBox)
        {
            for (int i = 0; i < 25; i++)
            {
                inListBox.Items.Add(rnd.Next(100000, 1000001));
            }
        }

        public void Opgave3(ListBox inListBox)
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                newList.Add(rnd.Next(100000, 1000001));
            }

            newList.Sort();

            foreach (int i in newList)
            {
                inListBox.Items.Add(i.ToString());
            }
        }

        public void Opgave4(ListBox inListBox)
        {         
            List<int> sortedList = new List<int>();        

            for (int i = 0; i < 25; i++)
            {
                sortedList.Add(rnd.Next(100000, 1000001));
            }

            List<int> unsortedList = new List<int>(sortedList);
            sortedList.Sort();

            for (int i = 0; i < 25; i++)
            {
                inListBox.Items.Add($"{unsortedList[i]} - {sortedList[i]}");
            }
        }

        public void Opgave5(ListBox inListBox)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = rnd.Next(100000, 1000001);
                list.Add(randomNumber);
                inListBox.Items.Add(randomNumber);
            }

            inListBox.Items.Add("");
            inListBox.Items.Add($"Gennemsnitsværdi: {GetAverageValue(list)}");
        }

        private int GetAverageValue(List<int> list)
        {
            int intRes = 0;
            int intCount = 0;

            foreach (int tal in list) 
            { 
                intRes += tal;
                intCount++;
            }

            intRes = intRes / intCount;

            return intRes;
        }

        public void Opgave6(ListBox inListBox)
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                newList.Add(rnd.Next(100000, 1000001));
            }

            newList.Sort();
            int intAverage = GetAverageValue(newList);

            foreach (int number in newList)
            {
                inListBox.Items.Add($"{number} - {intAverage} = {number - intAverage}");
            }
        }

        public List<string> Opgave7()
        {
            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = rnd.Next(100000, 1000001);
                intList.Add(randomNumber);
            }

            int intAverage = GetAverageValue(intList);
            intList.Sort();

            foreach (int tal in intList)
            {
                stringList.Add($"{tal} - {intAverage} = {tal - intAverage}");
            }

            return stringList;
        }

        public void Opgave8(ListBox inListBox)
        {
            List<int> intList = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = rnd.Next(100000, 1000001);
                intList.Add(randomNumber);
            }

            int intAverage = GetAverageValue(intList);
            intList.Sort();

            foreach (int tal in intList)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                if ((tal % 2) != 0)
                {
                    listBoxItem.Background = Brushes.AliceBlue;
                }
                else
                {
                    listBoxItem.Background = Brushes.HotPink;
                }

                listBoxItem.Content = $"{tal} - {intAverage} = {tal - intAverage}";
                inListBox.Items.Add(listBoxItem);
            }
        }

        public void Opgave9(ListBox inListBox)
        {
            List<int> intList = new List<int>();
            List<ListBoxItem> list = new List<ListBoxItem>();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = rnd.Next(100000, 1000001);
                intList.Add(randomNumber);
            }

            int intAverage = GetAverageValue(intList);
            intList.Sort();

            foreach (int tal in intList)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                if ((tal % 2) != 0)
                {
                    listBoxItem.Background = Brushes.AliceBlue;
                }
                else
                {
                    listBoxItem.Background = Brushes.HotPink;
                }

                listBoxItem.Content = $"{tal} - {intAverage} = {tal - intAverage}";
                list.Add(listBoxItem);
                
            }
            inListBox.ItemsSource = list;
        }
    }
}

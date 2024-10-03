using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfAppIntroduktion.BIZ
{
    internal class ClassBIZ
    {
        // Opgave 1.2
        public void Number4711(ListBox listBox) 
        {
            ClearList(listBox);

            for (int i = 4711; i <= 4736; i++)
                listBox.Items.Add(i.ToString());
        }

        // Opgave 1.3
        public void RandomNumber(ListBox listBox) 
        {
            ClearList(listBox);

            Random rnd = new Random();
            int randomNumber = 0;
            
            for (int i = 0; i < 25; i++)
            {
                randomNumber = rnd.Next(100000, 1000001);
                listBox.Items.Add(randomNumber.ToString());
            }
        }

        // Opgave 1.4
        public void RandomSort(ListBox listBox)
        {
            ClearList(listBox);

            Random rnd = new Random();
            List<int> list = new List<int>();

            for (int i = 0;i < 25; i++)
                list.Add(rnd.Next(100000, 1000001));

            list.Sort();

            foreach (int i in list)
                listBox.Items.Add(i.ToString());
        }

        // Opgave 1.5
        public void TwoLists(ListBox listBox)
        {
            ClearList(listBox);

            Random rnd = new Random();
            List<int> intListUnsorted = new List<int>();
            List<int> intListSorted = new List<int>();
            int randomNumber = 0;

            for(int i = 0; i < 25; i++)
            {
                randomNumber = rnd.Next(100000, 1000001);
                intListSorted.Add(randomNumber);
                intListUnsorted.Add(randomNumber);
            }

            intListSorted.Sort();

            for(int i = 0; i < intListSorted.Count; i++)
            {
                listBox.Items.Add($"{intListUnsorted[i]} - {intListSorted[i]}");
            }
        }

        // Opgave 1.6
        public void AverageValue(ListBox listBox)
        {
            ClearList(listBox);

            Random rnd = new Random();
            List<int> newList = new List<int>();
            int randomNumber = 0;

            for (int i = 0; i < 25; i++)
            {
                randomNumber = rnd.Next(100000, 1000001);
                listBox.Items.Add(randomNumber.ToString());
                newList.Add(randomNumber);
            }

            listBox.Items.Add("");
            listBox.Items.Add($"Gennemsnitsværdi: {CalcAverageValue(newList)}");
        }

        private int CalcAverageValue(List<int> list)
        {
            int totalNumber = 0;
            int ammountInList = 0;

            foreach (int i in list)
            {
                totalNumber += i;
                ammountInList++;
            }
            totalNumber = totalNumber / ammountInList;
            return totalNumber;
        }

        // Opgave 1.7
        public void ThreeValues(ListBox listBox)
        {
            ClearList(listBox);

            Random rnd = new Random();
            List<int> newList = new List<int>();

            for(int i = 0;i < 25; i++)
            {
                newList.Add(rnd.Next(100000, 1000001));
            }

            int AverageNumber = CalcAverageValue(newList);

            foreach (int i in newList)
            {
                listBox.Items.Add($"{i} - {AverageNumber} = {i - AverageNumber}");
            }
        }

        // Opgave 1.8
        public List<string> NoListBox()
        {
            Random rnd = new Random();
            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();

            for (int i = 0; i < 25; i++)
                intList.Add(rnd.Next(100000, 1000001));

            int averageValue = CalcAverageValue(intList);
            intList.Sort();

            foreach (int i in intList)
                stringList.Add($"{i} + {averageValue} = {i - averageValue}");

            return stringList;
        }

        private void ClearList(ListBox listBox)
        {
            if (listBox.ItemsSource != null)
                listBox.ItemsSource = null;
            listBox.Items.Clear();
        }

        // Opgavee 1.9
        public void BackgroundColor(ListBox listBox)
        {
            ClearList(listBox);

            Random rnd = new Random();
            List<int> intList = new List<int>();

            for (int i = 0; i < 25; i++)
                intList.Add(rnd.Next(100000, 1000001));

            int averageNumber = CalcAverageValue(intList);
            intList.Sort();

            foreach(int i in intList)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                if ((i % 2) != 0)
                    listBoxItem.Background = Brushes.AliceBlue;
                else
                    listBoxItem.Background= Brushes.HotPink;

                listBoxItem.Content = $"{i} + {averageNumber} = {i - averageNumber}";
                listBox.Items.Add(listBoxItem);
            }
        }

        // Opgave 1.10
        public List<ListBoxItem> FinalAssignment(ListBox listBox)
        {
            ClearList(listBox);

            Random rnd = new Random();
            List<int> intList = new List<int>();
            List<ListBoxItem> list = new List<ListBoxItem>();

            for (int i = 0; i < 25; i++)
                intList.Add(rnd.Next(100000, 1000001));

            int averageValue = CalcAverageValue(intList);
            intList.Sort();

            foreach (int i in intList)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                if ((i % 2) != 0)
                    listBoxItem.Background = Brushes.AliceBlue;
                else
                    listBoxItem.Background = Brushes.HotPink;

                listBoxItem.Content = $"{i} + {averageValue} = {i - averageValue}";
                list.Add(listBoxItem);
            }

            return list;
        }

    }
}

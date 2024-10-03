using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppIntroduktionString.BIZ;

namespace WpfAppIntroduktionString
{
    public partial class MainWindow : Window
    {
        ClassBIZ BIZ;
        public MainWindow()
        {
            InitializeComponent();
            BIZ = new ClassBIZ();
            textBoxMain.Text = BIZ.GetTextFromFile();
        }

        // Opgave 2.1
        private void Opgave_1_Click(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = $"Denne tekst indeholder {BIZ.CountAllLines(textBoxMain)} antal linjer med tekst";
        }

        // Opgave 2.2
        private void Opgave_2_Click(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = $"Denne tekst indeholder {BIZ.CountAllChars(textBoxMain)} antal tegn";
        }

        // Opgave 2.3
        private void Opgave_3_Click(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = $"Denne tekst indeholder {BIZ.CountAllVokals(textBoxMain)} antal vokaler";
        }

        // Opgave 2.4
        private void Opgave_4_Click(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = $"Tekst uden vokaler: \n\n {BIZ.RemoveAllVokals(textBoxMain)}";
        }

        // Opgave 2.5
        private void Opgave_5_Click(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = BIZ.MarkAndCountWord(textBoxMain, textBoxFindWord.Text);
        }

        // Opgave 2.6
        private void Opgave_6_Click(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = BIZ.CountNumberOfWordLength(textBoxMain);
        }

        // Opgave 2.7
        private void Opgave_7_Click(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = BIZ.CollectAllWords(textBoxMain);
        }

        private void Opgave_8_Click(object sender, RoutedEventArgs e)
        {
            BIZ.CutAwayLastLetterWhereWordIsLongerThan3Chars(textBoxMain, textBoxResult);
        }
    }
}

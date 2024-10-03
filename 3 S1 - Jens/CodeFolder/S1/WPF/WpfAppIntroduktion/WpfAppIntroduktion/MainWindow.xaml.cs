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
using WpfAppIntroduktion.BIZ;

namespace WpfAppIntroduktion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Opgave 1.1
        ClassBIZ classBIZ = new ClassBIZ();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Opgave 1.2
        private void buttonOpg12_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Number4711(listBoxRes);
        }

        // Opgave 1.3
        private void buttonOpg13_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.RandomNumber(listBoxRes);
        }

        // Opgave 1.4
        private void buttonOpg14_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.RandomSort(listBoxRes);
        }

        // Opgave 1.5
        private void buttonOpg15_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.TwoLists(listBoxRes);
        }

        // Opgave 1.6
        private void buttonOpg16_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.AverageValue(listBoxRes);
        }

        // Opgave 1.7
        private void buttonOpg17_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.ThreeValues(listBoxRes);
        }

        // Opgave 1.8
        private void buttonOpg18_Click(object sender, RoutedEventArgs e)
        {
            listBoxRes.ItemsSource = null;
            listBoxRes.Items.Clear();
            listBoxRes.ItemsSource = classBIZ.NoListBox();
        }

        // Opgave 1.9
        private void buttonOpg19_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.BackgroundColor(listBoxRes);
        }

        // Opgave 1.10
        private void buttonOpg20_Click(object sender, RoutedEventArgs e)
        {
            listBoxRes.ItemsSource = classBIZ.FinalAssignment(listBoxRes);
        }
    }
}

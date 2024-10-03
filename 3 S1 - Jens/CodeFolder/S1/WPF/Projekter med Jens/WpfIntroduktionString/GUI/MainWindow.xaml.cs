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
using BIZ;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ BIZ;

        public MainWindow()
        {
            InitializeComponent();
            BIZ = new ClassBIZ();
            MainGrid.DataContext = BIZ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BIZ.resText = "";
            int key = int.Parse(((Button)sender).Tag.ToString());
            AppMenu(key);
        }

        private void AppMenu(int inKey)
        {
            switch (inKey)
            {
                case 1:
                    BIZ.Opgave1();
                    break;
                case 2:
                    BIZ.Opgave2();
                    break;
                case 3:
                    BIZ.Opgave3();
                    break;
                case 4:
                    BIZ.Opgave4();
                    break;
                case 5:
                    BIZ.Opgave5();
                    break;
                case 6:
                    BIZ.Opgave6();
                    break;
                case 7:
                    BIZ.Opgave7();
                    break;
                case 8:
                    BIZ.Opgave8();
                    break;
                default:
                    break;
            }
        }
    }
}

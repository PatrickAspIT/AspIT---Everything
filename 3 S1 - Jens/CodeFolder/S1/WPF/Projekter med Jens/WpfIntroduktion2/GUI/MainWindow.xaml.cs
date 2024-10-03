using BIZ;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button myB = (Button)sender;
            Menu(int.Parse(myB.Tag.ToString()));
        }

        private void Menu(int inKey)
        {
            ClearListBox();

            switch (inKey)
            {
                case 1:
                    BIZ.Opgave1(ListBoxRes);
                    break;
                case 2:
                    BIZ.Opgave2(ListBoxRes);
                    break;
                case 3:
                    BIZ.Opgave3(ListBoxRes);
                    break;
                case 4:
                    BIZ.Opgave4(ListBoxRes);
                    break;
                case 5:
                    BIZ.Opgave5(ListBoxRes);
                    break;
                case 6:
                    BIZ.Opgave6(ListBoxRes);
                    break;
                case 7:
                    ListBoxRes.ItemsSource = BIZ.Opgave7();
                    break;
                case 8:
                    BIZ.Opgave8(ListBoxRes);
                    break;
                case 9:
                    BIZ.Opgave9(ListBoxRes);
                    break;
                default:
                    break;
            }
        }

        private void ClearListBox()
        {
            if (ListBoxRes.ItemsSource != null)
            {
                ListBoxRes.ItemsSource = null;
            }
            ListBoxRes.Items.Clear();
        }
    }
}

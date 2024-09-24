using BIZ;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace GUI
{
    public partial class MainWindow : Window
    {
        ClassBIZ BIZ;
        public MainWindow()
        {
            InitializeComponent();
            BIZ = new ClassBIZ();
            MainGrid.DataContext = BIZ;
        }

        // Crypt Text x3 metoder
        private void Button_Crypt_Click(object sender, RoutedEventArgs e)
        {
            BIZ.MakeCryptText();
        }

        private void Button_RolingCrypt_Click(object sender, RoutedEventArgs e)
        {
            BIZ.MakeRolingCryptText();
        }

        private void Button_CryptExtra_Click(object sender, RoutedEventArgs e)
        {
            BIZ.MakeExtraCryptText();
        }

        // Decrypt Text x3 metoder
        private void Button_Decrypt_Click(object sender, RoutedEventArgs e)
        {
            BIZ.MakeDeCryptText();
        }

        private void Button_RolingDecrypt_Click(object sender, RoutedEventArgs e)
        {
            BIZ.MakeRolingDecryptText();
        }

        private void Button_ExtraDecrypt_Click(object sender, RoutedEventArgs e)
        {
            BIZ.DecryptExtraCryptText();
        }

        // Load and save text x4 metoder
        private void Button_LoadClearText_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\CodeFolder\";
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == true)
            {
                BIZ.ReadClearTextFromFile(ofd.FileName);
            }
        }

        private void Button_SaveClearText_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\CodeFolder\";
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == true)
            {
                BIZ.WriteClearTextToFile(sfd.FileName);
            }
        }

        private void Button_LoadCryptText_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\CodeFolder\";
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == true)
            {
                BIZ.ReadCryptTextFromFile(ofd.FileName);
            }
        }

        private void Button_SaveCryptText_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\CodeFolder\";
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == true)
            {
                BIZ.WriteCryptTextToFile(sfd.FileName);
            }
        }
    }
}

using System.Windows;
using BIZ;

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

        private void ButtonPrintBoxReport_Click(object sender, RoutedEventArgs e)
        {
            BIZ.BoxTextToFile();
        }

        private void ButtonPrintTubeReport_Click(object sender, RoutedEventArgs e)
        {
            BIZ.TubeTextToFile();
        }
    }
}

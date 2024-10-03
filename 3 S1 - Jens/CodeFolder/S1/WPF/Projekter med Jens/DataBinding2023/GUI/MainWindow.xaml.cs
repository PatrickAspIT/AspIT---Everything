using BIZ;
using System.Windows;

namespace GUI
{
    public partial class MainWindow : Window
    {
        ClassBIZ BIZ;

        public MainWindow()
        {
            InitializeComponent();
            // Gives access to ClassBIZ
            BIZ = new ClassBIZ();
            MainGrid.DataContext = BIZ;
        }
    }
}

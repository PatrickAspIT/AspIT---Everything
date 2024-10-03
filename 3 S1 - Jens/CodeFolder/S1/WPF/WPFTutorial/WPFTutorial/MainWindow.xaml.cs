using System.Windows;

namespace WPFTutorial
{
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                // Stop
                tbStatus.Text = "Stopped";
                btnToggleRun.Content = "Run";
            }
            else
            {
                // Run
                tbStatus.Text = "Running";
                btnToggleRun.Content = "Stop";
            }
            
            running = !running;
        }
    }
}

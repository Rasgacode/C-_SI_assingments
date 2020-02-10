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
using System.Windows.Threading;

namespace TimerEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            //ProgressBar myProgressbar = this.FindName("myProgressBar") as ProgressBar;
            myProgressBar.Value += 10;

            if (myProgressBar.Value >= 100)
            {
                _timer.Stop();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Tick += new EventHandler(DispatcherTimer_Tick);
            _timer.Start();
        }
    }
}

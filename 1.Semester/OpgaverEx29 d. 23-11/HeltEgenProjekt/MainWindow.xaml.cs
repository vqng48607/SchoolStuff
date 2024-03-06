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

namespace HeltEgenProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Clock();
        }

        public void Clock()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += tickevent;
            dispatcherTimer.Start();
            
        }

        public void tickevent(object sender, EventArgs e)
        {
            lblClock.Content = DateTime.Now.ToString("HH:mm:ss");
        }

        public void DataTimeClock()
        {
            bool b = false;
            while (b == false)
            {
                DateTime dateTime = DateTime.Now;
            }
        }
    }
}

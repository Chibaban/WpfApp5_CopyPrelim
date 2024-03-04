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

namespace WpfApp5_CopyPrelim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _timerStatus = true;
        DispatcherTimer _dt = null;

        public MainWindow()
        {
            InitializeComponent();
            _dt = new DispatcherTimer();
            _dt.Tick += _dt_Tick;
            btnFinish.IsEnabled = false;
        }

        private void _dt_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(lblTimer.Content.ToString());
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = false;
            btnFinish.IsEnabled = true;
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RandomNum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

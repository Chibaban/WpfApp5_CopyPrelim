﻿using System;
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
        int _PlusNum1 = 0;
        int _PlusNum2 = 0;
        int _PlusNum4 = 0;
        int _PlusNum8 = 0;
        int _PlusNum16 = 0;
        int _PlusNum32 = 0;
        int _PlusNum64 = 0;
        int _PlusNum128 = 0;
        int _calc = 0;
        int _sec = 0;

        bool _timerStatus = true;
        DispatcherTimer _dt = null;
        Random _rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            _dt = new DispatcherTimer();
            _dt.Tick += _dt_Tick;
            _dt.Interval = new TimeSpan(0,0,0,0,1000);
            btnFinish.IsEnabled = false;
        }

        private void _dt_Tick(object sender, EventArgs e)
        {
            _sec = int.Parse(lblTimer.Content.ToString());
            _sec--;

            if (_sec == 0)
            {
                _dt.Stop();
                MessageBox.Show("Times up!");
                btnStart.IsEnabled = true;
                btnFinish.IsEnabled = false;
                _sec = 30;
            }

            lblTimer.Content = _sec.ToString();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = false;
            btnFinish.IsEnabled = true;
            _dt.Start();

            int rnd = _rnd.Next(0, 256);
            tbRandomNum.Text = rnd.ToString();
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            int btn1 = _PlusNum1;
            int btn2 = _PlusNum2;
            int btn4 = _PlusNum4;
            int btn8 = _PlusNum8;
            int btn16 = _PlusNum16;
            int btn32 = _PlusNum32;
            int btn64 = _PlusNum64;
            int btn128 = _PlusNum128;
            int result = btn1 + btn2 + btn4 + btn8 + btn16 + btn32 + btn64 + btn128;
            
            if (result.ToString() == tbRandomNum.Text)
            {
                _dt.Stop();
                MessageBox.Show("TAMA");
                btnStart.IsEnabled = true;
                btnFinish.IsEnabled = false;
                _sec = 30;
                lblTimer.Content = _sec.ToString();

                tb1.Text = "0";
                tb2.Text = "0";
                tb4.Text = "0";
                tb8.Text = "0";
                tb16.Text = "0";
                tb32.Text = "0";
                tb64.Text = "0";
                tb128.Text = "0";
                tbRandomNum.Text = "x";
            }
            else
            {
                MessageBox.Show("MALI");
            }
            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "1";
                _PlusNum1 = 1;
            }
            else 
            {
                tb1.Text = "0";
                _PlusNum1 = 0;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {            
            if (tb2.Text == "0")
            {
                tb2.Text = "1";
                _PlusNum2 = 2;
            }
            else
            {
                tb2.Text = "0";
                _PlusNum2 = 0;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (tb4.Text == "0")
            {
                tb4.Text = "1";
                _PlusNum4 = 4;
            }
            else
            {
                tb4.Text = "0";
                _PlusNum4 = 0;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (tb8.Text == "0")
            {
                tb8.Text = "1";
                _PlusNum8 = 8;
            }
            else
            {
                tb8.Text = "0";
                _PlusNum8 = 0;
            }
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            if (tb16.Text == "0")
            {
                tb16.Text = "1";
                _PlusNum16 = 16;
            }
            else
            {
                tb16.Text = "0";
                _PlusNum16 = 0;
            }
        }

        private void btn32_Click(object sender, RoutedEventArgs e)
        {
            if (tb32.Text == "0")
            {
                tb32.Text = "1";
                _PlusNum32 = 32;
            }
            else
            {
                tb32.Text = "0";
                _PlusNum32 = 0;
            }
        }

        private void btn64_Click(object sender, RoutedEventArgs e)
        {
            if (tb64.Text == "0")
            {
                tb64.Text = "1";
                _PlusNum64 = 64;
            }
            else
            {
                tb64.Text = "0";
                _PlusNum64 = 0;
            }
        }

        private void btn128_Click(object sender, RoutedEventArgs e)
        {
            if (tb128.Text == "0")
            {
                tb128.Text = "1";
                _PlusNum128 = 128;
            }
            else
            {
                tb128.Text = "0";
                _PlusNum128 = 0;
            }
        }
    }
}

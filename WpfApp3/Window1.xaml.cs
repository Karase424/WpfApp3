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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            this.Close();
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            if (radioBtn.IsChecked == true & radioBt5.IsChecked == true & radioBtn10.IsChecked == true & radioBtn316.IsChecked == true & radioBtn.IsChecked == true)
            {
                MessageBox.Show("Молодец, Боец ;)");
            }
            else
            {
                MessageBox.Show("Сорри, проходи заново");
            }

        }

        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    Application.Current.Shutdown();
        //}
    }
}

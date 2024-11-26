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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void Test(object sender, RoutedEventArgs e)
        {
            if (checkBtn.IsChecked == false & checkBtn2.IsChecked == true & checkBtn3.IsChecked == true & checkBtn4.IsChecked == false 
                & checkBtn5.IsChecked == true & checkBtn6.IsChecked == true & checkBtn7.IsChecked == false & checkBtn8.IsChecked == true 
                & checkBtn9.IsChecked == true & checkBtn10.IsChecked == false & checkBtn11.IsChecked == true & checkBtn12.IsChecked == false 
                & checkBtn13.IsChecked == false & checkBtn14.IsChecked == true & checkBtn15.IsChecked == true & checkBtn16.IsChecked == false)
            {
                MessageBox.Show("Молодец, Боец ;)");
            }
            else
            {
                MessageBox.Show("Сорри, проходи заново");
            }

        }
    }
}

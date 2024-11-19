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
    /// Логика взаимодействия для Window2.xaml 
    /// </summary> 
    public partial class Window2 : Window
    {
        private double _currentValue = 0;
        private double _storeValue = 0;
        private char _operation = '\0';

        public Window2()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Content.ToString();
            if (txtDisplay.Text == "0" && number != ".")
            {
                txtDisplay.Text = number;
            }
            else
            {
                txtDisplay.Text += number;
            }
        }
        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            _operation = button.Content.ToString()[0];
            _storeValue = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";

        }
        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            _currentValue = double.Parse(txtDisplay.Text);
            switch (_operation)
            {
                case '+':
                    _currentValue = _storeValue + _currentValue;
                    break;
                case '-':
                    _currentValue = _storeValue - _currentValue;
                    break;
                case 'X':
                    _currentValue = _currentValue * _storeValue;
                    break;
                case '/':
                    if (_currentValue != 0)
                    {
                        _currentValue = _storeValue / _currentValue;
                    }
                    else
                    {
                        MessageBox.Show("НА 0 ДЕЛИТЬ НЕЛЬЗЯ, ЛОХ!!)");
                        return;
                    }
                    break;
            }
            txtDisplay.Text = _currentValue.ToString();
            _operation = '\0';
        }
private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            _currentValue = 0;
            _storeValue = 0;
            _operation = '\0';
        }
    }
}
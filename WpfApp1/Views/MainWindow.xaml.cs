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

namespace SimpleCalculator.Views
{
    public partial class MainWindow : Window
    {
        private double _firstNumber;
        private string _operation = "";
        private bool _isNewEntry = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            if (TxtDisplay.Text == "0" || _isNewEntry)
            {
                TxtDisplay.Text = btn.Content.ToString();
                _isNewEntry = false;
            }
            else
            {
                TxtDisplay.Text += btn.Content.ToString();
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            _firstNumber = double.Parse(TxtDisplay.Text);
            _operation = btn.Content.ToString();
            _isNewEntry = true;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double secondNumber = double.Parse(TxtDisplay.Text);
            double result = 0;

            switch (_operation)
            {
                case "+": result = _firstNumber + secondNumber; break;
                case "-": result = _firstNumber - secondNumber; break;
                case "*": result = _firstNumber * secondNumber; break;
                case "/": result = secondNumber != 0 ? _firstNumber / secondNumber : 0; break;
            }

            TxtDisplay.Text = result.ToString();
            _isNewEntry = true;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TxtDisplay.Text = "0";
            _firstNumber = 0;
            _operation = "";
            _isNewEntry = true;
        }
    }
}

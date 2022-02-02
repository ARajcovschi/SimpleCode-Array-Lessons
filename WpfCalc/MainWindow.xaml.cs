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

namespace WpfCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        NumberInput number = new NumberInput();
        NumberInput firstValue = new();
        NumberInput secondValue = new();
        NumberInput action = new();
        

        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void btnNumberOne_Click(object sender, RoutedEventArgs e)
        {
            number.Number += "1";
            tbOutput.Text = number.Number;
        }
        private void btnNumberTwo_Click(object sender, RoutedEventArgs e)
        {
            number.Number += "2";
            tbOutput.Text = number.Number;
        }
        private void btnNumberThree_Click(object sender, RoutedEventArgs e)
        {
            number.Number += "3";
            tbOutput.Text = number.Number;
        }

        private void btnNumberFour_Click(object sender, RoutedEventArgs e)
        {
            number.Number += "4";
            tbOutput.Text = number.Number;
        }

        private void btnNumberFive_Click(object sender, RoutedEventArgs e)
        {
            number.Number += "5";
            tbOutput.Text = number.Number;
        }

        private void btnNumberSix_Click(object sender, RoutedEventArgs e)
        {
            number.Number += "6";
            tbOutput.Text = number.Number;
        }

        private void btnNumberSeven_Click(object sender, RoutedEventArgs e)
        {
            number.Number += "7";
            tbOutput.Text = number.Number;
        }

        private void btnNumberEight_Click(object sender, RoutedEventArgs e)
        {
            number.Number += "8";
            tbOutput.Text = number.Number;
        }

        private void btnNumberNine_Click(object sender, RoutedEventArgs e)
        {
            number.Number += "9";
            tbOutput.Text = number.Number;
        }

        private void btnNumberZero_Click(object sender, RoutedEventArgs e)
        {
            number.Number += "0";
            tbOutput.Text = number.Number;
        }

        private void btnDEL_Click(object sender, RoutedEventArgs e)
        {
            number.Number = null;
            firstValue.Number = null;
            secondValue.Number = null;
            tbOutput.Text = number.Number;
        }

        private void btnSeparate_Click(object sender, RoutedEventArgs e)
        {
            number.Number += ",";
            tbOutput.Text = number.Number;
        }

        private void btnPLUS_Click(object sender, RoutedEventArgs e)
        {
            if (firstValue.Number == null)
            {
                firstValue.Number = number.Number;
                number.Number = null;
            }
            else
            {
                secondValue.Number = number.Number;
            }

            action.Action = '+';
            tbOutput.Text = "+";
        }

        private void btnMULTIPLY_Click(object sender, RoutedEventArgs e)
        {
            if (firstValue.Number == null)
            {
                firstValue.Number = number.Number;
                number.Number = null;
            }
            else
            {
                secondValue.Number = number.Number;
            }
            action.Action = '*';
            tbOutput.Text = "*";
        }

        private void btnMINUS_Click(object sender, RoutedEventArgs e)
        {
            if (firstValue.Number == null)
            {
                firstValue.Number = number.Number;
                number.Number = null;
            }
            else
            {
                secondValue.Number = number.Number;
            }
            action.Action = '-';
            tbOutput.Text = "-";
        }

        private void btnDIVISION_Click(object sender, RoutedEventArgs e)
        {
            if (firstValue.Number == null)
            {
                firstValue.Number = number.Number;
                number.Number = null;
            }
            else
            {
                secondValue.Number = number.Number;
            }
            action.Action = '/';
            tbOutput.Text = "/";
        }

        private void btnRESOLVE_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            secondValue.Number = number.Number;
            if (action.Action == '+')
            {
                result = firstValue.StrToInt(firstValue.Number) + secondValue.StrToInt(secondValue.Number);
            }

            tbOutput.Text = result.ToString();

            if (action.Action == '-')
            {
                result = firstValue.StrToInt(firstValue.Number) - secondValue.StrToInt(secondValue.Number);
            }

            tbOutput.Text = result.ToString();

            if (action.Action == '*')
            {
                result = firstValue.StrToInt(firstValue.Number) * secondValue.StrToInt(secondValue.Number);
            }

            tbOutput.Text = result.ToString();

            if (action.Action == '/')
            {
                result = firstValue.StrToInt(firstValue.Number) / secondValue.StrToInt(secondValue.Number);
            }

            tbOutput.Text = result.ToString();

            number.Number = null;
            firstValue.Number = null;
            secondValue.Number = null;
            

        }
    }
}

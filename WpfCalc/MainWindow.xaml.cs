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

        NumberWrapper cacheInput = new();
        NumberWrapper firstValue = new();
        NumberWrapper mem = new();
        string mathFunc = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void InputDigit(string num)
        {
            cacheInput.NumberStr += num;
            tbOutput.Text = cacheInput.NumberStr;
        }
        public void MathAction(string operation)
        {
            tbOutput.Text = operation;

            if (firstValue.NumberStr == null)
            {
                firstValue.NumberStr = cacheInput.NumberStr;
                cacheInput.NumberStr = null;
            }

            else
            {
                Resolve();
            }
            mathFunc = operation;
        }
        public double Resolve()
        {
            double result = 0;

            if (mathFunc == "+")
                result = firstValue.Number + cacheInput.Number;

            if (mathFunc == "-")
                result = firstValue.Number - cacheInput.Number;

            if (mathFunc == "*")
                result = firstValue.Number * cacheInput.Number;

            if (mathFunc == "/")
                result = firstValue.Number / cacheInput.Number;

            firstValue.NumberStr = result.ToString();
            tbOutput.Text = result.ToString();
            cacheInput.NumberStr = null;
            return result;

        }
        #region Digit Buttons handlers
        private void btnNumberOne_Click(object sender, RoutedEventArgs e)
        {
            InputDigit("1");

        }
        private void btnNumberTwo_Click(object sender, RoutedEventArgs e)
        {
            InputDigit("2"); ;
        }
        private void btnNumberThree_Click(object sender, RoutedEventArgs e)
        {
            InputDigit("3");
        }

        private void btnNumberFour_Click(object sender, RoutedEventArgs e)
        {
            InputDigit("4");
        }

        private void btnNumberFive_Click(object sender, RoutedEventArgs e)
        {
            InputDigit("5");
        }

        private void btnNumberSix_Click(object sender, RoutedEventArgs e)
        {
            InputDigit("6");
        }

        private void btnNumberSeven_Click(object sender, RoutedEventArgs e)
        {
            InputDigit("7"); ;
        }

        private void btnNumberEight_Click(object sender, RoutedEventArgs e)
        {
            InputDigit("8"); ;
        }

        private void btnNumberNine_Click(object sender, RoutedEventArgs e)
        {
            InputDigit("9");
        }

        private void btnNumberZero_Click(object sender, RoutedEventArgs e)
        {
            InputDigit("0");
        }
        #endregion

        private void btnDEL_Click(object sender, RoutedEventArgs e)
        {
            cacheInput.NumberStr = null;
            firstValue.NumberStr = null;
            mem.NumberStr = null;
            mathFunc = string.Empty;
            tbOutput.Text = cacheInput.NumberStr;
        }

        private void btnSeparate_Click(object sender, RoutedEventArgs e)
        {
            if (cacheInput.NumberStr.Contains(","))
            {
                return;
            }
            InputDigit(",");
        }

        private void btnPLUS_Click(object sender, RoutedEventArgs e)
        {
            MathAction("+");
        }

        private void btnMULTIPLY_Click(object sender, RoutedEventArgs e)
        {
            MathAction("*");
        }

        private void btnMINUS_Click(object sender, RoutedEventArgs e)
        {
            MathAction("-");
        }

        private void btnDIVISION_Click(object sender, RoutedEventArgs e)
        {
            MathAction("/");
        }

        private void btnRESOLVE_Click(object sender, RoutedEventArgs e)
        {
            Resolve();
        }

        private void btnMEM_Click(object sender, RoutedEventArgs e)
        {
            if (mem.NumberStr == null)
                mem.NumberStr = cacheInput.NumberStr;
            else
            {
                cacheInput.NumberStr = mem.NumberStr;
                tbOutput.Text = mem.NumberStr;
            }
        }

        private void btnMEMclr_Click(object sender, RoutedEventArgs e)
        {
            if (mem.NumberStr != null)
                mem.NumberStr = null;
        }
    }
}

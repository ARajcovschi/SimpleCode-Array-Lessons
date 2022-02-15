using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

namespace WpfCalcNew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("en-GB");
            InitializeComponent();
            foreach (UIElement el in MainGrid.Children)
            {
                if (el is Button)
                    ((Button)el).Click += Button_Click;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            string text = (string)((Button)e.OriginalSource).Content;
            if (text == "AC")
                textBox.Text = "";
            else if(text=="=")
            { string result = new DataTable().Compute(textBox.Text, null).ToString();
                textBox.Text = result;
            }
            else
            {
                textBox.Text += text;

            }
        }
    }
}

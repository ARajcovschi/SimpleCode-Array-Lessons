using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalc
{
    public class NumberInput

    {
        public string Number { get; set; }
        public double StrToDouble(string number)
        {
            double dNum = double.Parse(number);
            return dNum;
        }

        public void ActionSelect(char action)
        {
            //if (firstValue.Number == null)
            
            //    firstValue.Number = number.Number;
            //    number.Number = null;

            //if (firstValue.Number != null)
            //    secondValue.Number = number.Number;


            //double result = firstValue.StrToDouble(firstValue.Number) + secondValue.StrToDouble(secondValue.Number);
            //tbOutput.Text = result.ToString();
            //firstValue.Number = result.ToString();
            //number.Number = null;
            //secondValue.Number = null;
        }
        public char Action { get; set; }

    }
}

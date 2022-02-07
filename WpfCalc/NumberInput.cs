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
        public char Action { get; set; }

    }
}

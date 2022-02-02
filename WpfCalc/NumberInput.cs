using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalc
{
    public class NumberInput

    {
        public NumberInput()
        {
            string number = null;
        }

        public string Number { get; set; }
        public int StrToInt(string number)
        {
            int intNum = int.Parse(number);
            return intNum;
        }

        public char Action { get; set; }

    }
}

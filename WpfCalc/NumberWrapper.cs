using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalc
{
    //TODO set проверка на число
    public class NumberWrapper
    {
        public string NumberStr { get; set; }
        public double StrToDouble(string number)
        {
            double dNum = double.Parse(number);
            return dNum;
        }


        public double Number
        {
            get { return double.Parse(NumberStr); }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculator
{
    //Response Example
    //{"success":true,"timestamp":1645952462,"base":"EUR","date":"2022-02-27","rates":{"USD":1.127263,"UAH":33.624923,"RUB":94.535583,"RON":4.94824,"GBP":0.840771,"MDL":20.477018}}
    public class CurrencyModel
    {
        public DateTime Date { get; set; }
        public RatesModel Rates { get; set; }
    }
}



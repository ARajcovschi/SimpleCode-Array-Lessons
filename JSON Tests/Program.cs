using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CurrencyCalculator
{//Response Example
    //{"success":true,"timestamp":1645952462,"base":"EUR","date":"2022-02-27","rates":{"USD":1.127263,"UAH":33.624923,"RUB":94.535583,"RON":4.94824,"GBP":0.840771,"MDL":20.477018}}
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string url = "http://api.exchangeratesapi.io/v1/latest?access_key=79e8adac70f9ff8e1d67471e1aa9be98&symbols=USD,UAH,RUB,RON,GBP,MDL&Eurformat=1";

            try
            {
                var httpResponseMessage = await client.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                
                var baseCurrency = JsonConvert.DeserializeObject<CurrencyModel>(jsonResponse);
                Console.WriteLine("\n Currency Rates on date of " + baseCurrency.Date);
                Console.WriteLine("1 EUR is equal to : "+baseCurrency.Rates.MDL+" MDL"); 
                Console.WriteLine("1 USD is equal to : "+(baseCurrency.Rates.MDL / baseCurrency.Rates.USD) + " MDL"); 
                Console.WriteLine("1 GBP is equal to : "+(baseCurrency.Rates.MDL / baseCurrency.Rates.GBP) + " MDL");
                Console.WriteLine("1 UAH is equal to : "+(baseCurrency.Rates.MDL / baseCurrency.Rates.UAH) + " MDL"); 
                Console.WriteLine("1 RUB is equal to : "+(baseCurrency.Rates.MDL / baseCurrency.Rates.RUB) + " MDL"); 
                Console.WriteLine("1 RON is equal to : "+(baseCurrency.Rates.MDL / baseCurrency.Rates.RON) + " MDL");

                var mdlRates = new CurrencyModel();
                mdlRates.Date = baseCurrency.Date;
                mdlRates.Rates.USD = (baseCurrency.Rates.MDL / baseCurrency.Rates.USD);
                mdlRates.Rates.GBP = baseCurrency.Rates.MDL / baseCurrency.Rates.GBP;
                mdlRates.Rates.UAH = baseCurrency.Rates.MDL / baseCurrency.Rates.UAH;
                mdlRates.Rates.RUB = baseCurrency.Rates.MDL / baseCurrency.Rates.RUB;
                mdlRates.Rates.RON = baseCurrency.Rates.MDL / baseCurrency.Rates.RON;
                mdlRates.Rates.EUR = baseCurrency.Rates.MDL;
                Console.WriteLine(mdlRates.Date);
                Console.WriteLine(mdlRates.Rates.USD);
                Console.WriteLine("\n"+mdlRates.Rates.GBP);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

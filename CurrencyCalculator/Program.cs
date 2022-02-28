using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace CurrencyCalculator
{
    //Класс который совпадает с АПИ
    //ГЕТ запрос с АПИ
    //отдать текст в НьютонСофт
    //работа с объектом
    class Program
    {

        static readonly HttpClient client = new HttpClient();

        string rawJson;

        //public async Task<CurrencyModel> GetCurrencyJson()
        //{
        
        //    var request = new HttpRequestMessage(HttpMethod.Get,
        //        "http://api.exchangeratesapi.io/v1/latest?access_key=79e8adac70f9ff8e1d67471e1aa9be98&symbols=USD,UAH,RUB,RON,GBP,MDL&Eurformat=1");
        //    HttpResponseMessage response = await client.SendAsync(request);
        //    if (response.IsSuccessStatusCode)
        //    {
        //       CurrencyModel rates   = await response.Content.ReadFromJsonAsync<CurrencyModel>();
        //        return rates.Rates ;
        //    }
        //    else
        //    {
        //        throw new Exception(response.ReasonPhrase);
        //    }
            
           
        
        static void Main()
        {
           
            Console.ReadLine();
        }
       
    }
}

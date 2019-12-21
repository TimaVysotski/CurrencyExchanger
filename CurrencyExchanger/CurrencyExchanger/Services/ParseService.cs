using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CurrencyExchanger
{
    static public class ParseService
    {

        static public Dictionary<string, double> getCurrency()
        {
            string jsonResponse = NetworkService.getJSONResponse();
            List<Rate> list = JsonConvert.DeserializeObject<List<Rate>>(jsonResponse);
            Dictionary<string, double> exchangeRate = new Dictionary<string, double>();
            foreach (var currency in list)
            {
                if (currency.Cur_Abbreviation == "USD")
                {
                    exchangeRate.Add("USD", Convert.ToDouble(currency.Cur_OfficialRate));
                }
                if (currency.Cur_Abbreviation == "EUR")
                {
                    exchangeRate.Add("EUR", Convert.ToDouble(currency.Cur_OfficialRate));
                }
            }
            return exchangeRate;
        }
    }
}

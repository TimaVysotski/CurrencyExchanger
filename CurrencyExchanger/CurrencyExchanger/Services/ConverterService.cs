using System;
using System.Collections.Generic;

namespace CurrencyExchanger
{
    public class ConverterService
    {
        Dictionary<string, double> exchangeRate = ParseService.getCurrency();
        SettingsRepository settignsRepository = new SettingsRepository();
        int maxBuy;
        int maxSell;
        public ConverterService ()
        {
            exchangeRate.Add("BYN", 1);
        }

        public double convertCurrency(int amount, string fromCurrency, string toCurrency)
        {
            double result = getBynEcvivalent(amount, fromCurrency);
            return result / exchangeRate[toCurrency];
        }

        public double getBynEcvivalent(int amount, string fromCurrency)
        {
            double bynEcvivalent = amount;
            if (fromCurrency != "BYN")
            {
                return  bynEcvivalent * exchangeRate[fromCurrency];
            }
            return bynEcvivalent;
        }

        public bool tryToPerform(int amount, string username, string opCode, string fromCurrency)
        {
            Settings defaultSettings = settignsRepository.getOfCurrentUsername("default");
            maxBuy = defaultSettings.MaxBuy;
            maxSell = defaultSettings.MaxSell;
            Settings userSettings = settignsRepository.getOfCurrentUsername(username);
            bool result = false;
            if (userSettings.Username == null)
            {
                userSettings.Username = username;
                userSettings.LimitationDate = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                settignsRepository.Write(userSettings);
            }
            if (userSettings.LimitationDate != (DateTime.Now.ToString("dd/MM/yyyy")))
            {
                userSettings.LimitationDate = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                userSettings.CurrentBuyDate = 0;
                userSettings.CurrentSellDate = 0;
            }
            int current = opCode == "Buy" ? userSettings.CurrentBuyDate : userSettings.CurrentSellDate;
            int max = opCode == "Buy" ? maxBuy : maxSell;
            if (current + getBynEcvivalent(amount, fromCurrency) <= max)
            {
                current += (int)getBynEcvivalent(amount, fromCurrency);
                int res = opCode == "Buy" ? userSettings.CurrentBuyDate = current : userSettings.CurrentSellDate = current;
                result = true;
            }

            settignsRepository.Update(userSettings);
            return result;
        }
    }
}

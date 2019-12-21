using System;

namespace CurrencyExchanger
{
    public class Settings
    {
        public int Id { get; set; }
        public int MaxSell { get; set; }
        public int MaxBuy { get; set; }
        public string LimitationDate { get; set; }
        public int CurrentSellDate { get; set; }
        public int CurrentBuyDate { get; set; }
        public string Username { get; set; }

        public Settings(int id, int maxSell, int maxBuy, string limitationDate, int currentSellDateign, int currentBuyDate, string username)
        {
            Id = id;
            MaxSell = maxSell;
            MaxBuy = maxBuy;
            LimitationDate = limitationDate;
            CurrentSellDate = currentSellDateign;
            CurrentBuyDate = currentBuyDate;
            Username = username;
        }

        public Settings()
        {
           
        }
    }
}

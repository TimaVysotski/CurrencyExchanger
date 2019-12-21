using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    public class AdminService
    {
        SettingsRepository settignsRepository = new SettingsRepository();
        public int maxBuy { get; set; }
        public int maxSell { get; set; }
        public AdminService()
        {
            Settings defaultSettings = settignsRepository.getOfCurrentUsername("default");
            maxBuy = defaultSettings.MaxBuy;
            maxSell = defaultSettings.MaxSell;
        }
        public void updateMax(int buyMax, int sellMax)
        {
            Settings defaultSettings = settignsRepository.getOfCurrentUsername("default");
            maxBuy = buyMax;
            maxSell = sellMax;
            defaultSettings.Username = "default";           
            defaultSettings.MaxBuy = maxBuy;
            defaultSettings.MaxSell = maxSell;
            defaultSettings.LimitationDate = DateTime.Now.ToString("dd/MM/yyyy");
            settignsRepository.Update(defaultSettings);
        }

    }
}

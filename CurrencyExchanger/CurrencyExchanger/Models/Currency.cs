using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    public class Currency
    {
        public string Sign { get; set; }
        public Currency( string sign)
        {
            Sign = sign;
        }
    }
}

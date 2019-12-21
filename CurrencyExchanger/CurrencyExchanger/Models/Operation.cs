using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    public class Operation
    {
        public string Username { get; set; }
        public string Operations { get; set; }
        public string Amount { get; set; }
        public string Sign { get; set; }
        public string Date { get; set; }

        public Operation(string username, string operations, string amount, string sign)
        {
            Username = username;
            Operations = operations;
            Amount = amount;
            Sign = sign;
            Date = Convert.ToString(DateTime.Now);
        }

        public Operation()
        {
      
        }
    }
}

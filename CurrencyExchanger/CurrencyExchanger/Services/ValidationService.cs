using System.Linq;

namespace CurrencyExchanger
{
    static public class ValidationService
    {
        static public bool isCurrencyMountValid(string amount)
        {
            return amount.All(char.IsDigit);
        }
    }
}

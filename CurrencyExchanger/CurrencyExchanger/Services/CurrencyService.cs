using System.Windows.Forms;

namespace CurrencyExchanger
{
    static public class CurrencyService
    {
        static ConverterService converter = new ConverterService();
        static HistoryService history = new HistoryService();
        static public void performCurrencyOperation(string username, int amount, string fromCurrency, string toCurrency, string opCode)
        {
            double result = converter.convertCurrency(amount, fromCurrency, toCurrency);
            if (!converter.tryToPerform(amount,username, opCode, fromCurrency))
            {
                MessageBox.Show("Limites error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                history.addRecord(username, opCode, result, toCurrency);
                CheckService.showCheck(username, amount, fromCurrency, toCurrency, opCode, result);
            }
        }
    }
}

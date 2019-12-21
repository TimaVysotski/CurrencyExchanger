
using System.Windows.Forms;

namespace CurrencyExchanger
{
    static public class CheckService
    {
        static public void showCheck(string username, int amount, string fromCurrency, string toCurrency, string opCode, double result)
        {
            string checkDiscription = "Your opeariton is done.\n" + "U " + opCode + " : " + result + " " + toCurrency + ".\n" + "U spend : " + amount + " " + fromCurrency + ".";
            MessageBox.Show(checkDiscription, "Chech", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public class AdminPresenter
    {
        AdminService adminService;
        public AdminPresenter()
        {
            adminService = new AdminService();
        }

        public string getBuyMax()
        {
            return Convert.ToString(adminService.maxBuy);
        }

        public string getSellMax()
        {
            return Convert.ToString(adminService.maxSell);
        }

        public void updateMax(string maxBuy, string maxSell)
        {
            if (ValidationService.isCurrencyMountValid(maxBuy) && ValidationService.isCurrencyMountValid(maxSell))
            {
                adminService.updateMax(Convert.ToInt32(maxBuy), Convert.ToInt32(maxSell));
                MessageBox.Show("operation is done", "Operation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Validation error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

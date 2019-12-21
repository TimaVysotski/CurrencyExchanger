using System;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public class OperationPresenter
    {
        private User user;
        private OperationForm operationForm;
        private HistoryService historyService;
        public OperationPresenter(OperationForm operation, User user)
        {
            this.user = user;
            operationForm = operation;
            historyService = new HistoryService();
        }
        public void performOperation(String username, String opCode, string amount, string fromSign, string toSign)
        {
            if (ValidationService.isCurrencyMountValid(amount))
            {
                CurrencyService.performCurrencyOperation(username, Convert.ToInt32(amount), fromSign, toSign, opCode);
            }
            else
            {
                MessageBox.Show("Validation error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void backToLogin()
        {
            operationForm.Close();
        }
    }
}

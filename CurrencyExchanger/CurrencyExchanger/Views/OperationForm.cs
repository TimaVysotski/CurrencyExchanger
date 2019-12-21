using System;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public partial class OperationForm : Form
    {
        private User user;
        private OperationPresenter operationPresenter;
        public OperationForm(User user)
        {
            InitializeComponent();
            tradeSignsComboBox.SelectedIndex = 0;
            buySignComboBox.SelectedIndex = 1;
            this.user = user;
            operationPresenter = new OperationPresenter(this, user);
        }
        private void performOperation(string operation)
        {
            operationPresenter.performOperation(user.Username, operation, amountTextBox.Text, Convert.ToString(tradeSignsComboBox.SelectedItem), Convert.ToString(buySignComboBox.SelectedItem));   
        }
        private void buyButton_Click(object sender, EventArgs e)
        {
            performOperation("Buy");
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            performOperation("Sell");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operationPresenter.backToLogin();
        }
    }
}

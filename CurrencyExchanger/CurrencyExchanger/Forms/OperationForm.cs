using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public partial class OperationForm : Form
    {
        private User user;
        public OperationForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void performOperation(string opCode)
        {
            // TODO: Add Convert class
            Operation operation = new Operation(user.Username, opCode, amountTextBox.Text, "$");
            DataBase.getInstance().WriteOperation(operation);
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            performOperation("Buy");
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            performOperation("Cell");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm(user);
            login.Show();
        }
    }
}

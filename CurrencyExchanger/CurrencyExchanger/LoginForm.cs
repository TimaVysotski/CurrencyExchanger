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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void adminButton_MouseEnter(object sender, EventArgs e)
        {
            adminButton.ForeColor = Color.DarkBlue;
        }

        private void adminButton_MouseLeave(object sender, EventArgs e)
        {
            adminButton.ForeColor = Color.Black ;
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.DarkBlue;
        }
        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Black;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExchangerForm exchangerForm = new ExchangerForm();
            exchangerForm.Show();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}

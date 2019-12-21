using System;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public partial class LoginForm : Form
    {
        private LoginPresenter loginPresenter;
        public LoginForm()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter(this);
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            loginPresenter.adminButtonClick();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginPresenter.loginButtonClick(textBox1.Text);
        }
    }
}

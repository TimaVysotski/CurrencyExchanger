using System;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public class LoginPresenter
    {
        private User user;
        private LoginForm loginForm;
        public LoginPresenter(LoginForm login)
        {
            user = new User();
            loginForm = login;
        }
        public void adminButtonClick()
        {
            loginForm.Hide();
            AdminForm adminForm = new AdminForm(user);
            adminForm.ShowDialog();
            loginForm.Show();
        }

        public void loginButtonClick(String username)
        {
            if (username == "")
            {
                MessageBox.Show("Empty Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user.Username = username;
                loginForm.Hide();
                OperationForm operationForm = new OperationForm(user);
                operationForm.ShowDialog();
                loginForm.Show();
            }
        }
    }
}

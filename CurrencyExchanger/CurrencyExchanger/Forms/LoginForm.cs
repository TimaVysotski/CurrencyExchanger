using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public partial class loginForm : Form
    {
        private User user;
        public loginForm( User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Empty Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user.Username = textBox1.Text;
                this.Hide();
                OperationForm operationForm = new OperationForm(user);
                operationForm.Show();
            }
        }
    }
}

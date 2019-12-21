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
    public partial class AdminForm : Form
    {
        private User user;
        private AdminPresenter adminPresenter;
        public AdminForm(User user)
        {
            InitializeComponent();
            this.user = user;
            adminPresenter = new AdminPresenter();
            buyTextBox.Text = adminPresenter.getBuyMax();
            sellTextBox.Text = adminPresenter.getSellMax();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            HistoryForm historyForm = new HistoryForm(user);
            historyForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            adminPresenter.updateMax(buyTextBox.Text, sellTextBox.Text);
        }
    }
}

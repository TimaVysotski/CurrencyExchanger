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
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();*/
        }
    }
}

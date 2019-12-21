using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchanger
{
    public partial class HistoryForm : Form
    {
        private User user;
        public HistoryForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            HistoryService historyService = new HistoryService();
            foreach(string line in historyService.getHistoryList())
            {
                listBox3.Items.Add(line);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(user);
            adminForm.Show();
        }
    }
}

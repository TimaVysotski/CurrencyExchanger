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

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            foreach(string line in DataBase.getInstance().ReadOperations())
            {
                listBox3.Items.Add(line);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();*/
        }

        private void HistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
   
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

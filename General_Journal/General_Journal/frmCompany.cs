using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Journal
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'general_JournalDataSet.company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.general_JournalDataSet.company);
            // TODO: This line of code loads data into the 'general_JournalDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.general_JournalDataSet.users);

        }

        //// double click open main
        private void dataGCmpany_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String compId = dataGCompany[0, e.RowIndex].Value.ToString();
            frmMain frmM = new frmMain(compId);
            frmM.Show();
            this.Hide();
        }
    }
}

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
    public partial class frmAuto_AddEdit : Form
    {
        public frmAuto_AddEdit()
        {
            InitializeComponent();
        }

        private void frmAuto_AddEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'general_JournalDataSet.accountNo' table. You can move, or remove it, as needed.
            this.accountNoTableAdapter.Fill(this.general_JournalDataSet.accountNo);

        }
    }
}

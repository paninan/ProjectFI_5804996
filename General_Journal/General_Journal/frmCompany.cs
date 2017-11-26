using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Journal
{
    public partial class frmCompany : Form
    {
        OleDbConnection conn = null;
        public frmCompany()
        {
            InitializeComponent();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'general_JournalDataSet.company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.general_JournalDataSet.company);
        }

        //// double click open main
        private void dataGCmpany_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String compId = dataGCompany[0, e.RowIndex].Value.ToString();
            frmMain frmM = new frmMain(compId);
            frmM.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCompany_frmAddEdit frmCompany_frmAddEdit = new frmCompany_frmAddEdit();
            frmCompany_frmAddEdit.Show();
        }

        public void refreshCompanyData()
        {
            this.companyTableAdapter.Fill(this.general_JournalDataSet.company);
            dataGCompany.Update();
            dataGCompany.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshCompanyData();
        }

        //private void loadDataCompany()
        //{
        //    conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);
        //    string strSql = "Select [COMPANY_ID] ,[COMPANY_NAME] from company";
        //    OleDbCommand cmd = new OleDbCommand(strSql, conn);
        //    conn.Open();
        //    cmd.CommandType = CommandType.Text;
        //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //    DataTable scores = new DataTable();
        //    da.Fill(scores);
        //    dataGridView1.DataSource = scores;

        //}
    }
}

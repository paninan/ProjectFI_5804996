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
            Program.ACTIVE_COMPANY_ID = Int32.Parse(compId);
           // MessageBox.Show(Program.ACTIVE_COMPANY_ID.ToString() + " " + Program.ACTIVE_USER_ID.ToString());
            frmMain frmM = new frmMain(compId);
            frmM.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCompany_frmAddEdit frmCompany_frmAddEdit = new frmCompany_frmAddEdit(this);            
            frmCompany_frmAddEdit.Show();
        }


        public void refreshCompanyData()
        {
            this.companyTableAdapter.Fill(this.general_JournalDataSet.company);
            dataGCompany.Update();
            dataGCompany.Refresh();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            String compId = dataGCompany[0, dataGCompany.CurrentCell.RowIndex].Value.ToString();
            String compName = dataGCompany[1, dataGCompany.CurrentCell.RowIndex].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Do you want to delete "+ compName, "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);
                    string query = "DELETE FROM company WHERE [COMPANY_ID]=@compID";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@compID", compId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Remove "+ compName + " done !!!");
                        // refresh data gridview frmCompany
                        refreshCompanyData();
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String compId = dataGCompany[0, dataGCompany.CurrentCell.RowIndex].Value.ToString();
            String compName = dataGCompany[1, dataGCompany.CurrentCell.RowIndex].Value.ToString();

            frmCompany_frmAddEdit frmCompany_frmAddEdit = new frmCompany_frmAddEdit(this,compId);
            frmCompany_frmAddEdit.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmMain : Form
    {
        String companyID = null;
        OleDbConnection conn = null;

        public object Panel3 { get; private set; }

        public frmMain(String companyId)
        {
            InitializeComponent();
            companyID = companyId;
        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //// connect database
            try
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);
                //conn.Open();
               
                lblCompanyName.Text = "Unknow";
                

                // load from access 
                using (OleDbCommand cmd = new OleDbCommand("select * from company where [COMPANY_ID]=@compxxID", conn))
                {
                    cmd.Parameters.AddWithValue("@compxxID", companyID);                    
                    cmd.Connection.Open();
                    OleDbDataReader reader = null;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lblCompanyName.Text = "Company : " + reader["COMPANY_NAME"].ToString();
                    }
                
                }

            }
            catch (Exception Ex)
            {                
                conn.Dispose();
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnAccNO_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();
            frmAccNo frmAcc = new frmAccNo();
            frmAcc.TopLevel = false;
            panel3.Controls.Add(frmAcc);
            frmAcc.Show();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAutoAcc_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();
            frmAuto frmAut = new frmAuto();
            frmAut.TopLevel = false;
            panel3.Controls.Add(frmAut);
            frmAut.Show();
        }

        private void btnJournal_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();
            frmGeneralJournal frmGer = new frmGeneralJournal();
            frmGer.TopLevel = false;
            panel3.Controls.Add(frmGer);
            frmGer.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmReport frmRep = new frmReport();
            frmRep.TopLevel = false;
            panel3.Controls.Add(frmRep);
            frmRep.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCompany frmComp = new frmCompany();
            frmComp.Show();
            this.Close();

        }
    }
}

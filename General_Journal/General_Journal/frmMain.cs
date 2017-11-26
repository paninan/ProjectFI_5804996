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
                //OleDbDataReader reader = null;
                //OleDbCommand cmd = new OleDbCommand("select * from company where COMPANY_ID="+companyID, conn);
                //reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    lblCompanyName.Text = "Company : "+reader["COMPANY_NAME"].ToString();                    
                //}

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
    }
}

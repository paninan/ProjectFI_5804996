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
    public partial class frmCompany_frmAddEdit : Form
    {
        OleDbConnection conn = null;
        public frmCompany_frmAddEdit()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check textbox
            if (String.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("Enter CompanyName ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Enter Address ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Enter Phone ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (String.IsNullOrEmpty(txtTradeRegisNo.Text))
            {
                MessageBox.Show("Enter Trade Register No. ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (String.IsNullOrEmpty(txtTaxIdNo.Text))
            {
                MessageBox.Show("Enter Tax Id No. ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            //// connect database
            try
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);

                string cmdText = "INSERT INTO company ([COMPANY_NAME],[COMPANY_ADDRESS],[COMPANY_PHONE],[COMPANY_TRADE_REGIS],[COMPANY_TAX_ID]) VALUES ( @compName ,@compAddress ,@compPhone ,@compTrade ,@compTax )";

                using (OleDbCommand cmd = new OleDbCommand(cmdText, conn))
                {
                    conn.Open();
                    //cmd.Parameters.Add("@compName", OleDbType.VarChar).Value = txtCompanyName.Text;
                    //cmd.Parameters.Add("@compAddress", OleDbType.VarChar).Value = txtAddress.Text;
                    //cmd.Parameters.Add("@compPhone", OleDbType.VarChar).Value = txtPhone.Text;
                    //cmd.Parameters.Add("@compTrade", OleDbType.VarChar).Value = txtTradeRegisNo.Text;
                    //cmd.Parameters.Add("@compTax", OleDbType.VarChar).Value = txtTaxIdNo.Text;

                    cmd.Parameters.AddWithValue("@compName", txtCompanyName.Text);
                    cmd.Parameters.AddWithValue("@compAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@compPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@compTrade", txtTradeRegisNo.Text);
                    cmd.Parameters.AddWithValue("@compTax", txtTaxIdNo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved ");
                }
                

                // refresh data gridview frmCompany

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

        private void frmCompany_frmAddEdit_Load(object sender, EventArgs e)
        {

        }
    }
}

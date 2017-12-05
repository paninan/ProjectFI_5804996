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
    public partial class frmAccNo : Form
    {

        OleDbConnection conn = null;
        public string accNO = null;
        public frmAccNo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAccNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'general_JournalDataSet.accountNo' table. You can move, or remove it, as needed.
            this.accountNoTableAdapter.Fill(this.general_JournalDataSet.accountNo);

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void add()
        {
            // connect database & Add data
            try
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);

                string cmdText = "INSERT INTO accountNo ([ACC_NO],[ACC_NAME],[ACC_CATEGORY]) VALUES ( @accNo ,@accName ,@accCat )";

                using (OleDbCommand cmd = new OleDbCommand(cmdText, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@accNo", txtAccNo.Text);
                    cmd.Parameters.AddWithValue("@accName", txtAccName.Text);
                    cmd.Parameters.AddWithValue("@accCat", cmbCategory.Text);
                    

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successed");
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

        private void update()
        {
            // connect database & Add data
            try
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);

                string cmdText = "UPDATE accountNo SET [ACC_NAME] = @accName, [ACC_CATEGORY] = @accCat WHERE [ACC_NO] = @accNo";

                using (OleDbCommand cmd = new OleDbCommand(cmdText, conn))
                {
                    conn.Open();                    
                    cmd.Parameters.AddWithValue("@accName", txtAccName.Text);
                    cmd.Parameters.AddWithValue("@accCat", cmbCategory.Text);
                    cmd.Parameters.AddWithValue("@accNo", txtAccNo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successed");
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

            btnAdd.Text = "Add";


        }
        private void delete()
        {
            // connect database & Add data
            try
            {
                String accNo = dataGAccNo[0, dataGAccNo.CurrentCell.RowIndex].Value.ToString();
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);

                string cmdText = "DELETE FROM accountNo  WHERE [ACC_NO] = @accNo";

                using (OleDbCommand cmd = new OleDbCommand(cmdText, conn))
                {
                    conn.Open();                    
                    cmd.Parameters.AddWithValue("@accNo", accNo);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete successed");
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


        public void refreshAccNoData()
        {
            this.accountNoTableAdapter.Fill(this.general_JournalDataSet.accountNo);
            dataGAccNo.Update();
            dataGAccNo.Refresh();
        }

        private void clearText()
        {
            txtAccNo.Clear();
            txtAccName.Clear();
            cmbCategory.SelectedIndex = -1;


        }

        private void txtAccNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //number only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (String.IsNullOrEmpty(txtAccNo.Text))
                {
                    MessageBox.Show("Enter Account No. ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(txtAccName.Text))
                {
                    MessageBox.Show("Enter Account Name ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(cmbCategory.Text))
                {
                    MessageBox.Show("Enter Account Category ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                add();
                clearText();
                refreshAccNoData();
            }

            else
            {
                if (String.IsNullOrEmpty(txtAccName.Text))
                {
                    MessageBox.Show("Enter Account Name ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(cmbCategory.Text))
                {
                    MessageBox.Show("Enter Account Category ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtAccNo.ReadOnly = false;
                btnDelete.Enabled = true;
                update();
                clearText();
                refreshAccNoData();
            }



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            String accNo = dataGAccNo[0, dataGAccNo.CurrentCell.RowIndex].Value.ToString();
            String accName = dataGAccNo[1, dataGAccNo.CurrentCell.RowIndex].Value.ToString();

            accNO = accNo;


            //// connect database
            try
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);
                using (OleDbCommand cmd = new OleDbCommand("select * from accountNo where [ACC_NO]=@accNO", conn))
                {
                    cmd.Parameters.AddWithValue("@accNO", accNo);
                    cmd.Connection.Open();
                    OleDbDataReader reader = null;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtAccNo.Text = reader["ACC_NO"].ToString();
                        txtAccName.Text = reader["ACC_NAME"].ToString();
                        cmbCategory.Text = reader["ACC_CATEGORY"].ToString();

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

            txtAccNo.ReadOnly = true;
            btnAdd.Text = "Apply";
            btnDelete.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
            refreshAccNoData();
        }
    }
}

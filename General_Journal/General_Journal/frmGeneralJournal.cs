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
    public partial class frmGeneralJournal : Form
    {
        OleDbConnection conn = null;
        public string accNO = null;

        private string girdAccNO = null;
        private string girdAccName = null;
        private double girdAccDebit = 0.0;
        private double girdAccCredit = 0.0;
                

        public frmGeneralJournal()
        {
            InitializeComponent();
        }

        private void frmGeneralJournal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'general_JournalDataSet.company' table. You can move, or remove it, as needed.
            //this.companyTableAdapter.Fill(this.general_JournalDataSet.company);
            // TODO: This line of code loads data into the 'general_JournalDataSet.accountNo' table. You can move, or remove it, as needed.
            //this.accountNoTableAdapter.Fill(this.general_JournalDataSet.accountNo);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtJournalNo.Text))
            {
                MessageBox.Show("Enter general journal No.. ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(dtpJournal.Text))
            {
                MessageBox.Show("Enter Date ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtDocNo.Text))
            {
                MessageBox.Show("Enter Document No. Category ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Enter Description ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtTotalDebit.Text) && String.IsNullOrEmpty(txtTotalCredit.Text))
            {
                MessageBox.Show("Enter Account order,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(txtTotalDebit.Text == txtTotalCredit.Text)
            {
                Save();

            }
            else
            {
                MessageBox.Show("Debit and credit must be equal.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            
        }

        private void btnSearchAccNo_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // double click Column AccNo Only
            if (e.ColumnIndex == 0 )
            {
                //checked accNo is null to new record 
                DataGridViewCell dtCell = dataGridView1[0, dataGridView1.CurrentCell.RowIndex];
                if ( dtCell.Value == null )
                {
                    // new
                    openFrmAccNo();
                }
                else
                {
                    MessageBox.Show("This Record Account No. [ " + dtCell.Value.ToString()+" ] ");
                }
            }
        }

        private void openFrmAccNo()
        {
            //MessageBox.Show("frmAccNohasOpen");
            frmGeneralJournal_openFrmAccNo frmAccNo = new frmGeneralJournal_openFrmAccNo(this);
            frmAccNo.Show();
        }

        private void calcTotal()
        {
            // Loop through every row, and colour the corresponding cell
            double totalDebit = 0.0;
            double totalCredit = 0.0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cellDebit = row.Cells[2];
                DataGridViewCell cellCredit = row.Cells[3];
                if (cellDebit.Value == null )
                {
                    totalDebit += 0.0;
                }
                else
                {
                    totalDebit += Double.Parse(cellDebit.Value.ToString());
                }


                if (cellCredit.Value == null)
                {
                    totalCredit += 0.0;
                }
                else
                {
                    totalCredit += Double.Parse(cellCredit.Value.ToString());
                }
            }

            txtTotalDebit.Text = totalDebit.ToString();
            txtTotalCredit.Text = totalCredit.ToString();
        }

        public bool addRowGridAccNoData(String accNo,String accName)
        {
            try
            {
                //MessageBox.Show(accNo + " " + accName);
                girdAccNO = accNo;
                girdAccName = accName;
                this.dataGridView1.Rows.Add(girdAccNO, girdAccName, 0, 0);
                int lastRowIdx = this.dataGridView1.Rows.Count;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[lastRowIdx-2].Cells[2];
            }
            catch
            {
                MessageBox.Show("Can not add record");
                return false;
            }

           

            return true;

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calcTotal();
        }

        private void Clear()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            txtJournalNo.Text = "";            
            txtDocNo.Text = "";
            txtDescription.Text = "";
            txtTotalCredit.Text = "";
            txtTotalDebit.Text = "";
        }

        private void Save()
        {
            try
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);
                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    String cellAccNo = row.Cells[0].Value == null ? "" : row.Cells[0].Value.ToString();
                    String cellAccName = row.Cells[1].Value == null ? "" : row.Cells[1].Value.ToString();
                    Double cellDebit = row.Cells[2].Value == null ? 0 : Double.Parse( row.Cells[2].Value.ToString());
                    Double cellCredit = row.Cells[3].Value == null ? 0 : Double.Parse(row.Cells[3].Value.ToString());

                    if (cellAccNo == "" )
                    {
                        continue;
                    }

                    string cmdText = "INSERT INTO gerneralJournal ([GJ_NO],[GJ_DATE],[GJ_DOC_NO],[GJ_DESCRIPTION] , [ACC_NO] , [ACC_NAME] , [ACC_DEBIT] , [ACC_CREDIT] , [COMPANY_ID] , [USER_ID]) " +
                        " VALUES (@gjNo,@gjDate,@gjDocNo,@gjDescription,@accNo,@accName,@accDebit,@accCredit,@compId,@userId )";

                    using (OleDbCommand cmd = new OleDbCommand(cmdText, conn))
                    {
                        if (conn.State != ConnectionState.Open)
                            conn.Open();

                        cmd.Parameters.AddWithValue("@gjNo",txtJournalNo.Text);
                        cmd.Parameters.AddWithValue("@gjDate", Convert.ToDateTime(dtpJournal.Text));
                        cmd.Parameters.AddWithValue("@gjDocNo",txtDocNo.Text);
                        cmd.Parameters.AddWithValue("@gjDescription",txtDescription.Text);
                        cmd.Parameters.AddWithValue("@accNo", cellAccNo);
                        cmd.Parameters.AddWithValue("@accName", cellAccName);
                        cmd.Parameters.AddWithValue("@accDebit", cellDebit);
                        cmd.Parameters.AddWithValue("@accCredit", cellCredit);
                        cmd.Parameters.AddWithValue("@compId", Program.ACTIVE_COMPANY_ID);
                        cmd.Parameters.AddWithValue("@userId", Program.ACTIVE_USER_ID);

                        cmd.ExecuteNonQuery();
                        
                    }
                    
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                MessageBox.Show("Save Successed");
                conn.Close();
                Clear();
            }
            
        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
    
    
}

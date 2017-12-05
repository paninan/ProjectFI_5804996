using System;
using System.Collections;
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
    public partial class frmReport : Form
    {
        ArrayList GridDataChecksDate = new ArrayList();
        ArrayList GridDataChecksDesc = new ArrayList();
        OleDbConnection conn = null;
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // clear
            txtCredit.Clear();
            txtDebit.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            GridDataChecksDate.Clear();
            GridDataChecksDesc.Clear();

            double totalDebit = 0.0;
            double totalCredit = 0.0;
            //// connect database
            try
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);
                String query = "SELECT gerneralJournal.* ,company.COMPANY_NAME,users.username FROM " +
                    "(gerneralJournal   LEFT JOIN  company ON   gerneralJournal.COMPANY_ID = company.COMPANY_ID) " +
                    "LEFT JOIN  users ON   gerneralJournal.USER_ID = users.id " +
                    "WHERE [gerneralJournal.COMPANY_ID] = @compID " +
                    //"AND [gerneralJournal.USER_ID] = @userID " +
                    "AND [gerneralJournal.GJ_NO] = @gjNo " +
                    "AND ( gerneralJournal.GJ_DATE >= Format(@dateStart,\"dd/mm/yyyy\") AND gerneralJournal.GJ_DATE <= Format(@dateStop,\"dd/mm/yyyy\") )";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {                    
                    cmd.Parameters.AddWithValue("@compID", Program.ACTIVE_COMPANY_ID);
                    //cmd.Parameters.AddWithValue("@userID", Program.ACTIVE_USER_ID);
                    cmd.Parameters.AddWithValue("@gjNo", txtJournalNo.Text);
                    cmd.Parameters.AddWithValue("@dateStart", Convert.ToDateTime(dateStart.Text).ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("@dateStop", Convert.ToDateTime(dateStop.Text).ToString("dd/MM/yyyy"));
                    cmd.Connection.Open();
                    OleDbDataReader reader = null;
                    string description = null;
                    string date = null;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lblCompanyName.Text = "Company Name :"+reader["COMPANY_NAME"].ToString();
                        //lblDate.Text = "Date :" + Convert.ToDateTime(reader["GJ_DATE"].ToString()).ToShortDateString();
                        lblGeneralJournal.Text = "General Journal No :" + reader["GJ_NO"].ToString();

                        dataGridView1.Rows.Add(
                            checkColumnDate( Convert.ToDateTime(reader["GJ_DATE"].ToString()).ToShortDateString() ,0),
                            checkColumnDate(reader["GJ_DESCRIPTION"].ToString(),1), 
                            reader["ACC_NO"].ToString(), 
                            reader["ACC_NAME"].ToString(),
                            zeroToNull( reader["ACC_DEBIT"].ToString() ),
                            zeroToNull( reader["ACC_CREDIT"].ToString() )
                        );

                        // calculate
                        totalDebit += Double.Parse( reader["ACC_DEBIT"].ToString());
                        totalCredit += Double.Parse(reader["ACC_CREDIT"].ToString());
                    }
                    int lastRowIdx = this.dataGridView1.Rows.Count;


                    txtDebit.Text = totalDebit.ToString();
                    txtCredit.Text = totalCredit.ToString();
                    
                    // check enable btn
                    btnExportExcel.Enabled = lastRowIdx > 0 ? true : false;
                    
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

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private String checkColumnDate(String column,int colIdx)
        {
            if (colIdx == 0)
            {
                bool foundFlag = false;
                foreach (String item in GridDataChecksDate)
                {
                    if (item.Equals(column))
                    {
                        foundFlag = true;
                        return "";
                        break;
                    }
                }

                if (foundFlag == false)
                {
                    //Object not exists
                    GridDataChecksDate.Add(column);
                    GridDataChecksDesc.Clear();
                    return column;
                }
            }

            if (colIdx == 1)
            {
                bool foundFlag = false;
                foreach (String item in GridDataChecksDesc)
                {
                    if (item.Equals(column))
                    {
                        foundFlag = true;
                        return "";
                        break;
                    }
                }

                if (foundFlag == false)
                {
                    //Object not exists
                    GridDataChecksDesc.Add(column);
                    return column;
                }
            }


            // response
            return null;
        }

        private string zeroToNull(string currency)
        {
            if(currency.Equals("0") )
            {
                return "";
            }
            
            return currency;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "General journal";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column.
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                        }
                        
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }
    }
}

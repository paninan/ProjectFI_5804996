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
    public partial class frmGeneralJournal_openFrmAccNo : Form
    {
        OleDbConnection conn = null;
        frmGeneralJournal frmParent;        

        public frmGeneralJournal_openFrmAccNo(frmGeneralJournal parent)
        {
            InitializeComponent();
            frmParent = parent;
        }

        private void frmGeneralJournal_openFrmAccNo_Load(object sender, EventArgs e)
        {            
            loadDataGrid();
        }

        public void loadDataGrid()
        {
            //// connect database
            try
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);
                

                // load from access 
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM accountNo ORDER BY [ACC_NO]", conn))              
                using (var adapter = new OleDbDataAdapter(cmd))
                {
                    conn.Open();
                    var myTable = new DataTable();
                    adapter.Fill(myTable);
                    dataGaccNo.DataSource = myTable;

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

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String accNo = dataGaccNo[0, e.RowIndex].Value.ToString();
            String accName = dataGaccNo[1, e.RowIndex].Value.ToString();

            frmParent.addRowGridAccNoData(accNo, accName);
            this.Close();
        }
    }
}

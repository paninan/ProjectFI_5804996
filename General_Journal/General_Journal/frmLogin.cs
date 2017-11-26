using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.OleDb;

namespace General_Journal
{
    public partial class frmLogin : Form
    {

        OleDbConnection conn = null;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //// connect database
            try
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["General_Journal.Properties.Settings.General_JournalConnectionString"].ConnectionString);
                conn.Open();
                lblConnection.Text = "Connection :" + (conn.State == ConnectionState.Open ? "Success" : "Fail");
            }
            catch(Exception Ex)
            {
                lblConnection.Text = "Connection : Fail "+"["+Ex.Message+"]";
                conn.Dispose();
            }
            finally
            {                
                conn.Close();
            }
            
            btnLogin.Select();            
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;

            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || txtUsername.Text == "Username")
            {
                MessageBox.Show("Enter Username ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (String.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
            {
                MessageBox.Show("Enter password ,please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //// Login 

            try
            {          

                using (OleDbCommand cmd = new OleDbCommand("SELECT count(*) FROM users where [USERNAME]=@UserName and [PASSWORD]=@Password", conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Connection.Open();
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        // MessageBox.Show("You have successfully Logged In"); 
                        frmCompany frmCom = new frmCompany();
                        frmCom.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
            else
            {
                txtUsername.ForeColor = Color.Black;
            }
           
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }

            
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
            else            
            {
                txtPassword.ForeColor = Color.Black;
                
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
            
        }
    }
}

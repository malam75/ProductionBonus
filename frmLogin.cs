using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MainMenu
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(general.conStr);

        private void cmdLogin_Click(object sender, EventArgs e)
        {

            String SQl = "SELECT * FROM Users WHERE UserId='" + txtUser.Text + "' AND pwd='" + txtPwd.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(SQl,con);
           
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count.ToString() == "1")
               {
                   general.strLoc= dt.Rows[0].Field<string>("Location");
                  

                this.Hide();
                new frmMainMenu().Show();
            }
            else
                MessageBox.Show("Invalid username or password");  
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPwd.Focus();
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmdLogin.Focus();
            }

        }

    
    }
}

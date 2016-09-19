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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(general.conStr);

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {

//                frmEmpList frm = new frmEmpList();
 //               comEmpID.Visible = true;

//                frm.Show();
//                MessageBox.Show("You pressed the F1 key");
//                return true;    // indicate that you handled this keystroke
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
                      
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            fillDept();
            fillDesg();
            LoadGrid();

            dtDOB.Format = DateTimePickerFormat.Custom;
            dtDOB.CustomFormat = "dd-MM-yyyy";
            dtDOB.Value = DateTime.Today;
            dtDOJ.Format = DateTimePickerFormat.Custom;
            dtDOJ.CustomFormat = "dd-MM-yyyy";
            dtDOJ.Value = DateTime.Today;
            
            cmdSave.Enabled = false;
            cmdEdit.Enabled = false;
            cmdCancel.Enabled = false;




        }

        private void LoadGrid()
        {

//            string connectionString = ConfigurationManager.ConnectionStrings["CNN"].ConnectionString;
//            SqlConnection con= new SqlConnection(connectionString);
            string sql = "SELECT * FROM PEMP";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            DataTable tempDT = new DataTable();
            tempDT = dt.DefaultView.ToTable(true, "Eno", "Ename","Dept","Post","FName","Addrs1","NID","BDate","JDate");

//            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = tempDT;
            dataGridView1.Columns["Eno"].HeaderText = "Emp ID";
            dataGridView1.Columns["Ename"].HeaderText = "Employee Name";
            dataGridView1.Columns["Ename"].Width = 200;
            dataGridView1.Columns["Dept"].HeaderText = "Department";
            dataGridView1.Columns["Post"].HeaderText = "Designation/Post";
            dataGridView1.Columns["Fname"].HeaderText = "Father's Name";
            dataGridView1.Columns["addrs1"].HeaderText = "Address";
            dataGridView1.Columns["NID"].HeaderText = "CNIC";
            dataGridView1.Columns["BDate"].HeaderText = "Date of Birth";
            dataGridView1.Columns["JDate"].HeaderText = "Date of Joining";
            dataGridView1.Columns["JDate"].Width = 125;

            dataGridView1.Columns["BDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dataGridView1.Columns["JDate"].DefaultCellStyle.Format = "dd-MM-yyyy";

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
            dataGridView1.Columns[8].ReadOnly = true;

        }

        private void fillDept()
        {
            string sql = "SELECT * FROM dept";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                comDept.Items.Add(sdr["Dept"].ToString());

            }
            sdr.Close();
            con.Close();

        }

        private void fillDesg()
        {
            string sql = "SELECT * FROM Desg";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                comDesg.Items.Add(sdr["Desg"].ToString());

            }
            sdr.Close();
            con.Close();

        }

     

        
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtEmpID.Text = dr.Cells["Eno"].Value.ToString();
            comDept.Text=dr.Cells["Dept"].Value.ToString();
            comDesg.Text = dr.Cells["Post"].Value.ToString();
            txtName.Text = dr.Cells["Ename"].Value.ToString();
            txtFname.Text = dr.Cells["Fname"].Value.ToString();
            txtAdd.Text = dr.Cells["addrs1"].Value.ToString();
            txtCNIC.Text = dr.Cells["NID"].Value.ToString();
            dtDOB.Text = dr.Cells["BDate"].Value.ToString();
            dtDOJ.Text = dr.Cells["JDate"].Value.ToString();
            cmdEdit.Enabled = true;
            cmdCancel.Enabled = true;
            cmdEdit.Focus();

        }

        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                String sql = "SELECT * FROM PEMP WHERE Eno='" + txtEmpID.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count.ToString() == "1")
                {
                    
                    txtEmpID.Text = dt.Rows[0].Field<string>("Eno");
                    comDept.Text = dt.Rows[0].Field<string>("Dept");
                    comDesg.Text = dt.Rows[0].Field<string>("Post");
                    txtName.Text = dt.Rows[0].Field<string>("EName");
                    txtFname.Text = dt.Rows[0].Field<string>("Fname");
                    txtAdd.Text = dt.Rows[0].Field<string>("addrs1");
                    txtCNIC.Text = dt.Rows[0].Field<string>("NID");
                    dtDOB.Text = dt.Rows[0].Field<DateTime>("BDate").ToString();
                    dtDOJ.Text = dt.Rows[0].Field<DateTime>("JDate").ToString();

                    if (MessageBox.Show("Employee Already Exist ! Do You want to Edit ?", "Confirm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        cmdEdit.Enabled = true;
                        cmdSave.Enabled = true;
                        cmdCancel.Enabled = true;
                        cmdEdit.Focus();

                    }
                    else
                    {
                        clearData();
                        txtEmpID.Focus();
                    }

                }
                else
                {
                    if (MessageBox.Show("Employee Does Not Exist ! Do You want to Add ?", "Confirm",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        cmdEdit.Enabled = true;
                        cmdSave.Enabled = true;
                        comDept.Focus();

                    }
                    else
                    {
                        clearData();
                        txtEmpID.Focus();
                    }

                }

            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            comDept.Focus();
        }

        private void cmdEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comDept.Focus();
 
            }

        }
        private void clearData()
        {
            txtEmpID.Text = "";
            comDept.Text = "";
            comDesg.Text = "";
            txtName.Text = "";
            txtFname.Text = "";
            txtAdd.Text = "";
            txtCNIC.Text = "";
            dtDOB.Text = "";
            dtDOJ.Text = "";
 

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            cmdEdit.Enabled = false;
            cmdSave.Enabled = false;
            clearData();
            txtEmpID.Focus();
        }


        private void comDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
//                e.Handled = true;
                comDesg.Focus();
            }

        }

        private void comDesg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
//                e.Handled = true;
                txtName.Focus();
            }

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtFname.Focus();
            }
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtAdd.Focus();
            }
        }

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCNIC.Focus();
            }
        }

        private void txtCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtDOB.Focus();
            }
        }

        private void dtDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtDOJ.Focus();
            }
        }

        private void dtDOJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmdSave.Enabled = true;
                cmdEdit.Enabled = false;
                cmdSave.Focus();
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM PEMP WHERE Eno='" + txtEmpID.Text + "' and LOC='" + general.strLoc + "'";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count.ToString() == "1")
            {

                String sql1 = "update PEMP set Dept='" + comDept.Text + "', Post='" + comDesg.Text + "', EName='" + txtName.Text + "', Fname='" + txtFname.Text + "', addrs1='" + txtAdd.Text + "' , NID='" + txtCNIC.Text + "', BDate='" + dtDOB.Value.Date + "', JDate='" + dtDOJ.Value.Date + "'   WHERE Eno='" + txtEmpID.Text + "' and LOC='" + general.strLoc + "'";
                SqlCommand cmd = new SqlCommand(sql1, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Close();
            }
            else
            {
                String sql1 = "INSERT INTO PEMP (Eno, Dept, Post,EName,FName, addrs1,NID,BDate,JDate,LOC) values('" + txtEmpID.Text + "','" + comDept.Text + "', '" + comDesg.Text + "', '" + txtName.Text + "', '" + txtFname.Text + "', '" + txtAdd.Text + "' , '" + txtCNIC.Text + "', '" + dtDOB.Value.Date + "', '" + dtDOJ.Value.Date + "','" + general.strLoc + "')";
                SqlCommand cmd = new SqlCommand(sql1, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Close();
            
            }
            con.Close();
            MessageBox.Show("Data saved Succesfully");
            cmdSave.Enabled = false;
            cmdEdit.Enabled = false;
            clearData();
            txtEmpID.Focus();
            LoadGrid();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       


    
    }
}

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
    public partial class MyTemplate31 : Form
    {


        public MyTemplate31()
        {
            InitializeComponent();

        }



        SqlConnection con = new SqlConnection(general.conStr);
        string ProcCode;
        string EmpCode;
        string GroupCode;


        private void frmProd_Load(object sender, EventArgs e)
        {
            con.Open();
            clear();
            dtProd.Format = DateTimePickerFormat.Custom;
            dtProd.CustomFormat = "dd-MM-yyyy";
            dtProd.Value = DateTime.Today;

            fillProcess();
            fillEmployee();
            //            fillGroup();
            dtProd.Focus();
            cmdDelete.Enabled = false;

        }



        private void fillProcess()
        {
            string sql = "SELECT P_Code+'  '+P_Descrip as PName FROM PRD_PROCESS ORDER BY P_CODE";
            SqlCommand cmd = new SqlCommand(sql, con);
            //            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "PRD_PROCESS");

            comProc.DataSource = ds;
            comProc.DisplayMember = "PName";
            comProc.ValueMember = "PRD_PROCESS.PName";
            //            con.Close();
        }

        private void fillGroup()
        {
            comGroup.Text = "";
            string sql = "SELECT G_CODE+'  '+GROUP_ART as GroupName FROM PRD_GROUP  WHERE P_CODE='" + ProcCode + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            //            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "PRD_GROUP");

            comGroup.DataSource = ds;
            comGroup.DisplayMember = "GroupName";
            comGroup.ValueMember = "PRD_GROUP.GroupName";
            //            con.Close();

        }


        private void fillEmployee()
        {

            string sql = "SELECT Eno+'  '+Ename as Emp FROM PEMP";
            SqlCommand cmd = new SqlCommand(sql, con);
            //            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "PEMP");

            comEmpID.DataSource = ds;
            comEmpID.DisplayMember = "Emp";
            comEmpID.ValueMember = "PEMP.Emp";
            //            con.Close();

        }



        private void comProc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (comProc.Text.Length > 3)
                {
                    ProcCode = comProc.Text.Substring(0, 3);
                }
                else
                {
                    ProcCode = comProc.Text;
                }
                //                con.Open();
                String sql = "SELECT * FROM PRD_PROCESS WHERE P_code='" + ProcCode + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //                con.Close();
                if (dt.Rows.Count.ToString() == "1")
                {
                    comProc.Text = dt.Rows[0].Field<string>("P_Code") + "   " + dt.Rows[0].Field<string>("P_Descrip");
                    ProcCode = comProc.Text.Substring(0, 3);
                    fillGroup();
                    comGroup.Focus();

                }
                else
                {
                    MessageBox.Show("Invalid Process Code !");
                    comProc.Text = "";
                    comProc.Focus();

                }

            }
        }

        private void dtProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtShift.Focus();
            }
        }

        private void txtShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtShift.Text.ToUpper() == "A" || txtShift.Text.ToUpper() == "B" || txtShift.Text.ToUpper() == "C")
                {
                    comProc.Focus();

                }
                else
                {
                    MessageBox.Show("Invalid Shift ! Only A, B, C allowed");
                    txtShift.Text = "";
                    txtShift.Focus();

                }

            }

        }


        private void comEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (comEmpID.Text.Length > 6)
                {
                    EmpCode = comEmpID.Text.Substring(0, 6);
                }
                else
                {
                    EmpCode = comEmpID.Text;
                }
                //                con.Open();
                String sql = "SELECT * FROM PEMP WHERE eno ='" + EmpCode + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                //                con.Close();
                if (dt.Rows.Count.ToString() == "1")
                {
                    comEmpID.Text = dt.Rows[0].Field<string>("Eno") + "   " + dt.Rows[0].Field<string>("Ename");
                    EmpCode = comEmpID.Text.Substring(0, 6);

                    //                    con.Open();
                    String sql1 = "SELECT * FROM MKUPPROD WHERE ENO ='" + EmpCode + "' and DATE= '" + dtProd.Value.Date + "' and SHIFT= '" + txtShift.Text + "' and P_CODE= '" + ProcCode + "' and G_CODE= '" + GroupCode + "'  ";

                    SqlDataAdapter sda1 = new SqlDataAdapter(sql1, con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    //                    con.Close();
                    if (dt1.Rows.Count > 0)
                    {


                        if (MessageBox.Show("This Employee Production Already Exist ! Do You want to Edit ?", "Confirm",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {

                            txtProd.Text = dt1.Rows[0].Field<double>("PROD").ToString();
                            txtTime.Text = dt1.Rows[0].Field<double>("W_TIME").ToString();
                            txtProd.Focus();
                            cmdDelete.Enabled = true;

                        }
                        else
                        {
                            comEmpID.Focus();
                        }


                    }

                    txtProd.Focus();

                }
                else
                {
                    MessageBox.Show("Invalid Employee ID !");
                    comEmpID.Text = "";
                    comEmpID.Focus();

                }

            }


        }

        private void comProc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comProc.Text = comProc.SelectedValue.ToString();
            ProcCode = comProc.Text.Substring(0, 3);

        }

        private void comEmpID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comEmpID.Text = comEmpID.SelectedValue.ToString();
            EmpCode = comEmpID.Text.Substring(0, 6);

        }

        private void txtShift_TextChanged(object sender, EventArgs e)
        {
            txtShift.Text = txtShift.Text.ToUpper();
        }



        private void comProc_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (comProc.Text.Length > 3)
            {
                ProcCode = comProc.Text.Substring(0, 3);
            }
            else
            {
                ProcCode = comProc.Text;
            }



        }


        private void cmdSave_Click(object sender, EventArgs e)
        {

            save();
            clear();
            comProc.Focus();

        }

        private void clear()
        {
            comGroup.Text = "";
            comEmpID.Text = "";
            txtProd.Text = "";

        }

        private void save()
        {


            //           con.Open();
            String sqlM = "SELECT * FROM MKUPPROD WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "' and  G_CODE= '" + GroupCode + "'  ";
            SqlDataAdapter sdaM = new SqlDataAdapter(sqlM, con);
            DataTable dtM = new DataTable();
            sdaM.Fill(dtM);
            if (dtM.Rows.Count > 0)
            {
                String sql2 = "UPDATE MKUPPROD SET ENO ='" + EmpCode + "' , DATE= '" + dtProd.Value.Date + "' , SHIFT= '" + txtShift.Text + "' , P_CODE= '" + ProcCode + "', G_CODE= '" + GroupCode + "', W_TIME= '" + txtTime.Text + "',PROD='" + txtProd.Text + "'     WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "' and G_CODE= '" + GroupCode + "'   ";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
            }
            else
            {

                String sql = "INSERT INTO MKUPPROD (ENO,DATE,SHIFT, P_CODE, G_CODE,  W_TIME, PROD) values('" + EmpCode + "','" + dtProd.Value.Date + "','" + txtShift.Text + "', '" + ProcCode + "', '" + GroupCode + "', '" + txtTime.Text + "','" + txtProd.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

            }

            //            con.Close();

            MessageBox.Show("Data saved Succesfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }


        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmdSave.Focus();
            }
        }

        private void comGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (comGroup.Text.Length > 3)
                {
                    GroupCode = comGroup.Text.Substring(0, 1);
                }
                else
                {
                    GroupCode = comGroup.Text;
                }
                //                con.Open();
                String sql = "SELECT * FROM PRD_GROUP WHERE P_CODE='" + ProcCode + "'  and G_CODE='" + GroupCode + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //                con.Close();
                if (dt.Rows.Count.ToString() == "1")
                {
                    comGroup.Text = dt.Rows[0].Field<string>("G_CODE") + "   " + dt.Rows[0].Field<string>("GROUP_ART");
                    GroupCode = comGroup.Text.Substring(0, 1);
                    comEmpID.Focus();

                }
                else
                {
                    MessageBox.Show("Invalid Group Code !");
                    comGroup.Text = "";
                    comGroup.Focus();

                }

            }

        }

        private void txtProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtTime.Focus();
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to Delete ?", "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //                con.Open();
                String sql = "DELETE FROM MKUPPROD  WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "' and G_CODE= '" + GroupCode + "'   ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                //                con.Close();
                MessageBox.Show("Data Delete Succesfully");
                cmdDelete.Enabled = false;
                clear();
                comProc.Focus();

            }
            else
            {
                clear();
                comProc.Focus();
            }

        }

        private void comProc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comProc_SelectedValueChanged(object sender, EventArgs e)
        {
        }


    }
}





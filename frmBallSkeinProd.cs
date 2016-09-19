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
    public partial class frmBallSkeinProd : Form
    {


        public frmBallSkeinProd()
        {
            InitializeComponent();

        }



        SqlConnection con = new SqlConnection(general.conStr);
        string ProcCode;
        string EmpCode;


        private void frmProd_Load(object sender, EventArgs e)
        {
            con.Open();
            clear();
            dtProd.Format = DateTimePickerFormat.Custom;
            dtProd.CustomFormat = "dd-MM-yyyy";
            dtProd.Value = DateTime.Today;

            fillProcess();
            fillEmployee();
            dtProd.Focus();
            cmdDelete.Enabled = false;
            cmdSave.Enabled = false;

        }



        private void fillProcess()
        {
            string sql = "SELECT P_Code+'  '+P_Descrip as PName FROM PRD_PROCESS WHERE P_CODE IN ('006','007') ORDER BY P_CODE";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "PRD_PROCESS");

            comProc.DataSource = ds;
            comProc.DisplayMember = "PName";
            comProc.ValueMember = "PRD_PROCESS.PName";
        }



        private void fillEmployee()
        {

            string sql = "SELECT Eno+'  '+Ename as Emp FROM PEMP WHERE LOC='" + general.strLoc + "'";
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


        private void fillArticle()
        {
            string sql = "SELECT Art_No, P_Code from Article WHERE P_code='" + ProcCode + "' order by Art_No";
            SqlCommand cmd = new SqlCommand(sql, con);
//            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "Article");

            comArticle.DataSource = ds;
            comArticle.DisplayMember = "Article";
            comArticle.ValueMember = "Article.Art_No";
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
                    fillArticle();
                    comEmpID.Focus();

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
                    txtTime.Focus();

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
                    String sql1 = "SELECT P.ART_NO, P.TOTAL_PROD, P.W_TIME, ISNULL(P.MACHINE,0) AS MACHINE , ISNULL(S.SHADE,'') AS SHADE FROM PRODMAST P LEFT JOIN PRODSUB S ON P.ENO=S.ENO AND P.DATE=S.DATE AND P.SHIFT=S.SHIFT AND P.P_CODE=S.P_CODE AND P.LOC=S.LOC  WHERE P.ENO ='" + EmpCode + "' and P.DATE= '" + dtProd.Value.Date + "' and P.SHIFT= '" + txtShift.Text + "' and P.P_CODE= '" + ProcCode + "' AND P.LOC='" + general.strLoc + "'";

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
                            comArticle.Text = dt1.Rows[0].Field<string>("ART_NO").ToString();
                            txtProd.Text = dt1.Rows[0].Field<double>("TOTAL_PROD").ToString();
                            txtTime.Text = dt1.Rows[0].Field<double>("W_TIME").ToString();
                            txtMach.Text =  dt1.Rows[0].Field<string>("MACHINE").ToString();
                            txtShade.Text = dt1.Rows[0].Field<string>("SHADE").ToString();

                            txtProd.Focus();
                            cmdDelete.Enabled = true;

                        }
                        else
                        {
                            comEmpID.Focus();
                        }


                    }

                    txtMach.Focus();

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
            cmdSave.Enabled = false;
            cmdDelete.Enabled = false;


        }

        private void clear()
        {
            comEmpID.Text = "";
            txtProd.Text = "";
            txtWSP.Text = "";
            txtMach.Text = "";
            txtShade.Text = "";


        }

        private void save()
        {
            if (txtProd.Text == null || txtProd.Text.ToString() == String.Empty || Convert.ToDouble(txtProd.Text.ToString()) == 0)
            {
                MessageBox.Show("Must Enter Data before saving");
                clear();
                comProc.Focus();
                cmdSave.Enabled = false;
                cmdDelete.Enabled = false;
                return;
            }


            //           con.Open();
            String sqlM = "SELECT * FROM PRODMAST WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "' AND LOC='" + general.strLoc + "'  ";
            SqlDataAdapter sdaM = new SqlDataAdapter(sqlM, con);
            DataTable dtM = new DataTable();
            sdaM.Fill(dtM);
            if (dtM.Rows.Count > 0)
            {
                String sql2 = "UPDATE PRODMAST SET ART_NO='" + comArticle.Text + "', W_SP='" + txtWSP.Text + "',W_TIME= '" + txtTime.Text + "',TOTAL_PROD='" + txtProd.Text + "', MACHINE='" + txtMach.Text + "'   WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "'  AND LOC='" + general.strLoc + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
            }
            else
            {

                String sql = "INSERT INTO PRODMAST (ENO,DATE,SHIFT, P_CODE, ART_NO,CATEGORY, W_SP, W_TIME, TOTAL_PROD,MACHINE,LOC) values('" + EmpCode + "','" + dtProd.Value.Date + "','" + txtShift.Text + "', '" + ProcCode + "', '" + comArticle.Text + "', '" + 'F' + "', '" + txtWSP.Text + "', '" + txtTime.Text + "','" + txtProd.Text + "','" + txtMach.Text + "','" + general.strLoc + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

            }


            String sqlS = "SELECT * FROM PRODSUB WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "'  AND LOC='" + general.strLoc + "'  ";
            SqlDataAdapter sdaS = new SqlDataAdapter(sqlS, con);
            DataTable dtS = new DataTable();
            sdaS.Fill(dtS);
            if (dtS.Rows.Count > 0)
            {
                String sql2 = "UPDATE PRODSUB SET SHADE='" + txtShade.Text + "' WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "' AND LOC='" + general.strLoc + "' ";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
            }
            else
            {

                String sql = "INSERT INTO PRODSUB (ENO,DATE,SHIFT, P_CODE, ART_NO,SHADE, PART_PROD,MACHINE,LOC) values('" + EmpCode + "','" + dtProd.Value.Date + "','" + txtShift.Text + "', '" + ProcCode + "', '" + comArticle.Text + "', '" + txtShade.Text + "', '" + txtProd.Text + "','" + txtMach.Text + "','" + general.strLoc + "')";
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
                comProc.Focus();
            }
        }

        private void txtProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtProd.Text != null && txtProd.Text.ToString() != String.Empty && Convert.ToDouble(txtProd.Text.ToString()) > 0)
                {
                    cmdSave.Enabled = true;
                    cmdSave.Focus();
                }
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
                String sql = "DELETE FROM PRODMAST WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "'  AND LOC='" + general.strLoc + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                String sql1 = "DELETE FROM PRODSUB WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "'  AND LOC='" + general.strLoc + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comArticle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                String sql = "SELECT * FROM Article WHERE Art_No = '" + comArticle.Text + "' and P_Code='" + ProcCode + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
//                con.Close();
                if (dt.Rows.Count.ToString() == "1")
                {

                    txtWSP.Text = dt.Rows[0].Field<double>("Spindle").ToString();
                    txtShade.Focus();

                }
                else
                {
                    MessageBox.Show("Article Not found");
                    comArticle.Focus();


                }
            }
        }

        private void txtShade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtProd.Focus();
            }
        }

        private void txtMach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtMach.Text.ToString() != "")
                {
                    comArticle.Focus();
                    cmdSave.Enabled = true;
                    cmdDelete.Enabled = true;


                }
                else
                {
                    MessageBox.Show("Enter Machine No");
                    txtMach.Focus();
                }

             
            }

        }

        private void comArticle_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z))
            {
                comArticle.SelectedText = e.KeyCode.ToString().ToUpper();
                e.SuppressKeyPress = true;
            }
            return;

        }


    }
}





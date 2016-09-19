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
    public partial class frmArticle : Form
    {
        public frmArticle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(general.conStr);

        private void frmArticle_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadGrid();
            txtCat.Focus();
            
        }


        private void LoadGrid()
        {

           string sql = "select a.*, P.P_DESCRIP from ARTICLE  A LEFT JOIN PRD_PROCESS P ON A.P_CODE=P.P_CODE order by a.Art_No";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            DataTable tempDT = new DataTable();
            tempDT = dt.DefaultView.ToTable(true, "ART_NO", "NE", "P_DESCRIP","P_Code");
            dataGridView1.DataSource = tempDT;
            
             dataGridView1.Columns["Art_NO"].HeaderText= "Article";
             dataGridView1.Columns["NE"].HeaderText = "Count/Ply";
             dataGridView1.Columns["P_DESCRIP"].HeaderText = "Process";
             dataGridView1.Columns["P_DESCRIP"].Width= 250;
             dataGridView1.Columns["P_Code"].HeaderText = "Process Code";

             dataGridView1.Columns[0].ReadOnly = true;
             dataGridView1.Columns[1].ReadOnly = true;
             dataGridView1.Columns[2].ReadOnly = true;
             dataGridView1.Columns[3].ReadOnly = true;




        }

        private void clearData()
        {
            txtCat.Text = "";
            txtArt.Text = "";
            txtCount.Text = "";
            txtProc.Text = "";
            txtFin.Text = "";
            txtLen.Text = "";
            txtSpin.Text = "";
            txtFTar.Text = "";
            txtFRate.Text = "";
            txtSTar.Text = "";
            txtSRate.Text = "";
            txtKg.Text = "";
            txtCLU.Text = "";
            lblProc.Text = ""; 
        }
 

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string sql = "select A.*, P.P_DESCRIP from ARTICLE  A LEFT JOIN PRD_PROCESS P ON A.P_CODE=P.P_CODE  WHERE A.ART_NO='" + dr.Cells["Art_No"].Value + "'  and A.P_Code='" + dr.Cells["P_Code"].Value + "'";
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(sql, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count.ToString() == "1")
            {

                txtCat.Text = dt.Rows[0].Field<string>("Category");
                txtArt.Text = dt.Rows[0].Field<string>("Art_No");
                txtCount.Text = dt.Rows[0].Field<string>("NE");
                txtProc.Text = dt.Rows[0].Field<string>("P_Code");
                txtFin.Text = dt.Rows[0].Field<string>("Finish");
                txtLen.Text = dt.Rows[0].Field<double>("Length").ToString();
                txtSpin.Text = dt.Rows[0].Field<double>("Spindle").ToString();
                txtFTar.Text = dt.Rows[0].Field<double>("Target1").ToString();
                txtFRate.Text = dt.Rows[0].Field<double>("Rate1").ToString();
                txtSTar.Text = dt.Rows[0].Field<double>("Target2").ToString();
                txtSRate.Text = dt.Rows[0].Field<double>("Rate2").ToString();
                txtKg.Text = dt.Rows[0].Field<double>("KG").ToString();
                txtCLU.Text = dt.Rows[0].Field<double>("CLU").ToString();
                lblProc.Text = dt.Rows[0].Field<string>("P_DEscrip");

            }
            con.Close();

        }

        private void txtCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            { 
                if (txtCat.Text=="F")   
                {
                    txtArt.Focus();

                }
                else if (txtCat.Text == "P") 
                {
                    txtCount.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid Category");
                    txtCat.Text = "";
                    txtCat.Focus();

                }


            }

        }

        private void txtCat_TextChanged(object sender, EventArgs e)
        {
            txtCat.Text = txtCat.Text.ToUpper();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                string sql = "select A.*, P.P_DESCRIP from ARTICLE  A LEFT JOIN PRD_PROCESS P ON A.P_CODE=P.P_CODE  WHERE A.ART_NO='" + dr.Cells["Art_No"].Value + "'  and A.P_Code='" + dr.Cells["P_Code"].Value + "'";
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count.ToString() == "1")
                {

                    txtCat.Text = dt.Rows[0].Field<string>("Category");
                    txtArt.Text = dt.Rows[0].Field<string>("Art_No");
                    txtCount.Text = dt.Rows[0].Field<string>("NE");
                    txtProc.Text = dt.Rows[0].Field<string>("P_Code");
                    txtFin.Text = dt.Rows[0].Field<string>("Finish");
                    txtLen.Text = dt.Rows[0].Field<double>("Length").ToString();
                    txtSpin.Text = dt.Rows[0].Field<double>("Spindle").ToString();
                    txtFTar.Text = dt.Rows[0].Field<double>("Target1").ToString();
                    txtFRate.Text = dt.Rows[0].Field<double>("Rate1").ToString();
                    txtSTar.Text = dt.Rows[0].Field<double>("Target2").ToString();
                    txtSRate.Text = dt.Rows[0].Field<double>("Rate2").ToString();
                    txtKg.Text = dt.Rows[0].Field<double>("KG").ToString();
                    txtCLU.Text = dt.Rows[0].Field<double>("CLU").ToString();
                    lblProc.Text = dt.Rows[0].Field<string>("P_DEscrip");

                }
                con.Close();
            }

        }

        private void txtArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCount.Focus();
            }
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCat.Text == "P")
                {
                    txtArt.Text = txtCount.Text;
                }
                txtProc.Focus();
            }

        }

        private void txtProc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string sql = "select * from PRD_PROCESS WHERE P_Code='" + txtProc.Text + "'";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count.ToString() == "1")
                {
                    lblProc.Text = dt.Rows[0].Field<string>("P_DEscrip");

                    string sql1 = "select A.*, P.P_DESCRIP from ARTICLE  A LEFT JOIN PRD_PROCESS P ON A.P_CODE=P.P_CODE  WHERE A.ART_NO='" + txtArt.Text + "'  and A.P_Code='" + txtProc.Text + "'";
                    SqlDataAdapter sda1 = new SqlDataAdapter(sql1, con);

                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    if (dt1.Rows.Count.ToString() == "1")
                    {
                        txtCat.Text = dt1.Rows[0].Field<string>("Category");
                        txtArt.Text = dt1.Rows[0].Field<string>("Art_No");
                        txtCount.Text = dt1.Rows[0].Field<string>("NE");
                        txtProc.Text = dt1.Rows[0].Field<string>("P_Code");
                        txtFin.Text = dt1.Rows[0].Field<string>("Finish");
                        txtLen.Text = dt1.Rows[0].Field<double>("Length").ToString();
                        txtSpin.Text = dt1.Rows[0].Field<double>("Spindle").ToString();
                        txtFTar.Text = dt1.Rows[0].Field<double>("Target1").ToString();
                        txtFRate.Text = dt1.Rows[0].Field<double>("Rate1").ToString();
                        txtSTar.Text = dt1.Rows[0].Field<double>("Target2").ToString();
                        txtSRate.Text = dt1.Rows[0].Field<double>("Rate2").ToString();
                        txtKg.Text = dt1.Rows[0].Field<double>("KG").ToString();
                        txtCLU.Text = dt1.Rows[0].Field<double>("CLU").ToString();
                        lblProc.Text = dt1.Rows[0].Field<string>("P_DEscrip");

                        if (MessageBox.Show("Article Already Exist ! Do You want to Edit ?", "Confirm",
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
                            txtCat.Focus();
                        }

                    }
                    else
                    {
                        if (MessageBox.Show("Article Does Not Exist ! Do You want to Add ?", "Confirm",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            cmdEdit.Enabled = true;
                            cmdSave.Enabled = true;
                            txtFin.Focus();

                        }
                        else
                        {
                            clearData();
                            txtCat.Focus();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Invalid Process Code");
                    txtProc.Text = "";
                    txtProc.Focus();
                }

                con.Close();
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            txtFin.Focus();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            cmdEdit.Enabled = false;
            cmdSave.Enabled = false;
            clearData();
            txtCat.Focus();

        }

        private void txtFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtLen.Focus();
            }
        }

        private void txtLen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSpin.Focus();
            }
        }

        private void txtSpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtFTar.Focus();
            }
        }

        private void txtFTar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtFRate.Focus();
            }
        }

        private void txtFRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSTar.Focus();
            }

        }

        private void txtSTar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSRate.Focus();
            }

        }

        private void txtSRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtKg.Focus();
            }

        }

        private void txtKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCLU.Focus();
            }

        }

        private void txtCLU_KeyPress(object sender, KeyPressEventArgs e)
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
            string sql = "select * from ARTICLE  WHERE ART_NO='" + txtArt.Text + "'  and P_Code='" + txtProc.Text + "'";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count.ToString() == "1")
            {

                String sql1 = "update Article set category='" + txtCat.Text + "', NE='" + txtCount.Text + "', Finish='" + txtFin.Text + "', Length='" + txtLen.Text + "', Spindle='" + txtSpin.Text + "' , Target1='" + txtFTar.Text + "', Rate1='" + txtFRate.Text + "', Target2='" + txtSTar.Text + "', Rate2='" + txtSRate.Text + "', KG='" + txtKg.Text + "' , CLU='" + txtCLU.Text + "'   WHERE ART_NO='" + txtArt.Text + "'  and P_Code='" + txtProc.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql1, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Close();
            }
            else
            {
                String sql1 = "INSERT INTO Article (Art_no, P_Code, Category, NE,Finish,Length,Spindle,Target1,Rate1, Target2, Rate2, KG,CLU) values('" + txtArt.Text + "','" + txtProc.Text + "','" + txtCat.Text + "', '" + txtCount.Text + "', '" + txtFin.Text + "', '" + txtLen.Text + "', '" + txtSpin.Text + "' , '" + txtFTar.Text + "', '" + txtFRate.Text + "', '" + txtSTar.Text + "', '" + txtSRate.Text + "', '" + txtKg.Text + "' , '" + txtCLU.Text + "')";
                SqlCommand cmd = new SqlCommand(sql1, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Close();

            }

            MessageBox.Show("Data saved Succesfully");
            cmdSave.Enabled = false;
            cmdEdit.Enabled = false;
            con.Close();
            clearData();
            LoadGrid();
            txtCat.Focus();


        }

        private void txtCat_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z))
            {
                txtCat.SelectedText = e.KeyCode.ToString().ToUpper();
                e.SuppressKeyPress = true;
            }
            return;
        }

        private void txtArt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z))
            {
                txtArt.SelectedText = e.KeyCode.ToString().ToUpper();
                e.SuppressKeyPress = true;
            }
            return;
        }





    }
}




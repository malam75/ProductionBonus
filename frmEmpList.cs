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
    public partial class frmEmpList : Form
    {
        public frmEmpList()
        {
            InitializeComponent();
            FillData();
        }
        SqlConnection con = new SqlConnection(general.conStr);
        private void FillData()
        {

            string sql = "SELECT * FROM PEMP";
//            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt= new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            DataTable tempDT = new DataTable();
            tempDT=dt.DefaultView.ToTable(true,"Eno","Ename");

            dataGridView1.DataSource = tempDT;

        }


        private frmEmployee em = new frmEmployee();
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            em.txtEmpID.Text= row.Cells["Eno"].Value.ToString();
//            em.txtEmpID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
//            MessageBox.Show(row.Cells["Eno"].Value.ToString());
            this.Hide();
        }

        private void frmEmpList_Load(object sender, EventArgs e)
        {

        }

       }
}

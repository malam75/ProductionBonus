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

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace MainMenu
{
    public partial class OrderTracking : Form
    {
        public OrderTracking()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(general.conStr);
        string EmpCode;



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WMonthlyProdReport_Load(object sender, EventArgs e)
        {

            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "dd-MM-yyyy";
            dtFrom.Value = (DateTime.Today).AddDays(-90);

            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "dd-MM-yyyy";
            dtTo.Value = DateTime.Today;

            fillEmployee();
            comEmpID.Text = "";
         


        }


        private void fillEmployee()
        {

            string sql = "SELECT Eno+'  '+Ename as Emp FROM PEMP";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "PEMP");

            comEmpID.DataSource = ds;
            comEmpID.DisplayMember = "Emp";
            comEmpID.ValueMember = "PEMP.Emp";
            con.Close();

        }





        private void comEmpID_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
                con.Open();
                String sql = "SELECT * FROM PEMP WHERE eno ='" + EmpCode + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                if (dt.Rows.Count.ToString() == "1")
                {
                    comEmpID.Text = dt.Rows[0].Field<string>("Eno") + "   " + dt.Rows[0].Field<string>("Ename");
                    EmpCode = comEmpID.Text.Substring(0, 6);
                 
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID !");
                    comEmpID.Text = "";
                    comEmpID.Focus();

                }


            }




        }

        private void button1_Click(object sender, EventArgs e)
        {



            ReportDocument cryRpt = new ReportDocument();
            //            cryRpt.Load("D:\\Prod Bonus\\ProductionBonus\\rptWMonProd.rpt");
           
            cryRpt.Load(Application.StartupPath + "\\rptOrderTracking.rpt");
            cryRpt.SetDatabaseLogon("sa", "khuljasimsim");
            cryRpt.SetParameterValue("@FromDate", dtFrom.Value.Date);
            cryRpt.SetParameterValue("@ToDate", dtTo.Value.Date);
            cryRpt.SetParameterValue("@EmpID", comEmpID.Text);
            cryRpt.SetParameterValue("@DL", txtDL.Text);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

            comEmpID.Text = "";
            txtDL.Text = "";


        }

        private void dtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtTo.Focus();
            }

        }

        private void dtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comEmpID.Focus();
            }

        }

    

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1.Focus();
        }
    }
}

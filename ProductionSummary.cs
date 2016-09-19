using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace MainMenu
{
    public partial class ProductionSummary : Form
    {
        public ProductionSummary()
        {
            InitializeComponent();
        }

        private void ProductionSummary_Load(object sender, EventArgs e)
        {
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "dd-MM-yyyy";
            dtFrom.Value = DateTime.Today;

            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "dd-MM-yyyy";
            dtTo.Value = DateTime.Today;
            fillDept();



        }


        private void fillDept()
        {

            comDept.Items.Add("PreFinish/Finish Production");
            comDept.Items.Add("MakeUp Production");
            comDept.Items.Add("Combine (Finish and MakeUp Production");
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
                comDept.Focus();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
//            cryRpt.Load("D:\\Prod Bonus\\ProductionBonus\\rptProdSummary.rpt");
            if (comDept.SelectedIndex == 0)
            {
                cryRpt.Load(Application.StartupPath + "\\rptProdSummary.rpt");

            }
            else if (comDept.SelectedIndex == 1)
            {
                cryRpt.Load(Application.StartupPath + "\\rptMakeupProdSummary.rpt");

            }

            else 
            {
                cryRpt.Load(Application.StartupPath + "\\rptCombineProdSummary.rpt");

            }

            cryRpt.SetDatabaseLogon("sa", "khuljasimsim");
            cryRpt.SetParameterValue("@FromDate", dtFrom.Value.Date);
            cryRpt.SetParameterValue("@ToDate", dtTo.Value.Date);
          
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void comDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}

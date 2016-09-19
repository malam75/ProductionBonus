using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }



        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.Show();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticle frm = new frmArticle();
            frm.Show();


        }

        private void dailyProductionFinishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProd frm = new frmProd();
            frm.Show();
        }

        private void workersMonthlyProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMonthlyProdReport frm = new WMonthlyProdReport();
            frm.Show();

        }

        private void productionSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionSummary frm = new ProductionSummary();
            frm.Show();

        }

        private void dailyProductionPreFinishingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreFinish frm = new frmPreFinish();
            frm.Show();
        }

        private void makeupProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMakeUpProd frm = new frmMakeUpProd();
            frm.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBallSkeinProd frm = new frmBallSkeinProd();
            frm.Show();
        }

        private void productionOrderTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderTracking frm = new OrderTracking();
            frm.Show();

        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     
    }
}

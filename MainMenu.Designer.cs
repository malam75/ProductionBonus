namespace MainMenu
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyProductionFinishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyProductionPreFinishingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeupProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersMonthlyProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionOrderTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeInfoToolStripMenuItem,
            this.processToolStripMenuItem,
            this.articleToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // employeeInfoToolStripMenuItem
            // 
            this.employeeInfoToolStripMenuItem.Name = "employeeInfoToolStripMenuItem";
            this.employeeInfoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.employeeInfoToolStripMenuItem.Text = "Employee Info";
            this.employeeInfoToolStripMenuItem.Click += new System.EventHandler(this.employeeInfoToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // articleToolStripMenuItem
            // 
            this.articleToolStripMenuItem.Name = "articleToolStripMenuItem";
            this.articleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.articleToolStripMenuItem.Text = "Article";
            this.articleToolStripMenuItem.Click += new System.EventHandler(this.articleToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyProductionFinishToolStripMenuItem,
            this.toolStripMenuItem1,
            this.dailyProductionPreFinishingToolStripMenuItem,
            this.makeupProductionToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // dailyProductionFinishToolStripMenuItem
            // 
            this.dailyProductionFinishToolStripMenuItem.Name = "dailyProductionFinishToolStripMenuItem";
            this.dailyProductionFinishToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.dailyProductionFinishToolStripMenuItem.Text = "Daily Production - Finishing";
            this.dailyProductionFinishToolStripMenuItem.Click += new System.EventHandler(this.dailyProductionFinishToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.toolStripMenuItem1.Text = "Daily production - Ball/Skein";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dailyProductionPreFinishingToolStripMenuItem
            // 
            this.dailyProductionPreFinishingToolStripMenuItem.Name = "dailyProductionPreFinishingToolStripMenuItem";
            this.dailyProductionPreFinishingToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.dailyProductionPreFinishingToolStripMenuItem.Text = "Daily Production - PreFinishing";
            this.dailyProductionPreFinishingToolStripMenuItem.Click += new System.EventHandler(this.dailyProductionPreFinishingToolStripMenuItem_Click);
            // 
            // makeupProductionToolStripMenuItem
            // 
            this.makeupProductionToolStripMenuItem.Name = "makeupProductionToolStripMenuItem";
            this.makeupProductionToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.makeupProductionToolStripMenuItem.Text = "Makeup Production";
            this.makeupProductionToolStripMenuItem.Click += new System.EventHandler(this.makeupProductionToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workersMonthlyProductionToolStripMenuItem,
            this.productionSummaryToolStripMenuItem,
            this.productionOrderTrackingToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // workersMonthlyProductionToolStripMenuItem
            // 
            this.workersMonthlyProductionToolStripMenuItem.Name = "workersMonthlyProductionToolStripMenuItem";
            this.workersMonthlyProductionToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.workersMonthlyProductionToolStripMenuItem.Text = "Workers Monthly Production";
            this.workersMonthlyProductionToolStripMenuItem.Click += new System.EventHandler(this.workersMonthlyProductionToolStripMenuItem_Click);
            // 
            // productionSummaryToolStripMenuItem
            // 
            this.productionSummaryToolStripMenuItem.Name = "productionSummaryToolStripMenuItem";
            this.productionSummaryToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.productionSummaryToolStripMenuItem.Text = "Production Summary";
            this.productionSummaryToolStripMenuItem.Click += new System.EventHandler(this.productionSummaryToolStripMenuItem_Click);
            // 
            // productionOrderTrackingToolStripMenuItem
            // 
            this.productionOrderTrackingToolStripMenuItem.Name = "productionOrderTrackingToolStripMenuItem";
            this.productionOrderTrackingToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.productionOrderTrackingToolStripMenuItem.Text = "Production Order Tracking";
            this.productionOrderTrackingToolStripMenuItem.Click += new System.EventHandler(this.productionOrderTrackingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 290);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainMenu";
            this.Text = "Production Bonus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyProductionFinishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersMonthlyProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyProductionPreFinishingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeupProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productionOrderTrackingToolStripMenuItem;
    }
}
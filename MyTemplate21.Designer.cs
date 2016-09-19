namespace MainMenu
{
    partial class frmMakeUpProd
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
            this.components = new System.ComponentModel.Container();
            this.dtProd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comEmpID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMach = new System.Windows.Forms.TextBox();
            this.comProc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.cmdNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gv = new MyDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtProd
            // 
            this.dtProd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProd.Location = new System.Drawing.Point(135, 12);
            this.dtProd.Name = "dtProd";
            this.dtProd.Size = new System.Drawing.Size(93, 20);
            this.dtProd.TabIndex = 1;
            this.dtProd.Value = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            this.dtProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtProd_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Prod Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Shift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Process Code";
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(337, 12);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(36, 20);
            this.txtShift.TabIndex = 2;
            this.txtShift.TabStop = false;
            this.txtShift.TextChanged += new System.EventHandler(this.txtShift_TextChanged);
            this.txtShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShift_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Employee ID";
            // 
            // comEmpID
            // 
            this.comEmpID.FormattingEnabled = true;
            this.comEmpID.Location = new System.Drawing.Point(134, 67);
            this.comEmpID.Name = "comEmpID";
            this.comEmpID.Size = new System.Drawing.Size(238, 21);
            this.comEmpID.TabIndex = 4;
            this.comEmpID.TabStop = false;
            this.comEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comEmpID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Machine No";
            // 
            // txtMach
            // 
            this.txtMach.Location = new System.Drawing.Point(135, 94);
            this.txtMach.Name = "txtMach";
            this.txtMach.Size = new System.Drawing.Size(36, 20);
            this.txtMach.TabIndex = 5;
            this.txtMach.TabStop = false;
            this.txtMach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMach_KeyDown);
            this.txtMach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMach_KeyPress);
            // 
            // comProc
            // 
            this.comProc.FormattingEnabled = true;
            this.comProc.Location = new System.Drawing.Point(135, 40);
            this.comProc.Name = "comProc";
            this.comProc.Size = new System.Drawing.Size(237, 21);
            this.comProc.TabIndex = 3;
            this.comProc.TabStop = false;
            this.comProc.SelectionChangeCommitted += new System.EventHandler(this.comProc_SelectionChangeCommitted_1);
            this.comProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comProc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Working Hour";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(541, 12);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(38, 20);
            this.txtTime.TabIndex = 6;
            this.txtTime.TabStop = false;
            this.txtTime.Text = "7.5";
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Total Kgs";
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(127, 417);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(51, 20);
            this.txtTot.TabIndex = 39;
            this.txtTot.TabStop = false;
            // 
            // cmdNext
            // 
            this.cmdNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNext.Location = new System.Drawing.Point(226, 408);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(146, 36);
            this.cmdNext.TabIndex = 40;
            this.cmdNext.TabStop = false;
            this.cmdNext.Text = "Save/Next Employee";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(392, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 41;
            this.button1.TabStop = false;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(436, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.TabStop = false;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(2, 131);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(619, 261);
            this.gv.TabIndex = 43;
            this.gv.TabStop = false;
            this.gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            this.gv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellEndEdit);
            this.gv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellEnter);
            this.gv.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.gv_CellStateChanged);
            this.gv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gv_EditingControlShowing);
            this.gv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_KeyDown);
            this.gv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gv_KeyPress);
            this.gv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gv_MouseClick);
            // 
            // frmMakeUpProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 464);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comProc);
            this.Controls.Add(this.txtMach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comEmpID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtProd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMakeUpProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Production - PreFinishing";
            this.Load += new System.EventHandler(this.frmProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.DateTimePicker dtProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comEmpID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMach;
        private System.Windows.Forms.ComboBox comProc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MyDataGridView gv;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}
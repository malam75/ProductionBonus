namespace MainMenu
{
    partial class MyTemplate31
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
            this.comProc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(11, 50);
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
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Employee ID";
            // 
            // comEmpID
            // 
            this.comEmpID.FormattingEnabled = true;
            this.comEmpID.Location = new System.Drawing.Point(134, 131);
            this.comEmpID.Name = "comEmpID";
            this.comEmpID.Size = new System.Drawing.Size(238, 21);
            this.comEmpID.TabIndex = 5;
            this.comEmpID.TabStop = false;
            this.comEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comEmpID_KeyPress);
            // 
            // comProc
            // 
            this.comProc.FormattingEnabled = true;
            this.comProc.Location = new System.Drawing.Point(135, 50);
            this.comProc.Name = "comProc";
            this.comProc.Size = new System.Drawing.Size(237, 21);
            this.comProc.TabIndex = 3;
            this.comProc.TabStop = false;
            this.comProc.SelectedIndexChanged += new System.EventHandler(this.comProc_SelectedIndexChanged);
            this.comProc.SelectionChangeCommitted += new System.EventHandler(this.comProc_SelectionChangeCommitted_1);
            this.comProc.SelectedValueChanged += new System.EventHandler(this.comProc_SelectedValueChanged);
            this.comProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comProc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Working Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(334, 186);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(38, 20);
            this.txtTime.TabIndex = 7;
            this.txtTime.TabStop = false;
            this.txtTime.Text = "8";
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Total Production";
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(134, 185);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(51, 20);
            this.txtProd.TabIndex = 6;
            this.txtProd.TabStop = false;
            this.txtProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProd_KeyPress);
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(17, 245);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 23);
            this.cmdSave.TabIndex = 8;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comGroup
            // 
            this.comGroup.FormattingEnabled = true;
            this.comGroup.Location = new System.Drawing.Point(135, 88);
            this.comGroup.Name = "comGroup";
            this.comGroup.Size = new System.Drawing.Size(237, 21);
            this.comGroup.TabIndex = 4;
            this.comGroup.TabStop = false;
            this.comGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comGroup_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Group Code";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(149, 245);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(100, 23);
            this.cmdDelete.TabIndex = 10;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // MyTemplate31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 318);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.comGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comProc);
            this.Controls.Add(this.comEmpID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtProd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyTemplate31";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Makeup Production";
            this.Load += new System.EventHandler(this.frmProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.ComboBox comProc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdDelete;

    }
}
namespace MainMenu
{
    partial class frmEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comDept = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comDesg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.dtDOJ = new System.Windows.Forms.DateTimePicker();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(139, 22);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(89, 20);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpID_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 201);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // comDept
            // 
            this.comDept.AllowDrop = true;
            this.comDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDept.FormattingEnabled = true;
            this.comDept.Location = new System.Drawing.Point(459, 17);
            this.comDept.Name = "comDept";
            this.comDept.Size = new System.Drawing.Size(121, 21);
            this.comDept.TabIndex = 3;
            this.comDept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comDept_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department";
            // 
            // comDesg
            // 
            this.comDesg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDesg.FormattingEnabled = true;
            this.comDesg.Location = new System.Drawing.Point(460, 44);
            this.comDesg.Name = "comDesg";
            this.comDesg.Size = new System.Drawing.Size(120, 21);
            this.comDesg.TabIndex = 5;
            this.comDesg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comDesg_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Father\'s Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "CNIC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Date of Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(359, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Date of Join";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 13;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(139, 96);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(197, 20);
            this.txtFname.TabIndex = 14;
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(139, 126);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(438, 20);
            this.txtAdd.TabIndex = 15;
            this.txtAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd_KeyPress);
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(139, 156);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(197, 20);
            this.txtCNIC.TabIndex = 16;
            this.txtCNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNIC_KeyPress);
            // 
            // dtDOB
            // 
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOB.Location = new System.Drawing.Point(139, 187);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(93, 20);
            this.dtDOB.TabIndex = 17;
            this.dtDOB.Value = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            this.dtDOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtDOB_KeyPress);
            // 
            // dtDOJ
            // 
            this.dtDOJ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOJ.Location = new System.Drawing.Point(460, 189);
            this.dtDOJ.Name = "dtDOJ";
            this.dtDOJ.Size = new System.Drawing.Size(92, 20);
            this.dtDOJ.TabIndex = 18;
            this.dtDOJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtDOJ_KeyPress);
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(139, 233);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(88, 25);
            this.cmdSave.TabIndex = 19;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Location = new System.Drawing.Point(257, 233);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(88, 25);
            this.cmdEdit.TabIndex = 20;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            this.cmdEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdEdit_KeyPress);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(374, 233);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 25);
            this.cmdCancel.TabIndex = 21;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 466);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.dtDOJ);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comDesg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comDept);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comDesg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.DateTimePicker dtDOJ;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdCancel;
        public System.Windows.Forms.TextBox txtEmpID;

      
    }
  
}
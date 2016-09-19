namespace MainMenu
{
    partial class frmArticle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtProc = new System.Windows.Forms.TextBox();
            this.lblProc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtLen = new System.Windows.Forms.TextBox();
            this.txtSpin = new System.Windows.Forms.TextBox();
            this.txtFTar = new System.Windows.Forms.TextBox();
            this.txtFRate = new System.Windows.Forms.TextBox();
            this.txtSTar = new System.Windows.Forms.TextBox();
            this.txtSRate = new System.Windows.Forms.TextBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.txtCLU = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category [P/F]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Article No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Count/Ply";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Process Code";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(137, 10);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(28, 20);
            this.txtCat.TabIndex = 1;
            this.txtCat.TextChanged += new System.EventHandler(this.txtCat_TextChanged);
            this.txtCat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCat_KeyDown);
            this.txtCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCat_KeyPress);
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(137, 40);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(128, 20);
            this.txtArt.TabIndex = 2;
            this.txtArt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArt_KeyDown);
            this.txtArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArt_KeyPress);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(450, 40);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(130, 20);
            this.txtCount.TabIndex = 3;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // txtProc
            // 
            this.txtProc.Location = new System.Drawing.Point(137, 70);
            this.txtProc.Name = "txtProc";
            this.txtProc.Size = new System.Drawing.Size(40, 20);
            this.txtProc.TabIndex = 4;
            this.txtProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProc_KeyPress);
            // 
            // lblProc
            // 
            this.lblProc.AutoSize = true;
            this.lblProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProc.Location = new System.Drawing.Point(193, 71);
            this.lblProc.Name = "lblProc";
            this.lblProc.Size = new System.Drawing.Size(0, 16);
            this.lblProc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Finish";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Length";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Spindle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "First Target";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(320, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "First Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Second Target";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(320, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Second Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kg.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(320, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "CLU";
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(137, 120);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(79, 20);
            this.txtFin.TabIndex = 5;
            this.txtFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFin_KeyPress);
            // 
            // txtLen
            // 
            this.txtLen.Location = new System.Drawing.Point(450, 120);
            this.txtLen.Name = "txtLen";
            this.txtLen.Size = new System.Drawing.Size(81, 20);
            this.txtLen.TabIndex = 6;
            this.txtLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLen_KeyPress);
            // 
            // txtSpin
            // 
            this.txtSpin.Location = new System.Drawing.Point(137, 150);
            this.txtSpin.Name = "txtSpin";
            this.txtSpin.Size = new System.Drawing.Size(79, 20);
            this.txtSpin.TabIndex = 7;
            this.txtSpin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpin_KeyPress);
            // 
            // txtFTar
            // 
            this.txtFTar.Location = new System.Drawing.Point(137, 180);
            this.txtFTar.Name = "txtFTar";
            this.txtFTar.Size = new System.Drawing.Size(79, 20);
            this.txtFTar.TabIndex = 8;
            this.txtFTar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFTar_KeyPress);
            // 
            // txtFRate
            // 
            this.txtFRate.Location = new System.Drawing.Point(450, 180);
            this.txtFRate.Name = "txtFRate";
            this.txtFRate.Size = new System.Drawing.Size(81, 20);
            this.txtFRate.TabIndex = 9;
            this.txtFRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFRate_KeyPress);
            // 
            // txtSTar
            // 
            this.txtSTar.Location = new System.Drawing.Point(138, 210);
            this.txtSTar.Name = "txtSTar";
            this.txtSTar.Size = new System.Drawing.Size(78, 20);
            this.txtSTar.TabIndex = 10;
            this.txtSTar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSTar_KeyPress);
            // 
            // txtSRate
            // 
            this.txtSRate.Location = new System.Drawing.Point(450, 210);
            this.txtSRate.Name = "txtSRate";
            this.txtSRate.Size = new System.Drawing.Size(81, 20);
            this.txtSRate.TabIndex = 11;
            this.txtSRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSRate_KeyPress);
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(138, 240);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(78, 20);
            this.txtKg.TabIndex = 12;
            this.txtKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKg_KeyPress);
            // 
            // txtCLU
            // 
            this.txtCLU.Location = new System.Drawing.Point(450, 240);
            this.txtCLU.Name = "txtCLU";
            this.txtCLU.Size = new System.Drawing.Size(81, 20);
            this.txtCLU.TabIndex = 13;
            this.txtCLU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCLU_KeyPress);
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(137, 283);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(88, 25);
            this.cmdSave.TabIndex = 20;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(363, 283);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 25);
            this.cmdCancel.TabIndex = 23;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Location = new System.Drawing.Point(254, 283);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(88, 25);
            this.cmdEdit.TabIndex = 22;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // frmArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 466);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtCLU);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.txtSRate);
            this.Controls.Add(this.txtSTar);
            this.Controls.Add(this.txtFRate);
            this.Controls.Add(this.txtFTar);
            this.Controls.Add(this.txtSpin);
            this.Controls.Add(this.txtLen);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProc);
            this.Controls.Add(this.txtProc);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Article Entry";
            this.Load += new System.EventHandler(this.frmArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtProc;
        private System.Windows.Forms.Label lblProc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtLen;
        private System.Windows.Forms.TextBox txtSpin;
        private System.Windows.Forms.TextBox txtFTar;
        private System.Windows.Forms.TextBox txtFRate;
        private System.Windows.Forms.TextBox txtSTar;
        private System.Windows.Forms.TextBox txtSRate;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.TextBox txtCLU;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdEdit;
    }
}
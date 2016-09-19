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
    public partial class frmPreFinish : Form
    {


        public frmPreFinish()
        {
            InitializeComponent();

        }



        SqlConnection con = new SqlConnection(general.conStr);
        bool ConeEdit = false;
        string ProcCode;
        string EmpCode;
        static double T_KG= 0;
        static string[,] arrayArt = new string[50, 4];
        static string[,] arrayItem = new string[50, 4];

        private void frmProd_Load(object sender, EventArgs e)
        {

            clear();
            gv.AllowUserToAddRows = false;
            dtProd.Format = DateTimePickerFormat.Custom;
            dtProd.CustomFormat = "dd-MM-yyyy";
            dtProd.Value = DateTime.Today;
            cmdNext.Enabled = false;


            fillProcess();
            fillEmployee();
            FormatGrid();
            comboBox1.Visible = false;
            dtProd.Focus();



        }

        private void FormatGrid()
        {
            gv.MultiSelect = false;
            gv.ColumnCount = 7;
            gv.RowCount = 50;
            gv.Columns[0].Width = 90;
            gv.Columns[1].Width = 90;
            gv.Columns[2].Width = 90;
            gv.Columns[3].Width = 90;
            gv.Columns[4].Width = 1;
            gv.Columns[5].Width = 90;
            gv.Columns[6].Width = 90;
            gv.Columns[0].HeaderText = "DRUGLINE";
            gv.Columns[1].HeaderText = "COUNT";
            gv.Columns[2].HeaderText = "W.SPINDLE";
            gv.Columns[3].HeaderText = "SHADE";
            gv.Columns[4].HeaderText = "";
            gv.Columns[4].Visible = false;
           
            gv.Columns[5].HeaderText = "KG";
            gv.Columns[6].HeaderText = "TIME(HR)";
            gv.Columns[6].DefaultCellStyle.Format = "0.0#";
          


            gv.Columns[2].ReadOnly = true;
            gv.Columns[4].ReadOnly = true;
            gv.Columns[6].ReadOnly = true;

            RowNum();

        }

        private void RowNum()
        {
            int rowNumber = 1;
            foreach (DataGridViewRow row in gv.Rows)
            {
                if (row.IsNewRow) continue;
                row.HeaderCell.Value = " " + rowNumber;
                rowNumber = rowNumber + 1;
            }
            gv.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void fillProcess()
        {
            string sql = "SELECT P_Code+'  '+P_Descrip as PName FROM PRD_PROCESS where CATEGORY='P' AND P_CODE NOT IN ('006','007','008') ORDER BY P_CODE";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "PRD_PROCESS");

            comProc.DataSource = ds;
            comProc.DisplayMember = "PName";
            comProc.ValueMember = "PRD_PROCESS.PName";
            con.Close();
        }

        private void fillEmployee()
        {

            string sql = "SELECT Eno+'  '+Ename as Emp FROM PEMP WHERE LOC='" + general.strLoc + "'";
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

        private void fillArtCombo()
        {
            string sql = "SELECT NE, P_Code from Article WHERE P_code='" + ProcCode + "' and Category='P' order by NE";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adp.Fill(ds, "Article");

            comboBox1.DataSource = ds;
            comboBox1.DisplayMember = "Article";
            comboBox1.ValueMember = "Article.NE";
            con.Close();
        }


        private void comProc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (comProc.Text.Length > 3)
                {
                    ProcCode = comProc.Text.Substring(0, 3);
                }
                else
                {
                    ProcCode = comProc.Text;
                }
                con.Open();
                String sql = "SELECT * FROM PRD_PROCESS WHERE P_code='" + ProcCode + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                if (dt.Rows.Count.ToString() == "1")
                {
                    comProc.Text = dt.Rows[0].Field<string>("P_Code") + "   " + dt.Rows[0].Field<string>("P_Descrip");
                    ProcCode = comProc.Text.Substring(0, 3);
                    comEmpID.Focus();
                    fillArtCombo();

                }
                else
                {
                    MessageBox.Show("Invalid Process Code !");
                    comProc.Text = "";
                    comProc.Focus();

                }

            }
        }

        private void dtProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtShift.Focus();
            }
        }

        private void txtShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtShift.Text.ToUpper() == "A" || txtShift.Text.ToUpper() == "B" || txtShift.Text.ToUpper() == "C")
                {
                    txtTime.Focus();

                }
                else
                {
                    MessageBox.Show("Invalid Shift ! Only A, B, C allowed");
                    txtShift.Text = "";
                    txtShift.Focus();

                }

            }

        }


        private void comEmpID_KeyPress(object sender, KeyPressEventArgs e)
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
                    txtMach.Focus();

                }
                else
                {
                    MessageBox.Show("Invalid Employee ID !");
                    comEmpID.Text = "";
                    comEmpID.Focus();

                }
                con.Open();
                String sql1 = "SELECT S.DL,S.ART_NO AS COUNT,  M.W_SP, S.SHADE, S.PART_PROD AS KG , M.MACHINE FROM PRODMAST M " +
                              "LEFT JOIN PRODSUB S ON M.ENO =S.ENO AND M.DATE=S.DATE AND M.SHIFT=S.SHIFT AND M.ART_NO=S.ART_NO AND M.LOC=S.LOC " +
                              "LEFT JOIN ARTICLE A ON M.ART_NO=A.ART_NO AND M.P_CODE=A.P_CODE " +
                              "WHERE M.ENO ='" + EmpCode + "' and M.DATE= '" + dtProd.Value.Date + "' and M.SHIFT= '" + txtShift.Text + "' and M.P_CODE= '" + ProcCode + "' AND S.LOC='" + general.strLoc + "' ORDER BY S.ID";

                SqlDataAdapter sda1 = new SqlDataAdapter(sql1, con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                con.Close();
                if (dt1.Rows.Count > 0)
                {


                    if (MessageBox.Show("This Employee Production Already Exist ! Do You want to Edit ?", "Confirm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        clear();
                        FormatGrid();
                        comboBox1.Text = dt1.Rows[0].Field<string>("COUNT");
                        txtMach.Text = dt1.Rows[0].Field<string>("MACHINE");
                        cmdNext.Enabled = true;

                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            (gv.Rows[i].Cells[0]).Value = dt1.Rows[i].Field<string>("DL"); ;
                            (gv.Rows[i].Cells[1]).Value = dt1.Rows[i].Field<string>("COUNT"); ;
                            (gv.Rows[i].Cells[2]).Value = dt1.Rows[i].Field<double>("W_SP"); ;
                            (gv.Rows[i].Cells[3]).Value = dt1.Rows[i].Field<string>("SHADE"); ;
                            (gv.Rows[i].Cells[5]).Value = dt1.Rows[i].Field<double>("KG"); ;

                        }
                        cal();
                        gv.Focus();
                        gv.CurrentCell = gv[0, 0];
                        gv.Rows[0].Cells[0].Selected = true;
                        gv.BeginEdit(true);

                        dtProd.TabStop = false;

                        dtProd.Enabled = false;
                        txtShift.Enabled = false;
                        txtTime.Enabled = false;
                        comProc.Enabled = false;
                        comEmpID.Enabled = false;
                        txtMach.Enabled = false;



                    }
                    else
                    {
                        comEmpID.Focus();
                    }


                }


            }

        }

        private void comProc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comProc.Text = comProc.SelectedValue.ToString();
            ProcCode = comProc.Text.Substring(0, 3);

        }

        private void comEmpID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comEmpID.Text = comEmpID.SelectedValue.ToString();
            EmpCode = comEmpID.Text.Substring(0, 6);

        }

        private void txtShift_TextChanged(object sender, EventArgs e)
        {
            txtShift.Text = txtShift.Text.ToUpper();
        }




        private void txtMach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtMach.Text.ToString() != "")
                {
                    gv.Focus();
                    gv.CurrentCell = gv[0, 0];
                    gv.Rows[0].Cells[0].Selected = true;
                    gv.BeginEdit(true);

                    dtProd.TabStop = false;

                    dtProd.Enabled = false;
                    txtShift.Enabled = false;
                    txtTime.Enabled = false;
                    comProc.Enabled = false;
                    comEmpID.Enabled = false;
                    txtMach.Enabled = false;
                    cmdNext.Enabled = true;


                }
                else
                {
                    MessageBox.Show("Enter Machine No");
                    txtMach.Focus();
                }

            }
        }


        private void Show_Combobox(int iRowIndex, int iColumnIndex)
        {

            int x = 0;
            int y = 0;
            int Width = 0;
            int height = 0;

            // GET THE ACTIVE CELL'S DIMENTIONS TO BIND THE COMBOBOX WITH IT.
            Rectangle rect = default(Rectangle);
            rect = gv.GetCellDisplayRectangle(iColumnIndex, iRowIndex, false);
            x = rect.X + gv.Left;
            y = rect.Y + gv.Top;

            Width = rect.Width;
            height = rect.Height;

            comboBox1.SetBounds(x, y, Width, height);
            comboBox1.Visible = true;
            comboBox1.Focus();
        }



        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int col = gv.CurrentCell.ColumnIndex;
                int row = gv.CurrentCell.RowIndex;


                (gv.Rows[row].Cells[1]).Value = comboBox1.Text;

                con.Open();
                String sql = "SELECT * FROM Article WHERE NE = '" + comboBox1.Text + "' and P_Code='" + ProcCode + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                if (dt.Rows.Count.ToString() == "1")
                {

                    comboBox1.Visible = false;

                    (gv.Rows[row].Cells[2]).Value = dt.Rows[0].Field<double>("Spindle");

                    gv.Focus();
                    gv.CurrentCell = gv[3, row];
                    gv.BeginEdit(true);

                    return;

                }
                else
                {
                    MessageBox.Show("Article Not found");
                    comboBox1.Visible = true;
                    Show_Combobox(row, 1);
                    gv.Focus();
                    gv.Rows[row].Cells[1].Selected = true;
                    gv.CurrentCell = gv[1, row];
                    comboBox1.Focus();


                }

            }

        }


        private void gv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int col = gv.CurrentCell.ColumnIndex;
            int row = gv.CurrentCell.RowIndex;

            if (col == 1)
            {
                if (gv[1, row].Value != null)
                {
                    comboBox1.Text = gv[1, row].Value.ToString();

                }
                comboBox1.Visible = true;
                Show_Combobox(row, 1);

            }






        }

        private void gv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int col = gv.CurrentCell.ColumnIndex;
            int row = gv.CurrentCell.RowIndex;


            ConeEdit = false;

            switch (col)
            {
                case 0:
                    col = 1;
                    break;
                case 1:
                    col = 3;
                    break;
                case 3:
                    col = 5;
                    break;
                case 5:
                    if (gv[5, row].Value != null && gv[5, row].Value.ToString() != String.Empty && Convert.ToDouble(((gv.Rows[row].Cells[5]).Value).ToString()) > 0)
                    {
                        cal();
                        ConeEdit = true;
                        col = 0;
                        row++;
                    }
                    else
                    {
                        if (gv[5, row].Value == null)
                        {
                            MessageBox.Show("Enter KG");
                            col = 4;
                        }

                    }
                    break;

                default:
                    break;

            }

            if (col != 5)
            {
                gv.Focus();
                gv.CurrentCell = gv.Rows[row].Cells[col];
                gv.Rows[row].Cells[col].Selected = true;
            }


        }


        private void comProc_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (comProc.Text.Length > 3)
            {
                ProcCode = comProc.Text.Substring(0, 3);
            }
            else
            {
                ProcCode = comProc.Text;
            }

        }



        private void gv_KeyDown(object sender, KeyEventArgs e)
        {

            int col = gv.CurrentCell.ColumnIndex;
            int row = gv.CurrentCell.RowIndex;

            switch (col)
            {
                case 0:
                    col = 1;
                    break;
                case 1:
                    col = 3;
                    break;
                case 3:
                    col = 5;
                    break;
                case 5:
                    if (gv[5, row].Value != null && gv[5, row].Value.ToString() != String.Empty && Convert.ToDouble(((gv.Rows[row].Cells[5]).Value).ToString()) > 0)

                    {
                        if (ConeEdit == false)
                        {
                            cal();
                        }
                        col = 0;
                        row++;

                    }
                    else
                    {
                        if ((gv.Rows[row].Cells[5]).Value == null)
                        {
                            MessageBox.Show("Enter KG");
                            col = 3;
                        }
                    }
                    break;

                default:
                    break;

            }


            gv.Focus();
            gv.CurrentCell = gv[col, row];
            gv.Rows[row].Cells[col].Selected = true;

        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            save();
            clear();
            FormatGrid();
            fillEmployee();
            comboBox1.Visible = false;
            comEmpID.Focus();


        }

        private void clear()
        {
            gv.Rows.Clear();
            gv.Columns.Clear();
            txtMach.Text = "";
            txtTot.Text = "";

        }

        private void save()
        {
            if (gv[5, 1].Value == null )
            {
                MessageBox.Show("Must Input Data before saving");
                TextEnable();
                comEmpID.Focus();
                return;
 
            }



            string ArtNo = "";
            string ArtNew = "";
            double KGS = 0;
            double time = 0;
            double WSP = 0;

            int j = 0;
            int k = 0;

            for (int i = 0; i < gv.Rows.Count; i++)
            {

                if (gv[5, i].Value != null && gv[5, i].Value.ToString() != String.Empty)
                {
                    arrayItem[k, 1] = ((gv.Rows[i].Cells[1]).Value).ToString();
                    arrayItem[k, 3] = ((gv.Rows[i].Cells[5]).Value).ToString();

                    if (gv[0, i].Value != null && gv[0, i].Value.ToString() != String.Empty)
                    {
                        arrayItem[k, 0] = ((gv.Rows[i].Cells[0]).Value).ToString();

                    }
                    else
                    {
                        arrayItem[k, 0] = "";
                    }

                    if (gv[3, i].Value != null && gv[3, i].Value.ToString() != String.Empty)
                    {
                        arrayItem[k, 2] = ((gv.Rows[i].Cells[3]).Value).ToString();

                    }
                    else
                    {
                        arrayItem[k, 2] = "";
                    }
                    k = k + 1;
                }


                if (gv[1, i + 1].Value != null && gv[1, i + 1].Value.ToString() != String.Empty)
                {
                    ArtNew = ((gv.Rows[i + 1].Cells[1]).Value).ToString();


                }

                if (String.IsNullOrEmpty(gv.Rows[i].Cells[1].Value as String))
                {
                    arrayArt[j, 0] = ArtNo;
                    arrayArt[j, 1] = KGS.ToString();
                    arrayArt[j, 2] = time.ToString();
                    arrayArt[j, 3] = WSP.ToString();
                    j = j + 1;

                    break;
                }
                else
                {
                    ArtNo = ((gv.Rows[i].Cells[1]).Value).ToString();

                    string val = gv.Rows[i].Cells[5].FormattedValue as string;
                    if (string.IsNullOrEmpty(val) == false)
                    {
                        KGS= KGS+ Convert.ToDouble(((gv.Rows[i].Cells[5]).Value).ToString());
                        time = time + Convert.ToDouble(((gv.Rows[i].Cells[6]).Value).ToString());
                    }
                    WSP = Convert.ToDouble(((gv.Rows[i].Cells[2]).Value).ToString());


                }


                if (ArtNo != ArtNew)
                {
                    arrayArt[j, 0] = ArtNo;
                    arrayArt[j, 1] = KGS.ToString();
                    arrayArt[j, 2] = time.ToString();
                    arrayArt[j, 3] = WSP.ToString();

                    j = j + 1;
                    KGS= 0;
                    time = 0;
                    WSP = 0;

                }

            }



            con.Open();
            String sqlM = "SELECT * FROM PRODMAST WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "' AND LOC='" + general.strLoc + "'  ";
            SqlDataAdapter sdaM = new SqlDataAdapter(sqlM, con);
            DataTable dtM = new DataTable();
            sdaM.Fill(dtM);
            if (dtM.Rows.Count > 0)
            {
                String sql2 = "DELETE FROM PRODMAST WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "'  AND LOC='" + general.strLoc + "' ";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
            }

            int aLen = (arrayArt.GetLength(0)) / 4;

            for (int x = 0; x <= aLen; x++)
            {

                if (Convert.ToDouble(arrayArt[x, 1]) != 0)
                {
                    String sql = "INSERT INTO PRODMAST (ENO,DATE,SHIFT, P_CODE, CATEGORY, ART_NO,  TOTAL_PROD,  W_TIME, W_SP, MACHINE,LOC) " +
                                 "values('" + EmpCode + "','" + dtProd.Value.Date + "','" + txtShift.Text + "', '" + ProcCode + "', '" + 'P' + "'," +
                                 " '" + arrayArt[x, 0] + "', '" + Convert.ToDouble(arrayArt[x, 1]) + "','" + Convert.ToDouble(arrayArt[x, 2]) + "','" + Convert.ToDouble(arrayArt[x, 3]) + "', '" + txtMach.Text + "', '" + general.strLoc + "')";



                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();


                }

            }


            String sqlS = "SELECT * FROM PRODSUB WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "' AND LOC='" + general.strLoc + "'  ";
            SqlDataAdapter sdaS = new SqlDataAdapter(sqlS, con);
            DataTable dtS = new DataTable();
            sdaS.Fill(dtS);
            if (dtS.Rows.Count > 0)
            {

                String sql3 = "DELETE FROM PRODSUB WHERE ENO ='" + EmpCode + "' and Date= '" + dtProd.Value.Date + "' and shift= '" + txtShift.Text + "' and P_code= '" + ProcCode + "' AND LOC='" + general.strLoc + "'  ";
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.ExecuteNonQuery();

            }

            for (int i = 0; i < gv.Rows.Count; i++)
            {
                if (Convert.ToDouble(arrayItem[i, 3]) != 0)
                {
                    String sql2 = "INSERT INTO PRODSUB (ENO,DATE,SHIFT, P_CODE,MACHINE, DL,  ART_NO , SHADE,PART_PROD,LOC) " +
                                 "values('" + EmpCode + "','" + dtProd.Value.Date + "','" + txtShift.Text + "', '" + ProcCode + "','" + txtMach.Text + "'," +
                                 " '" + arrayItem[i, 0] + "', '" + arrayItem[i, 1] + "','" + arrayItem[i, 2] + "','" + Convert.ToDouble(arrayItem[i, 3]) + "', '" + general.strLoc + "')";




                    SqlCommand cmd1 = new SqlCommand(sql2, con);
                    cmd1.ExecuteNonQuery();

                }

            }

            con.Close();
            MessageBox.Show("Data saved Succesfully");
            TextEnable();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cal()
        {
            T_KG= 0;
            double KGS= 0;
            double W_HR = 0;

            for (int i = 0; i < gv.Rows.Count; i++)
            {

                if (gv[5, i].Value != null && Convert.ToDouble(gv[5, i].Value) != 0 && gv[5, i].Value.ToString() != String.Empty)
                {

                    KGS= Convert.ToDouble(((gv.Rows[i].Cells[5]).Value).ToString());

                    T_KG= T_KG+ KGS;
                    W_HR = (KGS/T_KG) * Convert.ToDouble(txtTime.Text);

                    for (int k = 0; k < gv.Rows.Count; k++)
                    {
                        if (gv[5, k].Value != null && Convert.ToDouble(gv[5, k].Value) != 0 && gv[5, k].Value.ToString() != String.Empty)
                        {
                            (gv.Rows[k].Cells[6]).Value = Convert.ToDouble(((gv.Rows[k].Cells[5]).Value).ToString()) / T_KG * Convert.ToDouble(txtTime.Text);
                        }
                    }

                }
                txtTot.Text = T_KG.ToString();

            }
        }

        private void gv_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void gv_KeyPress(object sender, KeyPressEventArgs e)
        {
            int col = gv.CurrentCell.ColumnIndex;
            int row = gv.CurrentCell.RowIndex;

            switch (col)
            {
                case 0:
                    col = 1;
                    break;
                case 1:
                    col = 3;
                    break;
                case 3:
                    col = 5;
                    break;
                case 5:
                    if (gv[5, row].Value != null && gv[5, row].Value.ToString() != String.Empty && Convert.ToDouble(((gv.Rows[row].Cells[5]).Value).ToString()) > 0)
                    {
                        if (ConeEdit == false)
                        {
                            cal();
                        }
                        col = 0;
                        row++;

                    }
                    else
                    {
                        if ((gv.Rows[row].Cells[5]).Value == null)
                        {
                            MessageBox.Show("Enter Cones Quantity");
                            col = 4;
                        }
                    }
                    break;

                default:
                    break;

            }


            gv.Focus();
            gv.CurrentCell = gv[col, row];
            gv.Rows[row].Cells[col].Selected = true;

        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = gv.CurrentCell.ColumnIndex;
            int row = gv.CurrentCell.RowIndex;

            if (col == 1 && gv.CurrentCell.RowIndex == row)
            {
                if (gv[1, row].Value != null)
                {
                    comboBox1.Text = gv[1, row].Value.ToString();

                }
                else
                {
                    comboBox1.Visible = true;
                    Show_Combobox(row, 1);
                }
            }
            else
            {
                comboBox1.Visible = false;

            }

        }



        private void gv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gv.CurrentCell.ColumnIndex == 3)
            {
                if (e.Control is TextBox)
                {
                    ((TextBox)(e.Control)).CharacterCasing = CharacterCasing.Upper;
                }

            }

            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (gv.CurrentCell.ColumnIndex == 5 || gv.CurrentCell.ColumnIndex == 0) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }


        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z))
            {
                comboBox1.SelectedText = e.KeyCode.ToString().ToUpper();
                e.SuppressKeyPress = true;
            }
            return;
        }

        private void txtMach_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z))
            {
                txtMach.SelectedText = e.KeyCode.ToString().ToUpper();
                e.SuppressKeyPress = true;
            }
            return;

        }



        private void gv_MouseClick(object sender, MouseEventArgs e)
        {
            int col = gv.CurrentCell.ColumnIndex;
            int row = gv.CurrentCell.RowIndex;
            if (col == 1)
            {
                comboBox1.Visible = true;

            }
            else if (gv[1, row].Value != null)
            {
                comboBox1.Text = gv[1, row].Value.ToString();
            }




        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comProc.Focus();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                if (cmdNext.Enabled == true)
                {
                    save();
                    clear();
                    FormatGrid();
                    fillEmployee();
                    comboBox1.Visible = false;
                    comEmpID.Focus();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TextEnable()
        {
            cmdNext.Enabled = false;
            dtProd.TabStop = true;
            dtProd.Enabled = true;
            txtShift.Enabled = true;
            txtTime.Enabled = true;
            comProc.Enabled = true;
            comEmpID.Enabled = true;
            txtMach.Enabled = true;

        }



    }
}





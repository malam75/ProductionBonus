using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class MyDataGridView : DataGridView
{
    protected override bool ProcessDialogKey(Keys keyData)
    {
        Keys key = (keyData & Keys.KeyCode);
        if (key == Keys.Enter)
        {
            if (CurrentCell.ColumnIndex == 5 )
            {
//                return this.ProcessDownKey(keyData);
            }
            else
            {

                return this.ProcessRightKey(keyData);
            }
        }
        return base.ProcessDialogKey(keyData);
    }
    protected override bool ProcessDataGridViewKey(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (CurrentCell.ColumnIndex == 5 )
            {
//                return this.ProcessDownKey(e.KeyData);
            }
            else
            {
                return this.ProcessRightKey(e.KeyData);
            }

        }
        return base.ProcessDataGridViewKey(e);
    }



}




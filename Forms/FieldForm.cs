using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Task_4_Table.WFA
{
    public partial class FieldForm : Form
    {
        public DB.Field fieldResult;
        DB.Table table;
        Exception ex { set { if (value != null) MessageBox.Show(value.Message); } }
        bool statusEdit = false;
        public FieldForm(DB.Table table)
        {
            InitializeComponent();
            this.table = table;
            statusEdit = false;
        }

        public FieldForm(DB.Field fieldResult,DB.Table table)
        {
            InitializeComponent();
            this.fieldResult = fieldResult;
            this.table = table;
            tb_NameField.Text = fieldResult.name;
            cb_TypeField.SelectedIndex = (int)fieldResult.fieldType;
            statusEdit = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (statusEdit)
            {
                table.ChangeDataField(fieldResult,tb_NameField.Text, (Enums.FieldTypeEnum)cb_TypeField.SelectedIndex);
            }
            else
            {
                fieldResult = new DB.Field(tb_NameField.Text, (Enums.FieldTypeEnum)cb_TypeField.SelectedIndex);
                table.AddFieal(fieldResult);
            }
            ex = table.exception;
            if (table.exception == null)
                DialogResult = DialogResult.OK;
        }
    }
}

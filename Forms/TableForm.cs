using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WFA_Task_4_Table.WFA
{
    public partial class TableForm : Form
    {
        public DB.Table table;
        Exception e;
        public Exception Ex { get { return e; } set { if (value != null)  MessageBox.Show(value.Message); e = value; } }

        public TableForm(string name)
        {
            InitializeComponent();
            SqlCommand sqlCommandCreateTable = new SqlCommand(@"create table ["+name+"] (id int)");
            Ex = DB.UserSqlConnection.ExecuteReader(sqlCommandCreateTable, (reader) =>
            {
                table = new DB.Table();
                table.nameTable = name;
                table.fields.Add(new DB.Field("id",Enums.FieldTypeEnum.INT));
                RefreshTable();
            });
            if (Ex != null) DialogResult = DialogResult.Cancel;
        }

        public TableForm(DB.Table table)
        {
            InitializeComponent();
            this.table = table;
            RefreshTable();
           
        }

        void RefreshTable()
        {
            this.Text = table.nameTable;
            tb_NameTable.Text = table.nameTable;
            lvAllFiields.Items.Clear();
            foreach (var item in table.fields)
            {
                ListViewItem listViewItem = new ListViewItem(item.GetInfo());
                listViewItem.Tag = item;
                lvAllFiields.Items.Add(listViewItem);
            }
        }

        private void btn_SetNameTable_Click(object sender, EventArgs e)
        {
           
                SqlCommand sqlCommand = new SqlCommand(@"EXEC sp_rename @old, @new;");
                sqlCommand.Parameters.Add(new SqlParameter("@old", table.nameTable)).SqlDbType = SqlDbType.Text;
                sqlCommand.Parameters.Add(new SqlParameter("@new", tb_NameTable.Text)).SqlDbType = SqlDbType.Text;
                Ex = DB.UserSqlConnection.ExecuteReader(sqlCommand, (reader) =>
                {
                    table.nameTable = tb_NameTable.Text;
                    this.Text = table.nameTable;
                });
           
            
        }

        private void tb_NameTable_TextChanged(object sender, EventArgs e)
        {
            btn_SetNameTable.Enabled = !string.IsNullOrEmpty(tb_NameTable.Text);
        }

        private void btn_SetPK_Click(object sender, EventArgs e)
        {
           
                DB.Field fieldpk = table.GetFieldPK();
                Random random = new Random();
                SqlCommand sqlCommandDropPK;
                SqlCommand sqlCommandSetPK;
                string newpk = "PK__" + table.nameTable + "__" + random.Next().ToString() + "ID";
                sqlCommandSetPK = new SqlCommand(@"ALTER TABLE [" + table.nameTable + "] ADD CONSTRAINT [" + newpk + "] PRIMARY KEY CLUSTERED ([" + ((DB.Field)lvAllFiields.SelectedItems[0].Tag).name + "]);");
                if (fieldpk != null)
                {
                    sqlCommandDropPK = new SqlCommand(@"ALTER TABLE [" + table.nameTable + "] DROP CONSTRAINT [" + fieldpk.key + "];");
                    Ex = DB.UserSqlConnection.ExecuteReaderTransation(new SqlCommand[] { sqlCommandDropPK, sqlCommandSetPK }, () =>
                         {
                             ((DB.Field)lvAllFiields.SelectedItems[0].Tag).key = newpk;
                             fieldpk.key = "";
                             RefreshTable();

                         });
                }
                else
                {
                    Ex = DB.UserSqlConnection.ExecuteReader(sqlCommandSetPK, (reader) =>
                   {
                       ((DB.Field)lvAllFiields.SelectedItems[0].Tag).key = newpk;
                       RefreshTable();
                   });
                }
            
        }

        private void btnEditField_Click(object sender, EventArgs e)
        {
            FieldForm fieldForm = new FieldForm((DB.Field)lvAllFiields.SelectedItems[0].Tag,table);
            if (fieldForm.ShowDialog() == DialogResult.OK)
            {
                RefreshTable();
            }
        }

        private void btnDeleteField_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand(@"ALTER TABLE ["+ table.nameTable + "] DROP COLUMN ["+ lvAllFiields.SelectedItems[0].SubItems[1].Text + "]");
           // sqlCommand.Parameters.Add(new SqlParameter("@table", table.nameTable));
           // sqlCommand.Parameters.Add(new SqlParameter("@field", lvAllFiields.SelectedItems[0].SubItems[1].Text));
            Ex = DB.UserSqlConnection.ExecuteReader(sqlCommand, (reader) =>
            {
                table.fields.Remove((DB.Field)lvAllFiields.SelectedItems[0].Tag);
                lvAllFiields.Items.Remove(lvAllFiields.SelectedItems[0]);
            });
        }

        private void btnCreateField_Click(object sender, EventArgs e)
        {
            FieldForm fieldForm = new FieldForm(table);
            if (fieldForm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem listViewItem = new ListViewItem(fieldForm.fieldResult.GetInfo());
                listViewItem.Tag = fieldForm.fieldResult;
                lvAllFiields.Items.Add(listViewItem);
            }

        }

        private void lvAllFiields_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditField.Enabled = btnDeleteField.Enabled = lvAllFiields.SelectedItems.Count>0;
            
        }
    }
}

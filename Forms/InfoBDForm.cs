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
    public partial class InfoBDForm : Form
    {
        Exception ex { set { if (value != null) MessageBox.Show(value.Message); } }
        DB.DataBase dataBase;
        public InfoBDForm()
        {
            InitializeComponent();
            новоеПодключениеToolStripMenuItem_Click(new object(), new EventArgs());
        }

        /// <summary>
        /// ОТкрывает форму подключения к БД, и после обновляет данные данной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void новоеПодключениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionBDForm connectionBDForm = new ConnectionBDForm();
            if (connectionBDForm.ShowDialog() == DialogResult.OK)
            {
                RefreshConnectBD();
            }
        }

        /// <summary>
        /// Выполняет обновление данных на форме
        /// </summary>
        private void RefreshConnectBD()
        {
            dataBase = DB.UserSqlConnection.GetDataBase();
            if (dataBase.exception != null)
            {
                MessageBox.Show(dataBase.exception.Message);
            }
            else
            {
                RefreshListView();
            }
        }

        private void RefreshListView()
        {
            lvAllTable.Items.Clear();
                foreach (var item in dataBase.tables)
                {
                    ListViewItem listViewItem = new ListViewItem(item.ToString());
                    listViewItem.Tag = item;
                    lvAllTable.Items.Add(listViewItem);
                }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshConnectBD();
        }

        private void строкаПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DB.UserSqlConnection.GetDBStringConnection(true), "Строка подключения");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(dataBase.GetNewNameTable());
            tableForm.ShowDialog();
            dataBase.tables.Add(tableForm.table);
            RefreshListView();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("DROP TABLE ["+ lvAllTable.SelectedItems[0].Text + "]");
            ex = DB.UserSqlConnection.ExecuteReader(sqlCommand,(reader)=>
            {
                lvAllTable.Items.Remove(lvAllTable.SelectedItems[0]);
            });
            
        }

        private void lvAllTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteTable.Enabled = lvAllTable.SelectedItems.Count > 0;
            btnEditTable.Enabled = lvAllTable.SelectedItems.Count > 0;
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm((DB.Table)lvAllTable.SelectedItems[0].Tag);
            if (tableForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

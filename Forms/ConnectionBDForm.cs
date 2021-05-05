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
    public partial class ConnectionBDForm : Form
    {

        Exception ex;
        //(localdb)\MSSQLLocalDB;Initial Catalog=Product;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        public ConnectionBDForm()
        {
            InitializeComponent();
            cb_Check.SelectedIndex=0;
            btnNext.Enabled = false;
        }

        /// <summary>
        /// Обрабатывает выбор подключения пользователя к БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_Check_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_Check.SelectedIndex)
            {
                case 1:
                    tb_UserName.Enabled = true;
                    tb_UserPass.Enabled = true;
                    break;
                case 0:
                    tb_UserName.Enabled = false;
                    tb_UserPass.Enabled = false;
                    break;
            }

        }

        private void ShowMessage()
        {
            MessageBox.Show(ex.Message);
        }

        /// <summary>
        /// Проверяет подключение к БД и выводит соответсвующее сообщение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheckConnect_Click(object sender, EventArgs e)
        {
            DB.UserSqlConnection.datasource = tb_NameServer.Text;
            DB.UserSqlConnection.username = tb_UserName.Text;
            DB.UserSqlConnection.password = tb_UserPass.Text;
            DB.UserSqlConnection.typeConnect = (Enums.TypeConnect)cb_Check.SelectedIndex;
                     

            using (var sqlconn = DB.UserSqlConnection.GetSqlConnection(false))
            {
                try
                {
                    sqlconn.Open();
                    MessageBox.Show("Подключение работает: " + sqlconn.State);
                    var sqlCom = new SqlCommand(@"SELECT name FROM sys.databases;", sqlconn);

                    var reader = DB.UserSqlConnection.ExecuteSqlCommand(sqlCom,ref ex);
                    if (ex == null)
                    {
                        while (reader.Read())
                        {
                            cb_DataBases.Items.Add(reader[0]);
                        }
                        if (cb_DataBases.Items.Count > 0) cb_DataBases.SelectedIndex = 0;
                        btnNext.Enabled = true;
                    }
                    else
                    {
                        ShowMessage();
                    }
                }
                catch (Exception ex)
                {
                    this.ex = ex;
                    ShowMessage();
                }
            }
        }

        /// <summary>
        /// Переходим к следующей форме, после удачного подключения к бд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            DB.UserSqlConnection.datasource = tb_NameServer.Text;
            DB.UserSqlConnection.username = tb_UserName.Text;
            DB.UserSqlConnection.password = tb_UserPass.Text;
            DB.UserSqlConnection.typeConnect = (Enums.TypeConnect)cb_Check.SelectedIndex;
            DB.UserSqlConnection.database = cb_DataBases.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }
    }
}

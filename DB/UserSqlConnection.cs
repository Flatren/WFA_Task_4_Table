using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WFA_Task_4_Table.DB
{
    delegate void SuccessFun(SqlDataReader reader);
    delegate void SuccessFunNonParam();
    /// <summary>
    /// Хранит данные строки подключения и позволяет получать точку доступа к бд
    /// </summary>
    /// 
    class UserSqlConnection
    {
        public static string datasource;

        public static string database = "master";

        public static string username;

        public static string password;

        public static Enums.TypeConnect typeConnect;


        /// <summary>
        /// Формирует строку подключения на основании вложенных данных
        /// </summary>
        /// <param name="connectToBD">true - подключение к конкретной бд на сервере, false - подключение чисто к серверу+-</param>
        /// <returns></returns>
        public static string GetDBStringConnection(bool connectToBD)
        {
            //Data Source=BDSystemSMBIE.mssql.somee.com;User ID=Flatren123_SQLLogin_1;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            string connString = @"Data Source=" + datasource;

            if (connectToBD)
                connString += ";Initial Catalog=" + database;
            else
                connString += ";Initial Catalog = master";

            switch (typeConnect)
            {
                case Enums.TypeConnect.SQL:
                    connString += ";User ID=" + username;
                    connString += ";Password=" + password;
                    break;
                case Enums.TypeConnect.Windows:

                    break;
            }
            connString += ";Connect Timeout=10;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            return connString;
        }


        /// <summary>
        /// Возваращает подключение по указаной информации
        /// </summary>
        /// <param name="connectToBD"> true - подключение к конкретной бд на сервере, false - подключение чисто к серверу+-</param>
        /// <returns></returns>
        public static SqlConnection GetSqlConnection(bool connectToBD = true)
        {
            SqlConnection conn = null;
            conn = new SqlConnection(GetDBStringConnection(connectToBD));
            return conn;
        }

        /// <summary>
        /// Выполняет заданые команды, и возвращает данные и возникшие ошибки
        /// просто старая версия выполнения - на удаление
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteSqlCommand(SqlCommand sqlCommand, ref Exception ex)
        {
            SqlDataReader reader=null;
            ex = null;
                try
                {
                    reader = sqlCommand.ExecuteReader();
                }
                catch (Exception e)
                {
                    ex = e;
                }
            return reader;
        }

        /// <summary>
        /// Выполняет заданые команды, и возвращает данные и возникшие ошибки
        /// </summary>
        /// <returns></returns>
        public static Exception ExecuteReader(SqlCommand sqlCommand,SuccessFun successFun)
        {
            Exception e = null;
            using (var sqlconn = DB.UserSqlConnection.GetSqlConnection())
            {
                sqlCommand.Connection = sqlconn;
                try
                {
                    sqlconn.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    successFun(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    e = ex;
                }
            }
            return e;
        }
        /// <summary>
        /// выполняет список команд в виде транзакций
        /// </summary>
        /// <param name="sqlCommands"></param>
        /// <param name="successFun"></param>
        /// <returns>возвращает возможную ошибку</returns>
        public static Exception ExecuteReaderTransation(SqlCommand[] sqlCommands, SuccessFunNonParam successFun)
        {
            Exception e = null;
            using (var sqlconn = DB.UserSqlConnection.GetSqlConnection())
            {
                try
                {
                    sqlconn.Open();
                    using (var sqlconnTr = sqlconn.BeginTransaction())
                    {
                        try
                        {
                            foreach (var sqlCommand in sqlCommands)
                            {
                                sqlCommand.Connection = sqlconn;
                                sqlCommand.Transaction = sqlconnTr;
                                sqlCommand.ExecuteNonQuery();
                            }
                            sqlconnTr.Commit();
                            successFun();
                        }
                        catch (Exception ex)
                        {
                            e = ex;
                            sqlconnTr.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    e = ex;
                }
            }
            return e;
        }

        /// <summary>
        /// Создает новый объект подгрузящий данные из бд
        /// </summary>
        /// <returns></returns>
        public static DataBase GetDataBase()
        {
            return new DataBase();
        }

    }
    
}

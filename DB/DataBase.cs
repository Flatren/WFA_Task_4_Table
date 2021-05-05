using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WFA_Task_4_Table.DB
{
    public class DataBase
    {
        public string name;
        public List<Table> tables;
        public Exception exception;
        public DataBase()
        {
            name = UserSqlConnection.database;
            tables = new List<Table>();
            tables = new List<Table>();
            SqlCommand sqlCommand = new SqlCommand(@"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'");
            Exception e=null;
            exception = DB.UserSqlConnection.ExecuteReader(sqlCommand, (reader) =>
            {
                while (reader.Read()&&e==null)
                {
                    Table table = new Table(reader[0].ToString());
                    e= table.exception;
                    tables.Add(table);
                }
            });
            if (exception == null) exception = e;
        }
        public string GetNewNameTable()
        {
            string name = "default";
            int i = 0;
            while (tables.FindLast((x) => {return x.nameTable == name;})!=null)
            {
                name = "default"+"("+i.ToString()+")";
                i++;
            }
            return name;
        }
    }
}

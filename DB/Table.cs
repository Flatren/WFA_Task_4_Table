using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WFA_Task_4_Table.Enums;

namespace WFA_Task_4_Table.DB
{
    public class Table
    {
        public string nameTable;

        public List<Field> fields;

        public Exception exception;

        public Table(string nameTable)
        {
            this.nameTable = nameTable;
            fields = new List<Field>();
            SqlCommand sqlCommand = new SqlCommand(@"SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = @tablename");
            sqlCommand.Parameters.Add(new SqlParameter("@tablename", nameTable));
            exception = DB.UserSqlConnection.ExecuteReader(sqlCommand, (reader) =>
            {
                while (reader.Read())
                {
                    fields.Add(new Field(reader[0].ToString(), reader[1].ToString()));
                }
            });
            if (exception == null)
            {
                SqlCommand sqlCommandGetPK = new SqlCommand(@"SELECT t1.COLUMN_NAME,t2.CONSTRAINT_NAME from INFORMATION_SCHEMA.COLUMNS as t1 inner join  INFORMATION_SCHEMA.KEY_COLUMN_USAGE as t2 on t1.COLUMN_NAME = t2.COLUMN_NAME and t1.TABLE_NAME = t2.TABLE_NAME where t2.CONSTRAINT_NAME like 'PK%' and t1.TABLE_NAME = @tablename");
                sqlCommandGetPK.Parameters.Add(new SqlParameter("@tablename", nameTable));
                exception = DB.UserSqlConnection.ExecuteReader(sqlCommandGetPK, (reader) =>
                {
                    string read = "";
                    while (reader.Read())
                    {
                        read = reader[0].ToString();
                        foreach (var item in fields)
                        {
                            if (item.name == read)
                            {
                                item.key = reader[1].ToString();
                                break;
                            }
                        }
                    }
                });
            }
        }

        /// <summary>
        /// Выполняет обновление данных названия и типа поля таблицы
        /// </summary>
        /// <param name="fieldResult"> объект поля не обновленный</param>
        /// <param name="newname">Новое название поля</param>
        /// <param name="newType">Новый тип поля</param>
        public void ChangeDataField(Field fieldResult, string newname, FieldTypeEnum newType)
        {
            SqlCommand sqlCommandRename = new SqlCommand(@"EXEC sp_rename @tablefield, @newField, 'COLUMN';;");
            SqlCommand sqlCommandReType = new SqlCommand(@"ALTER TABLE [" +nameTable+"] ALTER COLUMN ["+ newname + "] ["+Enums.FieldTypeController.Get(newType) +"];");
            sqlCommandRename.Parameters.Add(new SqlParameter("@tablefield", nameTable+"."+ fieldResult.name));
            sqlCommandRename.Parameters.Add(new SqlParameter("@field", fieldResult.name));
            sqlCommandRename.Parameters.Add(new SqlParameter("@newField", newname));
            exception = DB.UserSqlConnection.ExecuteReaderTransation(new SqlCommand[] { sqlCommandRename, sqlCommandReType }, () =>
            {
                fieldResult.name = newname;
                fieldResult.fieldType = newType;
            });
        }

        public Table()
        {
            nameTable = "NewNameTable";
            fields = new List<Field>();
        }

        /// <summary>
        /// в созданную таблицу добавляет данные о поле таблицы
        /// Минус - возможны инъекции
        /// </summary>
        /// <param name="field"></param>
        public void AddFieal(Field field)
        {
            SqlCommand sqlCommand = new SqlCommand(@"ALTER TABLE ["+ nameTable + "] ADD ["+field.name+"] ["+Enums.FieldTypeController.Get(field.fieldType)+"] not null;");
            exception = DB.UserSqlConnection.ExecuteReader(sqlCommand, (reader) =>
            {
                fields.Add(field);
                
            });
        }

        public Field GetFieldPK()
        {
            foreach (var item in fields)
            {
                if(item.key!="")
                    return item;
            }
            return null;
        }

        public override string ToString()
        {
            return nameTable;
        }
    }
}

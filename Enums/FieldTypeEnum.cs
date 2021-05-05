using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Task_4_Table.Enums
{

    /// <summary>
    /// Пользователь может выбрать имя поля и один из следующих типов: целочисленный, вещественный, текстовый, даты/времени. 
    /// </summary>
   public enum FieldTypeEnum
    {
        
        INT,
        DOUBLE,
        TEXT,
        NVARCHAR,
        DATETIME
    }
   public static class FieldTypeController
    {
        public static string Get(FieldTypeEnum fieldType)
        {
            string result = "";
            switch (fieldType)
            {
                case FieldTypeEnum.INT:
                    result = "int";
                    break;
                case FieldTypeEnum.DOUBLE:
                    result = "real";
                    break;
                case FieldTypeEnum.TEXT:
                    result = "text";
                    break;
                case FieldTypeEnum.NVARCHAR:
                    result = "nvarchar";
                    break;
                case FieldTypeEnum.DATETIME:
                    result = "datetime";
                    break;
            }
            return result;
        }
        public static FieldTypeEnum Get(string fieldType)
        {
            FieldTypeEnum result = 0;
            switch (fieldType)
            {
                case "int":
                    result = FieldTypeEnum.INT;
                    break;
                case "real":
                    result = FieldTypeEnum.DOUBLE;
                    break;
                case "text":
                    result = FieldTypeEnum.TEXT;
                    break;
                case "nvarchar":
                    result = FieldTypeEnum.NVARCHAR;
                    break;
                case "datetime":
                    result = FieldTypeEnum.DATETIME;
                    break;
            }
            return result;
        }
    }
}

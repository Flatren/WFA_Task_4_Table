using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Task_4_Table.Enums;

namespace WFA_Task_4_Table.DB
{
    public class Field
    {
        public string name;

        public Enums.FieldTypeEnum fieldType;

        public string key;

        public Field(string name, string key, Enums.FieldTypeEnum fieldType)
        {
            this.name = name;
            this.key = key;
            this.fieldType = fieldType;
        }

        public Field(string name, Enums.FieldTypeEnum fieldType)
        {
            this.name = name;
            this.key = "";
            this.fieldType = fieldType;
        }

        public Field(string name, string fieldType)
        {
            this.name = name;
            this.fieldType = Enums.FieldTypeController.Get(fieldType);
            key = "";
        }

        public string[] GetInfo()
        {
            return new string[] {key!=""?"+":"-",name,Enums.FieldTypeController.Get(fieldType)};
        }

        
    }
}


namespace WFA_Task_4_Table.WFA
{
    partial class TableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvAllFiields = new System.Windows.Forms.ListView();
            this.columnHeaderKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnCreateField = new System.Windows.Forms.Button();
            this.btnEditField = new System.Windows.Forms.Button();
            this.btnDeleteField = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SetNameTable = new System.Windows.Forms.Button();
            this.tb_NameTable = new System.Windows.Forms.TextBox();
            this.btn_SetPK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAllFiields
            // 
            this.lvAllFiields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderKey,
            this.columnHeaderName,
            this.columnHeaderType});
            this.lvAllFiields.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAllFiields.FullRowSelect = true;
            this.lvAllFiields.GridLines = true;
            this.lvAllFiields.HideSelection = false;
            this.lvAllFiields.Location = new System.Drawing.Point(0, 0);
            this.lvAllFiields.MultiSelect = false;
            this.lvAllFiields.Name = "lvAllFiields";
            this.lvAllFiields.Size = new System.Drawing.Size(305, 513);
            this.lvAllFiields.TabIndex = 3;
            this.lvAllFiields.UseCompatibleStateImageBehavior = false;
            this.lvAllFiields.View = System.Windows.Forms.View.Details;
            this.lvAllFiields.SelectedIndexChanged += new System.EventHandler(this.lvAllFiields_SelectedIndexChanged);
            // 
            // columnHeaderKey
            // 
            this.columnHeaderKey.Text = "Ключ";
            this.columnHeaderKey.Width = 58;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 65;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Тип поля";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(305, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 513);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // btnCreateField
            // 
            this.btnCreateField.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateField.Location = new System.Drawing.Point(308, 0);
            this.btnCreateField.Name = "btnCreateField";
            this.btnCreateField.Size = new System.Drawing.Size(267, 23);
            this.btnCreateField.TabIndex = 7;
            this.btnCreateField.Text = "Создать поле";
            this.btnCreateField.UseVisualStyleBackColor = true;
            this.btnCreateField.Click += new System.EventHandler(this.btnCreateField_Click);
            // 
            // btnEditField
            // 
            this.btnEditField.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditField.Location = new System.Drawing.Point(308, 23);
            this.btnEditField.Name = "btnEditField";
            this.btnEditField.Size = new System.Drawing.Size(267, 24);
            this.btnEditField.TabIndex = 6;
            this.btnEditField.Text = "Редактировать";
            this.btnEditField.UseVisualStyleBackColor = true;
            this.btnEditField.Click += new System.EventHandler(this.btnEditField_Click);
            // 
            // btnDeleteField
            // 
            this.btnDeleteField.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteField.Location = new System.Drawing.Point(308, 47);
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Size = new System.Drawing.Size(267, 23);
            this.btnDeleteField.TabIndex = 5;
            this.btnDeleteField.Text = "Удалить";
            this.btnDeleteField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteField.UseVisualStyleBackColor = true;
            this.btnDeleteField.Click += new System.EventHandler(this.btnDeleteField_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_SetNameTable);
            this.panel1.Controls.Add(this.tb_NameTable);
            this.panel1.Controls.Add(this.btn_SetPK);
            this.panel1.Controls.Add(this.btnDeleteField);
            this.panel1.Controls.Add(this.btnEditField);
            this.panel1.Controls.Add(this.btnCreateField);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.lvAllFiields);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 513);
            this.panel1.TabIndex = 5;
            // 
            // btn_SetNameTable
            // 
            this.btn_SetNameTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SetNameTable.Location = new System.Drawing.Point(308, 113);
            this.btn_SetNameTable.Name = "btn_SetNameTable";
            this.btn_SetNameTable.Size = new System.Drawing.Size(267, 23);
            this.btn_SetNameTable.TabIndex = 12;
            this.btn_SetNameTable.Text = "Задать Название";
            this.btn_SetNameTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SetNameTable.UseVisualStyleBackColor = true;
            this.btn_SetNameTable.Click += new System.EventHandler(this.btn_SetNameTable_Click);
            // 
            // tb_NameTable
            // 
            this.tb_NameTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_NameTable.Location = new System.Drawing.Point(308, 93);
            this.tb_NameTable.Name = "tb_NameTable";
            this.tb_NameTable.Size = new System.Drawing.Size(267, 20);
            this.tb_NameTable.TabIndex = 11;
            this.tb_NameTable.TextChanged += new System.EventHandler(this.tb_NameTable_TextChanged);
            // 
            // btn_SetPK
            // 
            this.btn_SetPK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SetPK.Location = new System.Drawing.Point(308, 70);
            this.btn_SetPK.Name = "btn_SetPK";
            this.btn_SetPK.Size = new System.Drawing.Size(267, 23);
            this.btn_SetPK.TabIndex = 9;
            this.btn_SetPK.Text = "Задать первычный ключ";
            this.btn_SetPK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SetPK.UseVisualStyleBackColor = true;
            this.btn_SetPK.Click += new System.EventHandler(this.btn_SetPK_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 513);
            this.Controls.Add(this.panel1);
            this.Name = "TableForm";
            this.Text = "Table";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvAllFiields;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnCreateField;
        private System.Windows.Forms.Button btnEditField;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeaderKey;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.Button btn_SetPK;
        private System.Windows.Forms.TextBox tb_NameTable;
        private System.Windows.Forms.Button btn_SetNameTable;
    }
}
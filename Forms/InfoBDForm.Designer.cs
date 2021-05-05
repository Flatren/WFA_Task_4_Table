namespace WFA_Task_4_Table.WFA
{
    partial class InfoBDForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеПодключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкаПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lvAllTable = new System.Windows.Forms.ListView();
            this.columnHeaderNameTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.подключениеToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // подключениеToolStripMenuItem
            // 
            this.подключениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новоеПодключениеToolStripMenuItem,
            this.строкаПодключенияToolStripMenuItem});
            this.подключениеToolStripMenuItem.Name = "подключениеToolStripMenuItem";
            this.подключениеToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.подключениеToolStripMenuItem.Text = "Подключение";
            // 
            // новоеПодключениеToolStripMenuItem
            // 
            this.новоеПодключениеToolStripMenuItem.Name = "новоеПодключениеToolStripMenuItem";
            this.новоеПодключениеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.новоеПодключениеToolStripMenuItem.Text = "Новое подключение";
            this.новоеПодключениеToolStripMenuItem.Click += new System.EventHandler(this.новоеПодключениеToolStripMenuItem_Click);
            // 
            // строкаПодключенияToolStripMenuItem
            // 
            this.строкаПодключенияToolStripMenuItem.Name = "строкаПодключенияToolStripMenuItem";
            this.строкаПодключенияToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.строкаПодключенияToolStripMenuItem.Text = "Строка подключения";
            this.строкаПодключенияToolStripMenuItem.Click += new System.EventHandler(this.строкаПодключенияToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteTable);
            this.panel1.Controls.Add(this.btnEditTable);
            this.panel1.Controls.Add(this.btnCreateTable);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.lvAllTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 481);
            this.panel1.TabIndex = 3;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteTable.Location = new System.Drawing.Point(206, 47);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(162, 23);
            this.btnDeleteTable.TabIndex = 5;
            this.btnDeleteTable.Text = "Удалить";
            this.btnDeleteTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditTable.Location = new System.Drawing.Point(206, 23);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(162, 24);
            this.btnEditTable.TabIndex = 6;
            this.btnEditTable.Text = "Редактировать";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateTable.Location = new System.Drawing.Point(206, 0);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(162, 23);
            this.btnCreateTable.TabIndex = 7;
            this.btnCreateTable.Text = "Создать";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(203, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 481);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // lvAllTable
            // 
            this.lvAllTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNameTable});
            this.lvAllTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAllTable.FullRowSelect = true;
            this.lvAllTable.GridLines = true;
            this.lvAllTable.HideSelection = false;
            this.lvAllTable.Location = new System.Drawing.Point(0, 0);
            this.lvAllTable.MultiSelect = false;
            this.lvAllTable.Name = "lvAllTable";
            this.lvAllTable.Size = new System.Drawing.Size(203, 481);
            this.lvAllTable.TabIndex = 3;
            this.lvAllTable.UseCompatibleStateImageBehavior = false;
            this.lvAllTable.View = System.Windows.Forms.View.Details;
            this.lvAllTable.SelectedIndexChanged += new System.EventHandler(this.lvAllTable_SelectedIndexChanged);
            // 
            // columnHeaderNameTable
            // 
            this.columnHeaderNameTable.Text = "Названия таблиц";
            this.columnHeaderNameTable.Width = 114;
            // 
            // InfoBDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InfoBDForm";
            this.Text = "InfoBD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеПодключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкаПодключенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvAllTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ColumnHeader columnHeaderNameTable;
    }
}
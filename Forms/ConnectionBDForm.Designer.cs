namespace WFA_Task_4_Table.WFA
{
    partial class ConnectionBDForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Check = new System.Windows.Forms.ComboBox();
            this.tb_NameServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_UserPass = new System.Windows.Forms.TextBox();
            this.buttonCheckConnect = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_DataBases = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя сервера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Проверка подлинности:";
            // 
            // cb_Check
            // 
            this.cb_Check.DisplayMember = "0";
            this.cb_Check.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Check.FormattingEnabled = true;
            this.cb_Check.Items.AddRange(new object[] {
            "Проверка подлиности Windows",
            "Проверка подлинности SQL"});
            this.cb_Check.Location = new System.Drawing.Point(144, 57);
            this.cb_Check.Name = "cb_Check";
            this.cb_Check.Size = new System.Drawing.Size(195, 21);
            this.cb_Check.TabIndex = 2;
            this.cb_Check.SelectedIndexChanged += new System.EventHandler(this.cb_Check_SelectedIndexChanged);
            // 
            // tb_NameServer
            // 
            this.tb_NameServer.Location = new System.Drawing.Point(144, 31);
            this.tb_NameServer.Name = "tb_NameServer";
            this.tb_NameServer.Size = new System.Drawing.Size(195, 20);
            this.tb_NameServer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя пользователя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль:";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Enabled = false;
            this.tb_UserName.Location = new System.Drawing.Point(144, 84);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(195, 20);
            this.tb_UserName.TabIndex = 6;
            // 
            // tb_UserPass
            // 
            this.tb_UserPass.Enabled = false;
            this.tb_UserPass.Location = new System.Drawing.Point(144, 110);
            this.tb_UserPass.Name = "tb_UserPass";
            this.tb_UserPass.Size = new System.Drawing.Size(195, 20);
            this.tb_UserPass.TabIndex = 7;
            // 
            // buttonCheckConnect
            // 
            this.buttonCheckConnect.Location = new System.Drawing.Point(16, 133);
            this.buttonCheckConnect.Name = "buttonCheckConnect";
            this.buttonCheckConnect.Size = new System.Drawing.Size(323, 23);
            this.buttonCheckConnect.TabIndex = 8;
            this.buttonCheckConnect.Text = "Проверить";
            this.buttonCheckConnect.UseVisualStyleBackColor = true;
            this.buttonCheckConnect.Click += new System.EventHandler(this.buttonCheckConnect_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(16, 189);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(323, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "База данных:";
            // 
            // cb_DataBases
            // 
            this.cb_DataBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DataBases.FormattingEnabled = true;
            this.cb_DataBases.Location = new System.Drawing.Point(144, 162);
            this.cb_DataBases.Name = "cb_DataBases";
            this.cb_DataBases.Size = new System.Drawing.Size(195, 21);
            this.cb_DataBases.TabIndex = 12;
            // 
            // ConnectionBDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(351, 223);
            this.Controls.Add(this.cb_DataBases);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.buttonCheckConnect);
            this.Controls.Add(this.tb_UserPass);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_NameServer);
            this.Controls.Add(this.cb_Check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConnectionBDForm";
            this.Text = "ConnectionBD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Check;
        private System.Windows.Forms.TextBox tb_NameServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TextBox tb_UserPass;
        private System.Windows.Forms.Button buttonCheckConnect;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_DataBases;
    }
}
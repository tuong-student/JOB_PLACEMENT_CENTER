namespace final_oosee.AdministratorInterface
{
    partial class Administrator_ManageAccount
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch01 = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataAccount = new System.Windows.Forms.DataGridView();
            this.jobIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteAccountBtn = new FontAwesome.Sharp.IconButton();
            this.panelSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.btnSearch01);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Location = new System.Drawing.Point(16, 12);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(331, 44);
            this.panelSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(43, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 35);
            this.txtSearch.TabIndex = 1;
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Students Registered",
            "Employers"});
            this.cbSearch.Location = new System.Drawing.Point(373, 13);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(331, 41);
            this.cbSearch.TabIndex = 4;
            this.cbSearch.Text = "--Role--";
            // 
            // btnSearch01
            // 
            this.btnSearch01.FlatAppearance.BorderSize = 0;
            this.btnSearch01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch01.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch01.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSearch01.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch01.IconSize = 30;
            this.btnSearch01.Location = new System.Drawing.Point(3, 7);
            this.btnSearch01.Name = "btnSearch01";
            this.btnSearch01.Size = new System.Drawing.Size(34, 30);
            this.btnSearch01.TabIndex = 2;
            this.btnSearch01.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Front End",
            "Back End",
            "Data"});
            this.comboBox1.Location = new System.Drawing.Point(720, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 41);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "--Job--";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1042, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataAccount);
            this.panel1.Location = new System.Drawing.Point(16, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 419);
            this.panel1.TabIndex = 6;
            // 
            // dataAccount
            // 
            this.dataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIndex,
            this.accountName,
            this.accountRole,
            this.accountCompany,
            this.accountCreateDate});
            this.dataAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAccount.Location = new System.Drawing.Point(0, 0);
            this.dataAccount.Name = "dataAccount";
            this.dataAccount.RowHeadersWidth = 51;
            this.dataAccount.RowTemplate.Height = 24;
            this.dataAccount.Size = new System.Drawing.Size(1237, 419);
            this.dataAccount.TabIndex = 0;
            // 
            // jobIndex
            // 
            this.jobIndex.HeaderText = "STT";
            this.jobIndex.MinimumWidth = 6;
            this.jobIndex.Name = "jobIndex";
            this.jobIndex.Width = 125;
            // 
            // accountName
            // 
            this.accountName.HeaderText = "Họ tên";
            this.accountName.MinimumWidth = 6;
            this.accountName.Name = "accountName";
            this.accountName.Width = 125;
            // 
            // accountRole
            // 
            this.accountRole.HeaderText = "Vai trò";
            this.accountRole.MinimumWidth = 6;
            this.accountRole.Name = "accountRole";
            this.accountRole.Width = 125;
            // 
            // accountCompany
            // 
            this.accountCompany.HeaderText = "Công ty";
            this.accountCompany.MinimumWidth = 6;
            this.accountCompany.Name = "accountCompany";
            this.accountCompany.Width = 125;
            // 
            // accountCreateDate
            // 
            this.accountCreateDate.HeaderText = "Ngày tạo tài khoản";
            this.accountCreateDate.MinimumWidth = 6;
            this.accountCreateDate.Name = "accountCreateDate";
            this.accountCreateDate.Width = 125;
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.deleteAccountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.deleteAccountBtn.FlatAppearance.BorderSize = 0;
            this.deleteAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccountBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccountBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAccountBtn.IconChar = FontAwesome.Sharp.IconChar.Xing;
            this.deleteAccountBtn.IconColor = System.Drawing.Color.White;
            this.deleteAccountBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteAccountBtn.IconSize = 30;
            this.deleteAccountBtn.Location = new System.Drawing.Point(1087, 92);
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.Size = new System.Drawing.Size(166, 45);
            this.deleteAccountBtn.TabIndex = 7;
            this.deleteAccountBtn.Text = "Delete";
            this.deleteAccountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteAccountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteAccountBtn.UseVisualStyleBackColor = false;
            // 
            // Administrator_ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 574);
            this.ControlBox = false;
            this.Controls.Add(this.deleteAccountBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator_ManageAccount";
            this.Text = "Administrator_ManageAccount";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private FontAwesome.Sharp.IconButton btnSearch01;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCreateDate;
        private FontAwesome.Sharp.IconButton deleteAccountBtn;
    }
}
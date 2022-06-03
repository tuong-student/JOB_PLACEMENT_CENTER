namespace final_oosee
{
    partial class StudentHome
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
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataJobEvent = new System.Windows.Forms.DataGridView();
            this.jobIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobExpire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panelSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataJobEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.searchBtn);
            this.panelSearch.Location = new System.Drawing.Point(20, 12);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(399, 45);
            this.panelSearch.TabIndex = 0;
            this.panelSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(10, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(321, 37);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "job name";
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(139)))), ((int)(((byte)(36)))));
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.White;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 40;
            this.searchBtn.Location = new System.Drawing.Point(337, 0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(60, 43);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.cbSearch.Location = new System.Drawing.Point(582, 114);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(237, 44);
            this.cbSearch.TabIndex = 1;
            this.cbSearch.Text = "Form";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataJobEvent);
            this.panel1.Location = new System.Drawing.Point(20, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 488);
            this.panel1.TabIndex = 2;
            // 
            // dataJobEvent
            // 
            this.dataJobEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataJobEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIndex,
            this.jobName,
            this.companyName,
            this.jobSalary,
            this.jobExpire});
            this.dataJobEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataJobEvent.Location = new System.Drawing.Point(0, 0);
            this.dataJobEvent.Name = "dataJobEvent";
            this.dataJobEvent.RowHeadersWidth = 51;
            this.dataJobEvent.RowTemplate.Height = 24;
            this.dataJobEvent.Size = new System.Drawing.Size(1240, 488);
            this.dataJobEvent.TabIndex = 0;
            // 
            // jobIndex
            // 
            this.jobIndex.HeaderText = "STT";
            this.jobIndex.MinimumWidth = 6;
            this.jobIndex.Name = "jobIndex";
            this.jobIndex.Width = 125;
            // 
            // jobName
            // 
            this.jobName.HeaderText = "Tên công việc";
            this.jobName.MinimumWidth = 6;
            this.jobName.Name = "jobName";
            this.jobName.Width = 125;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Tên công ty";
            this.companyName.MinimumWidth = 6;
            this.companyName.Name = "companyName";
            this.companyName.Width = 125;
            // 
            // jobSalary
            // 
            this.jobSalary.HeaderText = "Lương";
            this.jobSalary.MinimumWidth = 6;
            this.jobSalary.Name = "jobSalary";
            this.jobSalary.Width = 125;
            // 
            // jobExpire
            // 
            this.jobExpire.HeaderText = "Hạn ứng tuyển";
            this.jobExpire.MinimumWidth = 6;
            this.jobExpire.Name = "jobExpire";
            this.jobExpire.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Front End",
            "Back End",
            "Data Engineer"});
            this.comboBox1.Location = new System.Drawing.Point(24, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 44);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Type";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "500 - 1000 $",
            "1000 - 2000 $",
            ">2000 $"});
            this.comboBox2.Location = new System.Drawing.Point(308, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 44);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Salary";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Ho Chi Minh",
            "Ha Noi",
            "Da Nang"});
            this.comboBox3.Location = new System.Drawing.Point(839, 114);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(237, 44);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.Text = "Place";
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataJobEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataJobEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobExpire;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}
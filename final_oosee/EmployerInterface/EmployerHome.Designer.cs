namespace final_oosee.EmployerInterface
{
    partial class EmployerHome
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBirthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMainSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearch01 = new FontAwesome.Sharp.IconButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panelSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.btnSearch01);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Location = new System.Drawing.Point(12, 12);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(331, 44);
            this.panelSearch.TabIndex = 1;
            this.panelSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearch_Paint);
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
            this.txtSearch.Text = "name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(35)))), ((int)(((byte)(75)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1018, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Front End",
            "Back End",
            "Data Engineer"});
            this.cbSearch.Location = new System.Drawing.Point(353, 93);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(329, 45);
            this.cbSearch.TabIndex = 3;
            this.cbSearch.Text = "Health Condition";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 401);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIndex,
            this.studentName,
            this.studentBirthYear,
            this.studentMainSubject,
            this.studentExperience});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1191, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // jobIndex
            // 
            this.jobIndex.HeaderText = "STT";
            this.jobIndex.MinimumWidth = 6;
            this.jobIndex.Name = "jobIndex";
            this.jobIndex.Width = 125;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Họ Tên";
            this.studentName.MinimumWidth = 6;
            this.studentName.Name = "studentName";
            this.studentName.Width = 125;
            // 
            // studentBirthYear
            // 
            this.studentBirthYear.HeaderText = "Năm Sinh";
            this.studentBirthYear.MinimumWidth = 6;
            this.studentBirthYear.Name = "studentBirthYear";
            this.studentBirthYear.Width = 125;
            // 
            // studentMainSubject
            // 
            this.studentMainSubject.HeaderText = "Chuyên Ngành";
            this.studentMainSubject.MinimumWidth = 6;
            this.studentMainSubject.Name = "studentMainSubject";
            this.studentMainSubject.Width = 125;
            // 
            // studentExperience
            // 
            this.studentExperience.HeaderText = "Kinh nghiệm";
            this.studentExperience.MinimumWidth = 6;
            this.studentExperience.Name = "studentExperience";
            this.studentExperience.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(35)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Candidate List";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Graduated High School",
            "Graduated College",
            "Graduated Unif"});
            this.comboBox1.Location = new System.Drawing.Point(12, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 45);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Qualification";
            // 
            // btnSearch01
            // 
            this.btnSearch01.FlatAppearance.BorderSize = 0;
            this.btnSearch01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch01.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch01.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnSearch01.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch01.IconSize = 30;
            this.btnSearch01.Location = new System.Drawing.Point(3, 7);
            this.btnSearch01.Name = "btnSearch01";
            this.btnSearch01.Size = new System.Drawing.Size(34, 30);
            this.btnSearch01.TabIndex = 2;
            this.btnSearch01.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0 - 1 year",
            "1 - 2 years",
            ">2 years"});
            this.comboBox2.Location = new System.Drawing.Point(714, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(269, 45);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Experience";
            // 
            // EmployerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 670);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployerHome";
            this.Text = "EmployerHome";
            this.Load += new System.EventHandler(this.EmployerHome_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch01;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBirthYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentMainSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentExperience;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
namespace final_oosee.StudentInterfaces
{
    partial class StudentApplied_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAppliedJob = new System.Windows.Forms.DataGridView();
            this.lbJobDescription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliedJob)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dgvAppliedJob);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 331);
            this.panel1.TabIndex = 3;
            // 
            // dgvAppliedJob
            // 
            this.dgvAppliedJob.AllowUserToAddRows = false;
            this.dgvAppliedJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppliedJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppliedJob.Location = new System.Drawing.Point(0, 0);
            this.dgvAppliedJob.Name = "dgvAppliedJob";
            this.dgvAppliedJob.ReadOnly = true;
            this.dgvAppliedJob.RowHeadersWidth = 51;
            this.dgvAppliedJob.RowTemplate.Height = 24;
            this.dgvAppliedJob.Size = new System.Drawing.Size(863, 331);
            this.dgvAppliedJob.TabIndex = 0;
            // 
            // lbJobDescription
            // 
            this.lbJobDescription.AutoSize = true;
            this.lbJobDescription.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(139)))), ((int)(((byte)(36)))));
            this.lbJobDescription.Location = new System.Drawing.Point(6, 9);
            this.lbJobDescription.Name = "lbJobDescription";
            this.lbJobDescription.Size = new System.Drawing.Size(175, 33);
            this.lbJobDescription.TabIndex = 4;
            this.lbJobDescription.Text = "Applied Job";
            // 
            // StudentApplied_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 436);
            this.Controls.Add(this.lbJobDescription);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentApplied_Form";
            this.Text = "StudentApplied_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliedJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAppliedJob;
        private System.Windows.Forms.Label lbJobDescription;
    }
}
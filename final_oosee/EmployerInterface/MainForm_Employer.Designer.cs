namespace final_oosee.EmployerInterface
{
    partial class MainForm_Employer
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
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.logOutButton = new FontAwesome.Sharp.IconButton();
            this.eventManageBtn = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.sideBarButton = new FontAwesome.Sharp.IconButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSideBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(3)))), ((int)(((byte)(30)))));
            this.panelSideBar.Controls.Add(this.iconButton1);
            this.panelSideBar.Controls.Add(this.logOutButton);
            this.panelSideBar.Controls.Add(this.eventManageBtn);
            this.panelSideBar.Controls.Add(this.homeButton);
            this.panelSideBar.Controls.Add(this.panelLogo);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(230, 753);
            this.panelSideBar.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 190);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(230, 60);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Change Information";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logOutButton.IconColor = System.Drawing.Color.White;
            this.logOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logOutButton.IconSize = 30;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(0, 693);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logOutButton.Size = new System.Drawing.Size(230, 60);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutButton.UseVisualStyleBackColor = true;
            // 
            // eventManageBtn
            // 
            this.eventManageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventManageBtn.FlatAppearance.BorderSize = 0;
            this.eventManageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventManageBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventManageBtn.ForeColor = System.Drawing.Color.White;
            this.eventManageBtn.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.eventManageBtn.IconColor = System.Drawing.Color.White;
            this.eventManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventManageBtn.IconSize = 30;
            this.eventManageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventManageBtn.Location = new System.Drawing.Point(0, 130);
            this.eventManageBtn.Name = "eventManageBtn";
            this.eventManageBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.eventManageBtn.Size = new System.Drawing.Size(230, 60);
            this.eventManageBtn.TabIndex = 2;
            this.eventManageBtn.Text = "Manage Recruitment Event";
            this.eventManageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventManageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eventManageBtn.UseVisualStyleBackColor = true;
            this.eventManageBtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeButton.IconColor = System.Drawing.Color.White;
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.IconSize = 30;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 70);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homeButton.Size = new System.Drawing.Size(230, 60);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Candidate List";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.sideBarButton);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 70);
            this.panelLogo.TabIndex = 0;
            // 
            // sideBarButton
            // 
            this.sideBarButton.FlatAppearance.BorderSize = 0;
            this.sideBarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBarButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.sideBarButton.IconColor = System.Drawing.Color.White;
            this.sideBarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBarButton.Location = new System.Drawing.Point(3, 7);
            this.sideBarButton.Name = "sideBarButton";
            this.sideBarButton.Size = new System.Drawing.Size(60, 60);
            this.sideBarButton.TabIndex = 1;
            this.sideBarButton.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Location = new System.Drawing.Point(236, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1134, 731);
            this.panelContent.TabIndex = 2;
            // 
            // MainForm_Employer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideBar);
            this.Name = "MainForm_Employer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm_Employer";
            this.Load += new System.EventHandler(this.MainForm_Employer_Load);
            this.panelSideBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private FontAwesome.Sharp.IconButton logOutButton;
        private FontAwesome.Sharp.IconButton eventManageBtn;
        private FontAwesome.Sharp.IconButton homeButton;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton sideBarButton;
        private System.Windows.Forms.Panel panelContent;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
namespace final_oosee
{
    partial class MainForm_Student
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.logOutButton = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.sideBarButton = new FontAwesome.Sharp.IconButton();
            this.panelSideBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(139)))), ((int)(((byte)(36)))));
            this.panelSideBar.Controls.Add(this.logOutButton);
            this.panelSideBar.Controls.Add(this.iconButton2);
            this.panelSideBar.Controls.Add(this.homeButton);
            this.panelSideBar.Controls.Add(this.panelLogo);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(230, 753);
            this.panelSideBar.TabIndex = 0;
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
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Location = new System.Drawing.Point(236, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1134, 736);
            this.panelContent.TabIndex = 1;
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
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 130);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(230, 60);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Manage CV";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
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
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.button1_Click);
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
            this.sideBarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideBar);
            this.Name = "MainForm_Student";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSideBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton sideBarButton;
        private FontAwesome.Sharp.IconButton homeButton;
        private FontAwesome.Sharp.IconButton logOutButton;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}


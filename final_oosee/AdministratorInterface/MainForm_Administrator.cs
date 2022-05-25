﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_oosee.AdministratorInterface
{
    public partial class MainForm_Administrator : Form
    {
        Administrator_ManageAccount administrator_account = new Administrator_ManageAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Administrator_Statistic administrator_statistic = new Administrator_Statistic() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public MainForm_Administrator()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(173, 232, 244);
        }

        private void MainForm_Administrator_Load(object sender, EventArgs e)
        {
            this.panelContent.Controls.Add(administrator_account);
            this.panelContent.Controls.Add(administrator_statistic);
            administrator_account.Show();
        }

        private void accountManageBtn_Click(object sender, EventArgs e)
        {
            administrator_account.Show();
        }

        private void statisticBtn_Click(object sender, EventArgs e)
        {
            administrator_account.Hide();
            administrator_statistic.Show();
        }
    }
}

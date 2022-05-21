using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_oosee.EmployerInterface
{
    public partial class MainForm_Employer : Form
    {
        EmployerHome employerHome = new EmployerHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Employer_EventManager employerEventManager = new Employer_EventManager() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public MainForm_Employer()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(251, 35, 75);
        }

        private void MainForm_Employer_Load(object sender, EventArgs e)
        {
            this.panelContent.Controls.Add(employerHome);
            employerHome.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)

        {
            this.panelContent.Controls.RemoveAt(0);
            this.panelContent.Controls.Add(employerHome);
            employerHome.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.panelContent.Controls.RemoveAt(0);
            this.panelContent.Controls.Add(employerEventManager);
            employerEventManager.Show();
        }
    }
}

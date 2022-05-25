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
        Employer_InformationRegister employerInformationRegister = new Employer_InformationRegister() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        public MainForm_Employer()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(251, 35, 75);
        }

        private void MainForm_Employer_Load(object sender, EventArgs e)
        {
            this.panelContent.Controls.Add(employerHome);
            this.panelContent.Controls.Add(employerEventManager);
            this.panelContent.Controls.Add(employerInformationRegister);
            employerHome.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            employerHome.Show();
        }

        private void eventManageBtn_Click(object sender, EventArgs e)
        {
            employerHome.Hide();
            employerEventManager.Show();
        }

        private void changeInformationBtn_Click(object sender, EventArgs e)
        {
            employerHome.Hide();
            employerEventManager.Hide();
            employerInformationRegister.Show();
        }
    }
}

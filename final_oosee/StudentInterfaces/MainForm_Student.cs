using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_oosee
{
    public partial class MainForm_Student : Form
    {
        StudentHome studentHomeForm = new StudentHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Student_CV_Form studentCVForm = new Student_CV_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public MainForm_Student()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(253, 202, 155);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panelContent.Controls.Add(studentHomeForm);
            this.panelContent.Controls.Add(studentCVForm);
            studentHomeForm.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            studentHomeForm.Show();
        }

        private void manageCVBtn_Click(object sender, EventArgs e)
        {
            studentHomeForm.Hide();
            studentCVForm.Show();
        }
    }
}

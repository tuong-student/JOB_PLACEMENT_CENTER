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
        public MainForm_Student()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(253, 202, 155);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StudentHome studentHomeForm = new StudentHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelContent.Controls.Add(studentHomeForm);
            studentHomeForm.Show();

        }
    }
}

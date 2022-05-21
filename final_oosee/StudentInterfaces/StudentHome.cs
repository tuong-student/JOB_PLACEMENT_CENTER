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
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
            
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.FromArgb(251, 139, 36), ButtonBorderStyle.Solid);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentHome_Load(object sender, EventArgs e)
        {

        }
    }
}

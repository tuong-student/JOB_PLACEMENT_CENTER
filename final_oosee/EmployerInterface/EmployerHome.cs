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
    public partial class EmployerHome : Form
    {
        public EmployerHome()
        {
            InitializeComponent();
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.FromArgb(180, 4, 36), ButtonBorderStyle.Solid);
        }

        private void EmployerHome_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.label1;
        }
    }
}

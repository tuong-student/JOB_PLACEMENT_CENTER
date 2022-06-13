using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_oosee.Global;
using final_oosee.Bridge;
using final_oosee.Business;

namespace final_oosee.StudentInterfaces
{
    public partial class StudentApplied_Form : Form
    {
        public StudentApplied_Form()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvAppliedJob.DataSource = util.GetStudentAppliedListBasedOnStudentID(util.studentID);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            AbstractManager manager = new AbstractManager(new BLStudentApplied());
            manager.Delete();
            LoadData();
        }

        private void dgvAppliedJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAppliedJob.CurrentCell.RowIndex;
            util.studentAppliedID = Convert.ToInt32(dgvAppliedJob.Rows[r].Cells[0].Value.ToString());
        }
    }
}

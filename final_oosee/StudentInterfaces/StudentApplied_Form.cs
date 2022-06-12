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
    }
}

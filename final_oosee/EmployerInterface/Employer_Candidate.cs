using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_oosee.Bridge;
using final_oosee.Business;
using final_oosee.Global;

namespace final_oosee.EmployerInterface
{
    public partial class Employer_Candidate : Form
    {
        //This form use to see list of student applied to this emplyer's job
        List<JOB> jobList;
        List<studentApplied> studentAppliedList;

        public Employer_Candidate(List<JOB> jobs)
        {
            InitializeComponent();
            if(studentAppliedList == null)
            {
                studentAppliedList = new List<studentApplied>();
            }
            if(jobList == null)
            {
                jobList = new List<JOB>();
            }

            //Get jobList of this employer
            this.jobList = jobs;
            //Base on jobID in the Job list -> get student who applied to the job
            foreach(JOB job in jobList)
            {
                studentAppliedList.AddRange(util.GetStudentAppliedList(job.ID));
            }
            //Show the studentAppliedList to the UI
            dgvCandidateList.DataSource = studentAppliedList;
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

        private void dgvCandidateList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Employer_StudentDetail stuDetail = new Employer_StudentDetail();

        }
    }
}

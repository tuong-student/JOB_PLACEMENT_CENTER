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

        AbstractManager manager;
        BLStudentApplied blStudentApplied;

        public Employer_Candidate()
        {
            InitializeComponent();
            blStudentApplied = new BLStudentApplied();
            manager = new AbstractManager(blStudentApplied);
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.FromArgb(180, 4, 36), ButtonBorderStyle.Solid);
        }

        private void dgvCandidateList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCandidateList.CurrentCell.RowIndex;
            util.studentID = Convert.ToInt32(dgvCandidateList.Rows[r].Cells[1].Value.ToString());
            util.jobAppliedID = Convert.ToInt32(dgvCandidateList.Rows[r].Cells[0].Value.ToString());
            STUDENT student = util.GetStudent(util.studentID);
            studentApplied stApplied = util.GetStudentApplied(util.jobAppliedID);
            Employer_StudentDetail stuDetail_Form = new Employer_StudentDetail(student, stApplied);
            stuDetail_Form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void EmployerCandidate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            studentAppliedList = new List<studentApplied>();
            jobList = new List<JOB>();
            //Get the job list from DB
            jobList = util.GetJobList(util.employerID);
            //Base on jobID in the Job list -> get student who applied to the job
            foreach (JOB job in jobList)
            {
                studentAppliedList.AddRange(util.GetStudentAppliedList(job.ID));
            }
            //Show the studentAppliedList to the UI
            dgvCandidateList.DataSource = studentAppliedList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<studentApplied> oldData = studentAppliedList;
            List<studentApplied> result = new List<studentApplied>();
            foreach(JOB job in jobList)
            {
                result.AddRange(util.SearchStudentAppliedBaseOnKeyWord(txtSearch.Text, job.ID));
            }
            dgvCandidateList.DataSource = result;

            if(txtSearch.Text == "")
            {
                dgvCandidateList.DataSource = oldData;
            }
        }
    }
}

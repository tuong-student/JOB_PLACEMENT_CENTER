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

namespace final_oosee
{
    public partial class StudentHome : Form
    {
        //This form use to see all the job
        AbstractManager manager;
        BLJob blJob;

        public StudentHome()
        {
            InitializeComponent();
            blJob = new BLJob();
            manager = new AbstractManager(blJob);

            //Show job list to UI
            dgvJobList.DataSource = manager.GetTable();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.FromArgb(251, 139, 36), ButtonBorderStyle.Solid);

        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            dgvJobList.DataSource = manager.GetTable();
        }

        private void dgvJobList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvJobList.CurrentCell.RowIndex;
            int jobID = Convert.ToInt32(dgvJobList.Rows[r].Cells[0].Value.ToString());
            util.jobID = jobID;
            JOB job = util.GetJob(jobID);
            JobDetail_Form jobDetail_Form = new JobDetail_Form(job);
            jobDetail_Form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            manager.Search(dgvJobList, txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var result = jobManagemetDataContext.JOBs.Where(P => P.wagePerHour > 0);
            //Search Place
            string address = cbPlace.Text.Trim();

            //Search salary
            switch (cbSalary.Text)
            {
                case "< 50.000đ":
                    result = jobManagemetDataContext.JOBs.Where(P => P.wagePerHour <= 50000 && P.address.Contains(address));
                    break;
                case "50.000 - 100.000đ":
                    result = jobManagemetDataContext.JOBs.Where(P => (P.wagePerHour >= 50 || P.wagePerHour <= 100) && P.address.Contains(address));
                    break;
                case "100.000 - 200.000đ":
                    result = jobManagemetDataContext.JOBs.Where(P => (P.wagePerHour >= 100000 || P.wagePerHour <= 200000) && P.address.Contains(address));
                    break;
                case "> 200.000đ":
                    result = jobManagemetDataContext.JOBs.Where(P => P.wagePerHour >= 200000 && P.address.Contains(address));
                    break;
            }

            dgvJobList.DataSource = result.ToList();
        }
    }
}

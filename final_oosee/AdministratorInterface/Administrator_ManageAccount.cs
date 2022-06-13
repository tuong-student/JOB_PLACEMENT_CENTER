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

namespace final_oosee.AdministratorInterface
{
    public partial class Administrator_ManageAccount : Form
    {
        AbstractManager manager, subManger;
        BLUser blUser;

        public Administrator_ManageAccount()
        {
            InitializeComponent();
            blUser = new BLUser();
            manager = new AbstractManager(blUser);

            //Show user table to UI
            dgvUserData.DataSource = manager.GetTable();
        }

        private void dgvUserData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Index of the current row
            int r = dgvUserData.CurrentCell.RowIndex;
            txtID.Text = dgvUserData.Rows[r].Cells[0].Value.ToString();
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            util.userID = Convert.ToInt32(txtID.Text);
            if (dgvUserData.CurrentRow.Cells[3].Value.ToString() == "student")
            {
                STUDENT stu = new STUDENT();
                stu = util.GetStudentBaseOnUserID(util.userID);
                util.DeleteAppliedBasedOnStudentID(stu.ID);
                subManger = new AbstractManager(new BLStudent());
                subManger.DeleteBaseOnUserID(); //Delete in student table
            }
            else
            {
                EMPLOYER em = new EMPLOYER();
                em = util.GetEmployerBaseOnUserID(util.userID);
                List<JOB> jobs = util.GetJobList(em.ID);
                foreach(JOB job in jobs)
                {
                    util.DeleteAppliedBasedOnJobID(job.ID); //Delete the job in studentApplied table
                }
                util.DeleteJobBasedOnEmployerID(em.ID); //Delete the job in job table
                subManger = new AbstractManager(new BLEmployer());
                subManger.DeleteBaseOnUserID(); //Delete in employer table
            }
            manager.Delete(); //Delete in user table
            dgvUserData.DataSource = manager.GetTable();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            manager.Search(dgvUserData, txtSearch.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;
using final_oosee.Global;
using final_oosee.Business;


namespace final_oosee.EmployerInterface
{
    public partial class Employer_EventManager : Form
    {
        List<JOB> jobList;

        //This form use to see and add the job of this company.
        public Employer_EventManager(List<JOB> jobs)
        {
            //Get emID -> MainForm_Employer do this and store in util.user.ID
            InitializeComponent();
            if(jobList == null)
            {
                jobList = jobs;
                //Get List of Job base on emID
                jobList = util.GetJobList(util.user.ID);
            }
            
            //Show List on UI
            dgvJobEvent.DataSource = jobList;
        }
    }
}

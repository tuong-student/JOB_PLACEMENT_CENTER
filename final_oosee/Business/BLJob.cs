using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_oosee.Global;

namespace final_oosee.Business
{
    internal class BLJob : BusinessLayer
    {
        public bool Delete()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = from st in jobManagemetDataContext.JOBs
                          where st.ID == util.jobID
                          select st;

            jobManagemetDataContext.JOBs.DeleteAllOnSubmit(stQuery);
            jobManagemetDataContext.SubmitChanges();
            return true;
        }

        public ITable GetTable()
        {
            return GetTableObjectClass<JOB>.GetTable();
        }

        public bool Insert()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            JOB jb = new JOB();
            jb.employerID = util.employerID;
            jb.jobName = util.jobName;
            jb.jobDescription = util.jobDescription;
            jb.address = util.address;
            jb.wagePerHour = util.wagePerHours;

            jobManagemetDataContext.JOBs.InsertOnSubmit(jb);
            jobManagemetDataContext.JOBs.Context.SubmitChanges();
            return true;
        }

        public bool Update()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = (from st in jobManagemetDataContext.JOBs
                           where st.ID == util.jobID
                           select st).SingleOrDefault();

            if (stQuery == null)
            {
                stQuery.employerID = util.employerID;
                stQuery.jobName = util.jobName;
                stQuery.jobDescription = util.jobDescription;
                stQuery.address = util.address;
                stQuery.wagePerHour = util.wagePerHours;

                jobManagemetDataContext.SubmitChanges();
            }

            return true;
        }
    }
}

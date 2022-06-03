using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_oosee.Global;

namespace final_oosee.Business
{
    internal class BLStudentApplied : BusinessLayer
    {
        public bool Delete()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = from st in jobManagemetDataContext.studentApplieds
                          where st.ID == util.userID
                          select st;

            jobManagemetDataContext.studentApplieds.DeleteAllOnSubmit(stQuery);
            jobManagemetDataContext.SubmitChanges();
            return true;
        }

        public ITable GetTable()
        {
            return GetTableObjectClass<studentApplied>.GetTable();
        }

        public bool Insert()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            studentApplied stApplied = new studentApplied();
            stApplied.studentID = util.studentID;
            stApplied.jobID = util.jobID;

            jobManagemetDataContext.studentApplieds.InsertOnSubmit(stApplied);
            jobManagemetDataContext.studentApplieds.Context.SubmitChanges();
            return true;
        }

        public bool Update()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = (from st in jobManagemetDataContext.studentApplieds
                           where st.ID == util.studentAppliedID
                           select st).SingleOrDefault();

            if (stQuery == null)
            {
                stQuery.studentID = util.studentID;
                stQuery.jobID = util.jobID;

                jobManagemetDataContext.SubmitChanges();
            }

            return true;
        }
    }
}

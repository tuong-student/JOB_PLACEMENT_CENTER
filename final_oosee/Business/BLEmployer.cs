using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_oosee.Global;

namespace final_oosee.Business
{
    internal class BLEmployer : BusinessLayer
    {
        public bool Delete()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = from st in jobManagemetDataContext.EMPLOYERs
                          where st.ID == util.employerID
                          select st;

            jobManagemetDataContext.EMPLOYERs.DeleteAllOnSubmit(stQuery);
            jobManagemetDataContext.SubmitChanges();
            return true;
        }

        public ITable GetTable()
        {
            return GetTableObjectClass<EMPLOYER>.GetTable();
        }

        public bool Insert()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            EMPLOYER em = new EMPLOYER();
            em.employerName = util.stfullName;
            em.address = util.address;
            em.phoneNumber = util.phoneNumber;
            em.userID = util.userID;

            jobManagemetDataContext.EMPLOYERs.InsertOnSubmit(em);
            jobManagemetDataContext.EMPLOYERs.Context.SubmitChanges();
            return true;
        }

        public bool Update()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = (from st in jobManagemetDataContext.STUDENTs
                           where st.ID == util.studentID
                           select st).SingleOrDefault();

            if (stQuery == null)
            {
                stQuery.fullName = util.stfullName;
                stQuery.dateOfBirth = util.stDateOfBirth;
                stQuery.address = util.address;
                stQuery.gender = util.gender;
                stQuery.healthCondition = util.healthCondition;
                stQuery.phoneNumber = util.phoneNumber;
                stQuery.additionalCondition = util.additionalCondition;
                stQuery.userID = util.userID;

                jobManagemetDataContext.SubmitChanges();
            }

            return true;
        }
    }
}

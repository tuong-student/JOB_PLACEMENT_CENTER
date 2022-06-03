using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using final_oosee.Global;

namespace final_oosee.Business
{
    internal class BLStudent:BusinessLayer
    {
        public bool Insert()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            STUDENT st = new STUDENT();
            st.fullName = util.stfullName;
            st.dateOfBirth = util.stDateOfBirth;
            st.address = util.address;
            st.gender = util.gender;
            st.healthCondition = util.healthCondition;
            st.phoneNumber = util.phoneNumber;
            st.additionalCondition = util.additionalCondition;
            st.userID = util.userID;

            jobManagemetDataContext.STUDENTs.InsertOnSubmit(st);
            jobManagemetDataContext.STUDENTs.Context.SubmitChanges();
            return true;
        }

        public bool Delete()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = from st in jobManagemetDataContext.STUDENTs
                          where st.ID == util.studentID
                          select st;

            jobManagemetDataContext.STUDENTs.DeleteAllOnSubmit(stQuery);
            jobManagemetDataContext.SubmitChanges();
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

        public ITable GetTable()
        {
            return GetTableObjectClass<STUDENT>.GetTable();
        }
    }
}

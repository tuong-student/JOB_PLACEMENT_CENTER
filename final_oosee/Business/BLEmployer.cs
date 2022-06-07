using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public bool DeleteBaseOnUseID()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = from st in jobManagemetDataContext.EMPLOYERs
                          where st.userID == util.userID
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
            em.employerName = util.emName;
            em.address = util.address;
            em.phoneNumber = util.phoneNumber;
            em.userID = util.userID;

            jobManagemetDataContext.EMPLOYERs.InsertOnSubmit(em);
            jobManagemetDataContext.EMPLOYERs.Context.SubmitChanges();
            return true;
        }

        public void Search(DataGridView dgv, string searchKeyWord)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var result = jobManagemetDataContext.EMPLOYERs.Where(P => P.employerName.Contains(searchKeyWord));
            dgv.DataSource = result.ToList();
        }

        public bool Update()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = (from st in jobManagemetDataContext.EMPLOYERs
                           where st.ID == util.employerID
                           select st).SingleOrDefault();

            if (stQuery != null)
            {
                stQuery.employerName = util.emName;
                stQuery.address = util.address;
                stQuery.phoneNumber = util.phoneNumber;
                stQuery.userID = util.user.ID;

                jobManagemetDataContext.SubmitChanges();
            }

            return true;
        }
    }
}

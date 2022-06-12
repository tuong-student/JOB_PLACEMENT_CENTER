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
    internal class BLUser : BusinessLayer
    {
        public bool Delete()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = from st in jobManagemetDataContext.USERS
                          where st.ID == util.userID
                          select st;

            jobManagemetDataContext.USERS.DeleteAllOnSubmit(stQuery);
            jobManagemetDataContext.SubmitChanges();
            return true;
        }

        public bool DeleteBaseOnUseID()
        {
            throw new NotImplementedException();
        }

        public ITable GetTable()
        {
            return GetTableObjectClass<USERS>.GetTable();
        }

        public bool Insert()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            USERS user = new USERS();
            user.username = util.userName;
            user.password = util.password;
            user.role = util.role;

            jobManagemetDataContext.USERS.InsertOnSubmit(user);
            jobManagemetDataContext.USERS.Context.SubmitChanges();
            return true;
        }

        public void Search(DataGridView dgv, string searchKeyWord)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var result = jobManagemetDataContext.USERS.Where(P => P.username.Contains(searchKeyWord) || P.role.Contains(searchKeyWord));
            dgv.DataSource = result.ToList();
        }

        public bool Update()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = (from st in jobManagemetDataContext.USERS
                           where st.ID == util.userID
                           select st).SingleOrDefault();

            if (stQuery != null)
            {
                stQuery.username = util.userName;
                stQuery.password = util.password;
                stQuery.role = util.role;

                jobManagemetDataContext.SubmitChanges();
            }

            return true;
        }
    }
}

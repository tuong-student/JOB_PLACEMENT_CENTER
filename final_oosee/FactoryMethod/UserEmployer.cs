using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_oosee.EmployerInterface;
using final_oosee.Bridge;
using final_oosee.Global;
using final_oosee.Business;

namespace final_oosee.FactoryMethod
{
    internal class UserEmployer : UserInterface
    {
        BLEmployer blEmployer;
        BLUser blUser;
        AbstractManager manager;
        public void OpenForm()
        {
            MainForm_Employer employerForm = new MainForm_Employer();
            employerForm.ShowDialog();
        }

        public void InsertToDB()
        {
            blEmployer = new BLEmployer();
            blUser = new BLUser();
            manager = new AbstractManager(blUser);
            manager.Insert();
            manager = new AbstractManager(blEmployer);
            USERS user = util.GetUserWhenLogin(util.userName);
            util.userID = user.ID;
            manager.Insert();

        }

        public void SetUtil()
        {
            EMPLOYER em = util.GetEmployerBaseOnUserID(util.user.ID);
            util.employerID = em.ID;
            util.emName = em.employerName;
            util.address = em.address;
            util.phoneNumber = em.phoneNumber;
            util.userID = util.user.ID;
        }
    }
}

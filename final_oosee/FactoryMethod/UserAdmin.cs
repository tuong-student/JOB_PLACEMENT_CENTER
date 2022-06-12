using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_oosee.Global;
using final_oosee.AdministratorInterface;
using final_oosee.Business;
using final_oosee.Bridge;

namespace final_oosee.FactoryMethod
{
    internal class UserAdmin : UserInterface
    {
        AbstractManager manager;
        BLUser blUser;
        public void InsertToDB()
        {
            blUser = new BLUser();
            manager = new AbstractManager(blUser);

            manager.Insert();
        }

        public void OpenForm()
        {
            MainForm_Administrator adminForm = new MainForm_Administrator();
            adminForm.ShowDialog();
        }

        public void SetUtil()
        {
            USERS admin = util.GetUserWhenLogin(util.userName);
            util.password = admin.password;
        }
    }
}

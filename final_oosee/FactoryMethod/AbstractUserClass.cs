using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_oosee.FactoryMethod
{
    internal abstract class AbstractUserClass
    {
        public abstract UserInterface CreateUser();

        public void SetUtil()
        {
            UserInterface user = CreateUser();

            user.SetUtil();
            user.OpenForm();
        }

        public void InsertUser()
        {
            UserInterface user = CreateUser();

            user.InsertToDB();
            user.SetUtil();
            user.OpenForm();
        }
    }
}

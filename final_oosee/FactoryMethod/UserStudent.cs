using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_oosee.Business;
using final_oosee.Global;
using final_oosee.Bridge;


namespace final_oosee.FactoryMethod
{
    internal class UserStudent : UserInterface
    {
        AbstractManager manager;
        BLUser blUser;
        BLStudent blStudent;

        public void InsertToDB()
        {
            blUser = new BLUser();
            blStudent = new BLStudent();
            manager = new AbstractManager(blUser);
            manager.Insert();
            manager = new AbstractManager(blStudent);
            USER user = util.GetUserWhenLogin(util.userName);
            util.userID = user.ID;
            manager.Insert();
        }

        public void OpenForm()
        {
            MainForm_Student studentForm = new MainForm_Student();
            studentForm.ShowDialog();
        }

        public void SetUtil()
        {
            STUDENT stu = util.GetStudentBaseOnUserID(util.user.ID);
            util.studentID = stu.ID;
            util.stfullName = stu.fullName;
            util.stDateOfBirth = stu.dateOfBirth;
            util.address = stu.address;
            util.gender = stu.gender;
            util.phoneNumber = stu.phoneNumber;
            util.healthCondition = stu.healthCondition;
            util.additionalCondition = stu.additionalCondition;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_oosee.Business;
using System.Data.Linq;


namespace final_oosee.Global
{
    public static class util
    {
        public static USER user;

        public static string userName;
        public static string password;
        public static string role;

        public static int userID;
        public static int studentID;
        public static int employerID;
        public static int jobID;
        public static int studentAppliedID;  
        public static int jobAppliedID;

        public static string jobDescription; 
        public static int wagePerHours;
        public static string stDateOfBirth;
        public static string address;
        public static string gender;
        public static string phoneNumber;
        public static string healthCondition;
        public static string additionalCondition;
        public static string jobStatus;

        public static string emName;
        public static string stfullName;
        public static string jobName;

        public static Table<EMPLOYER> employerTable;
        public static Table<STUDENT> studentTable;
        public static Table<JOB> jobTable;
        public static Table<USER> userTable;
        public static Table<studentApplied> studentAppliedTable;

        static JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();

        public static EMPLOYER GetEmployer(int employerID)
        {
            return (EMPLOYER)jobManagemetDataContext.EMPLOYERs.Where(P => P.ID == employerID).Single();
        }

        public static EMPLOYER GetEmployerBaseOnUserID(int userID)
        {
            return (EMPLOYER)jobManagemetDataContext.EMPLOYERs.Where(P => P.userID == userID).Single();
        }

        public static STUDENT GetStudent(int studentID)
        {
            STUDENT stu = new STUDENT();
            stu = (STUDENT)jobManagemetDataContext.STUDENTs.Where(P => P.ID == studentID).Single();

            util.studentID = stu.ID;
            util.stfullName = stu.fullName;
            util.stDateOfBirth = stu.dateOfBirth;
            util.address = stu.address;
            util.gender = stu.gender;
            util.phoneNumber = stu.phoneNumber;
            util.healthCondition = stu.healthCondition;
            util.additionalCondition = stu.additionalCondition;
            return stu;
        }

        public static STUDENT GetStudentBaseOnUserID(int userID)
        {
            return (STUDENT) jobManagemetDataContext.STUDENTs.Where(P => P.userID == userID).Single();
        }

        public static JOB GetJob(int jobID)
        {
            return (JOB) jobManagemetDataContext.JOBs.Where(P => P.ID == jobID).Single();
        }

        public static List<JOB> GetJobList(int emID)
        {
            var jobs = jobManagemetDataContext.JOBs.Where(P => P.employerID == emID);

            return jobs.ToList();
        }

        public static USER GetUser(int userID)
        {
            return (USER)jobManagemetDataContext.USERs.Where(P => P.ID == userID).Single();
        }

        public static USER GetUserWhenLogin(string userName)
        {
            try
            {
                util.user = (USER)jobManagemetDataContext.USERs.Where(P => P.username.Equals(userName)).Single();

                return util.user;
            }
            catch
            {
                return null;
            }
        }

        public static List<studentApplied> GetStudentAppliedList(int jobID)
        {
            var result = jobManagemetDataContext.studentApplieds.Where(P => P.jobID == jobID);

            return result.ToList();
        }

        public static studentApplied GetStudentApplied(int studentAppliedID)
        {
            return (studentApplied) jobManagemetDataContext.studentApplieds.Where(p => p.ID == studentAppliedID).Single();
        }

        public static List<studentApplied> SearchStudentAppliedBaseOnKeyWord(string keyWord, int jobID)
        {
            var result = jobManagemetDataContext.studentApplieds.Where(P => P.jobID == jobID && P.jobName.Contains(keyWord));
            return result.ToList();
        }

        public static List<JOB> SearchJobBaseOnKeyWord(string keyWord, int emID)
        {
            var result = jobManagemetDataContext.JOBs.Where(P => P.employerID == emID && (P.jobName.Contains(keyWord) || P.jobDescription.Contains(keyWord) || P.address.Contains(keyWord)));
            return result.ToList();
        }

        public static int GetUserNumber()
        {
            return jobManagemetDataContext.USERs.Count();
        }

        public static int GetStudentNumber()
        {
            return jobManagemetDataContext.STUDENTs.Count();
        }

        public static int GetEmployerNumber()
        {
            return jobManagemetDataContext.EMPLOYERs.Count();
        }

        public static int GetJobNumber()
        {
            return jobManagemetDataContext.JOBs.Count();
        }

        public static int GetStudentAppliedNumber()
        {
            return jobManagemetDataContext.studentApplieds.Count();
        }
    }
}

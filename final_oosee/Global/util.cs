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
        public static USERS user;

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

        public static EMPLOYER GetEmployer(int employerID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return (EMPLOYER)jobManagemetDataContext.EMPLOYERs.Where(P => P.ID == employerID).Single();
        }

        public static EMPLOYER GetEmployerBaseOnUserID(int userID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return (EMPLOYER)jobManagemetDataContext.EMPLOYERs.Where(P => P.userID == userID).Single();
        }

        public static STUDENT GetStudent(int studentID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
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
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return (STUDENT) jobManagemetDataContext.STUDENTs.Where(P => P.userID == userID).Single();
        }

        public static JOB GetJob(int jobID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return (JOB) jobManagemetDataContext.JOBs.Where(P => P.ID == jobID).Single();
        }

        public static List<JOB> GetJobList(int emID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var jobs = jobManagemetDataContext.JOBs.Where(P => P.employerID == emID);

            return jobs.ToList();
        }

        public static USERS GetUser(int userID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return (USERS)jobManagemetDataContext.USERS.Where(P => P.ID == userID).Single();
        }

        public static USERS GetUserWhenLogin(string userName)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            try
            {
                util.user = (USERS)jobManagemetDataContext.USERS.Where(P => P.username.Equals(userName)).Single();

                return util.user;
            }
            catch
            {
                return null;
            }
        }

        public static List<studentApplied> GetStudentAppliedList(int jobID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            jobManagemetDataContext = new JobManagemetDataContext();
            var result = jobManagemetDataContext.studentApplieds.Where(P => P.jobID == jobID);

            return result.ToList();
        }

        public static List<studentApplied> GetStudentAppliedListBasedOnStudentID(int stuID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var result = jobManagemetDataContext.studentApplieds.Where(P => P.studentID == stuID);

            return result.ToList();
        }

        public static studentApplied GetStudentApplied(int studentAppliedID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return (studentApplied) jobManagemetDataContext.studentApplieds.Where(p => p.ID == studentAppliedID).Single();
        }

        public static bool DeleteAppliedBasedOnStudentID(int stuID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = from st in jobManagemetDataContext.studentApplieds
                          where st.studentID == stuID
                          select st;

            jobManagemetDataContext.studentApplieds.DeleteAllOnSubmit(stQuery);
            jobManagemetDataContext.SubmitChanges();
            return true;
        }

        public static bool DeleteAppliedBasedOnJobID(int jobID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var stQuery = from st in jobManagemetDataContext.studentApplieds
                          where st.jobID == jobID
                          select st;

            jobManagemetDataContext.studentApplieds.DeleteAllOnSubmit(stQuery);
            jobManagemetDataContext.SubmitChanges();
            return true;
        }

        public static bool DeleteJobBasedOnEmployerID(int emID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var job = from st in jobManagemetDataContext.JOBs
                          where st.employerID == emID
                          select st;

            jobManagemetDataContext.JOBs.DeleteAllOnSubmit(job);
            jobManagemetDataContext.SubmitChanges();
            return true;
        }

        public static List<studentApplied> SearchStudentAppliedBaseOnKeyWord(string keyWord, int jobID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var result = jobManagemetDataContext.studentApplieds.Where(P => P.jobID == jobID && P.jobName.Contains(keyWord));
            return result.ToList();
        }

        public static List<JOB> SearchJobBaseOnKeyWord(string keyWord, int emID)
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            var result = jobManagemetDataContext.JOBs.Where(P => P.employerID == emID && (P.jobName.Contains(keyWord) || P.jobDescription.Contains(keyWord) || P.address.Contains(keyWord)));
            return result.ToList();
        }

        public static int GetUserNumber()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return jobManagemetDataContext.USERS.Count();
        }

        public static int GetStudentNumber()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return jobManagemetDataContext.STUDENTs.Count();
        }

        public static int GetEmployerNumber()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return jobManagemetDataContext.EMPLOYERs.Count();
        }

        public static int GetJobNumber()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return jobManagemetDataContext.JOBs.Count();
        }

        public static int GetStudentAppliedNumber()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return jobManagemetDataContext.studentApplieds.Count();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_oosee.Business;
using System.Data.Linq;


namespace final_oosee.Global
{
    public static class util
    {
        public static USER user;

        public static int userId;
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
        public static string password;
        public static string role;

        public static string emName;
        public static string stfullName;
        public static string jobName;
        public static string userName;

        public static Table<EMPLOYER> employerList;
        public static Table<STUDENT> studentList;
        public static Table<JOB> jobList;
        public static Table<USER> userList;
        public static Table<studentApplied> studentAppliedList;


        public static EMPLOYER GetEmployer(int employerID)
        {
            if (employerList == null)
            {
                employerList = (Table<EMPLOYER>)GetTableObjectClass<EMPLOYER>.GetTable();
            }

            foreach(EMPLOYER em in employerList)
            {
                if(em.ID == employerID)
                {
                    return em;
                }
            }

            return null;
        }

        public static EMPLOYER GetEmployerBaseOnUserID(int userID)
        {
            if (employerList == null)
            {
                employerList = (Table<EMPLOYER>)GetTableObjectClass<EMPLOYER>.GetTable();
            }

            foreach (EMPLOYER em in employerList)
            {
                if (em.userID == userID)
                {
                    return em;
                }
            }

            return null;
        }

        public static STUDENT GetStudent(int studentID)
        {
            return null;
        }

        public static STUDENT GetStudentBaseOnUserID(int userID)
        {
            if (studentList == null)
            {
                studentList = (Table<STUDENT>)GetTableObjectClass<STUDENT>.GetTable();
            }

            foreach (STUDENT st in studentList)
            {
                if (st.userID == userID)
                {
                    return st;
                }
            }

            return null;
        }

        public static JOB GetJob(int jobID)
        {
            return null;
        }

        public static List<JOB> GetJobList(int emID)
        {
            if(jobList == null)
            {
                jobList = (Table<JOB>)GetTableObjectClass<JOB>.GetTable();
            }

            List<JOB> jobs = new List<JOB>();
            foreach(JOB job in jobList)
            {
                if(job.employerID == emID)
                {
                    jobs.Add(job);
                }
            }

            return jobs;
        }

        public static USER GetUser(int userID)
        {
            if (userList == null)
            {
                userList = (Table<USER>) GetTableObjectClass<USER>.GetTable();
            }

            foreach(USER user in userList)
            {
                if(user.ID == userID)
                {
                    util.user = user;
                    return user;
                }
            }

            return null;
        }

        public static USER GetUserWhenLogin(string userName, string role)
        {
            if (userList == null)
            {
                userList = (Table<USER>)GetTableObjectClass<USER>.GetTable();
            }

            foreach (USER user in userList)
            {
                if (user.username == userName)
                {
                    if(user.role == role)
                    {
                        util.user = user;
                    }
                }
            }

            if (util.user == null)
            {
                //TODO: show error

                return null;
            }

            switch (role)
            {
                case "student":
                    STUDENT stu = util.GetStudentBaseOnUserID(util.user.ID);
                    util.studentID = stu.ID;
                    util.stfullName = stu.fullName;
                    util.stDateOfBirth = stu.dateOfBirth;
                    util.address = stu.address;
                    util.gender = stu.gender;
                    util.phoneNumber = stu.phoneNumber;
                    util.healthCondition = stu.healthCondition;
                    util.additionalCondition = stu.additionalCondition;
                    break;
                case "admin":

                    break;
                case "employer":
                    EMPLOYER em = util.GetEmployerBaseOnUserID(util.user.ID);
                    util.employerID = em.ID;
                    util.emName = em.employerName;
                    util.address = em.address;
                    util.phoneNumber = em.phoneNumber;
                    break;
            }

            return util.user;
        }

        public static List<studentApplied> GetStudentAppliedList(int jobID)
        {
            List<studentApplied> studentApplieds = new List<studentApplied>();
            if (studentAppliedList == null)
            {
                studentAppliedList = (Table<studentApplied>) GetTableObjectClass<studentApplied>.GetTable();
            }

            foreach (studentApplied stApplied in studentAppliedList)
            {
                if (stApplied.jobID == jobID)
                {
                    studentApplieds.Add(stApplied);
                }
            }

            return studentApplieds;
        }

        public static void ShowError()
        {
            //TODO: Show error window if login fail or register fail
        }
    }
}

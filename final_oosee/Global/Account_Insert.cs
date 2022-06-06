using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_oosee.Global;
using final_oosee.FactoryMethod;
using final_oosee.AdministratorInterface;
using final_oosee.EmployerInterface;
using final_oosee.StudentInterfaces;

namespace final_oosee
{
    public partial class Account_Insert : Form
    {
        bool isSignIn = false;
        Account_SignIn signInForm = new Account_SignIn() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Account_SignUp signUpForm = new Account_SignUp() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public Account_Insert()
        {
            InitializeComponent();
            isSignIn = true;
        }

        public void ReplaceSignUpForm()
        {
            signInForm.Hide();
            signUpForm.Show();
            isSignIn = false;
        }

        public void ReplaceSignInForm()
        {
            signUpForm.Hide();
            signInForm.Show();
            isSignIn = true;
        }

        private void Account_Insert_Load(object sender, EventArgs e)
        {
            this.panelAccount_Insert.Controls.Add(signInForm);
            this.panelAccount_Insert.Controls.Add(signUpForm);
            signInForm.Show();
            isSignIn = true;
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelAccount_Insert_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!isSignIn)
            {
                ReplaceSignInForm();
                return;
            }

            //Check if account is correct

            string username = "comA";
            //Sign in success
            util.userName = username;
            util.user = util.GetUserWhenLogin(util.userName);

            this.Hide();
            //Create User (Set util and show form)
            switch(util.user.role)
            {
                case "student":
                    AbstractUserClass student = new StudentClass();
                    student.SetUtil();
                    break;
                case "employer":
                    AbstractUserClass employer = new EmployerClass();
                    employer.SetUtil();
                    break;
                case "admin":
                    AbstractUserClass admin = new AdminClass();
                    admin.SetUtil();
                    break;
            }
            this.Close();
            //Get information from sign in form
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (isSignIn)
            {
                ReplaceSignUpForm();
                return;
            }
            else
            {

                if (signInForm.txtUserName == signInForm.txtUserName && signInForm.txtPassword == signUpForm.txtPassword
                    && signInForm.role == signUpForm.typeOfAccount)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    if (signInForm.role == "student")
                    {
                        MainForm_Student mainForm_Student = new MainForm_Student();
                        mainForm_Student.Show();
                        this.Hide();

                    }
                    if (signInForm.role == "employer")
                    {
                        MainForm_Employer mainForm_Employer = new MainForm_Employer();
                        mainForm_Employer.Show();
                        this.Hide();
                    }
                    if (signInForm.role == "admin")
                    {
                        MainForm_Administrator mainForm_Administrator = new MainForm_Administrator();
                        mainForm_Administrator.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (signInForm.txtUserName != signInForm.txtUserName || signInForm.txtPassword != signUpForm.txtPassword)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng vui lòng đăng nhập lại !");
                    }
                    else if (signInForm.role == null)
                    {
                        MessageBox.Show("Vui lòng chọn kiểu người dùng.");
                    }
                    else if (signInForm.role != signUpForm.typeOfAccount)
                    {
                        MessageBox.Show("Tài khoản không tồn tại vui lòng chọn kiểu người dùng khác !");
                    }
                }
            }

            //Create new user
            string username = "student5";
            string password = "student5";
            string role = "student";

            util.userName = username;
            util.password = password;
            util.role = role;

            switch (util.role)
            {
                case "student":
                    AbstractUserClass student = new StudentClass();
                    student.InsertUser();
                    break;
                case "employer":
                    AbstractUserClass employer = new EmployerClass();
                    employer.InsertUser();
                    break;
                case "admin":
                    AbstractUserClass admin = new AdminClass();
                    admin.InsertUser();
                    break;
            }
        }
    }
}

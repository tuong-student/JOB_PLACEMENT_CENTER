using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using final_oosee.EmployerInterface;
using final_oosee.AdministratorInterface;

namespace final_oosee
{
    public partial class Account_Insert : Form
    {
        bool isSignIn ;
        Account_SignIn signInForm = new Account_SignIn() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Account_SignUp signUpForm = new Account_SignUp() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
       

        public Account_Insert()
        {
            InitializeComponent();
            Global.util.account_Insert = this;
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
            }
            else
            {
                
                if (signInForm.txtUserName == signInForm.txtUserName && signInForm.txtPassword == signUpForm.txtPassword 
                    && signInForm.typeOfAccount == signUpForm.typeOfAccount)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    if(signInForm.typeOfAccount == "student")
                    {
                        MainForm_Student mainForm_Student = new MainForm_Student();
                        mainForm_Student.Show();
                        this.Hide();
                        
                    }
                    if (signInForm.typeOfAccount == "employer")
                    {
                        MainForm_Employer mainForm_Employer = new MainForm_Employer();
                        mainForm_Employer.Show();
                        this.Hide();
                    }
                    if (signInForm.typeOfAccount == "admin")
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
                    else if (signInForm.typeOfAccount == null)
                    {
                        MessageBox.Show("Vui lòng chọn kiểu người dùng.");
                    }
                    else if (signInForm.typeOfAccount != signUpForm.typeOfAccount )
                    {
                        MessageBox.Show("Tài khoản không tồn tại vui lòng chọn kiểu người dùng khác !");
                    }
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (isSignIn)
            {
                ReplaceSignUpForm();
            }
            else
            {
                if(signUpForm == null)
                {
                    MessageBox.Show("Vui lòng điền tên đăng nhập.");
                }
                
                if(signUpForm.txtPassword.Count() < 8)
                {
                    MessageBox.Show("Mật khẩu phải có độ dài trên 8 ký tự.");
                }
                else if(signUpForm.txtRePassword != signUpForm.txtPassword)
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu.");
                }
                else if (signUpForm.typeOfAccount == null)
                {
                    MessageBox.Show("Vui lòng chọn loại người dùng.");
                }
                
                else
                {
                    MessageBox.Show("Đăng ký thành công !");
                    ReplaceSignInForm();
                }

            }
        }
    }
}

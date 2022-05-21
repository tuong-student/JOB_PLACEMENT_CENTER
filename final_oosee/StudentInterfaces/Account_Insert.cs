using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Global.util.account_Insert = this;
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

            //Get information from sign in form
            MessageBox.Show(signInForm.txtUserName);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (isSignIn)
            {
                ReplaceSignUpForm();
                return;
            }
        }
    }
}

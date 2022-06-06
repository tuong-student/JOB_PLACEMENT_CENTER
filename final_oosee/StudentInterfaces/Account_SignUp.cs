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
    public partial class Account_SignUp : Form
    {
        public static Account_SignUp insSignUp;

        public Account_SignUp()
        {
            InitializeComponent();
            insSignUp = this;
        }

        private void Account_SignUp_Load(object sender, EventArgs e){}

        private void txtUsername_signIn_TextChanged(object sender, EventArgs e) { }

        private void panelAccount_Insert_Paint(object sender, PaintEventArgs e) { }

        public String txtUserName{get { return txtUsername_signUp.Text.ToString(); }}
        public String txtPassword{get { return txtPassword_signUp.Text.ToString(); }}
        public String txtRePassword { get { return txtPassword_reEnter.Text.ToString(); } }
        public String typeOfAccount { get; set; }

        private void radioBtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnStudent.Checked)
            {
                typeOfAccount = "student";
            }
            if (radioBtnEmployer.Checked)
            {
                typeOfAccount = "employer";
            }
        }
    }
}

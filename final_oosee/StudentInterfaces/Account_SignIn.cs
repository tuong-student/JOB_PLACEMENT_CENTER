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
    public partial class Account_SignIn : Form
    {
        public Account_SignIn()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        public String txtUserName{get { return txtUsername_signIn.Text.ToString(); }}

        public String txtPassword{get { return txtPassword_signIn.Text.ToString(); }}

        public String typeOfAccount{ get; set; }

        private void radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnStudent.Checked)
            {
                typeOfAccount = "student";
            }
            if (radioBtnAdmin.Checked)
            {
                typeOfAccount = "admin";
            }
            if (radioBtnEmployer.Checked)
            {
                typeOfAccount = "employer";
            }
        }
    }
}

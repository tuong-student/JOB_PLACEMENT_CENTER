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

namespace final_oosee.EmployerInterface
{
    public partial class Employer_InformationRegister : Form
    {
        public Employer_InformationRegister()
        {
            InitializeComponent();
        }

        private void Employer_InformationRegister_Load(object sender, EventArgs e)
        {
            txtComName.Text = util.emName;
            txtAddress.Text = util.address;
            txtPhoneNum.Text = util.phoneNumber;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
using final_oosee.Bridge;
using final_oosee.Business;

namespace final_oosee.EmployerInterface
{
    public partial class Employer_InformationRegister : Form
    {
        AbstractManager manager;
        BLEmployer blEmplyer;

        public Employer_InformationRegister()
        {
            InitializeComponent();
            blEmplyer = new BLEmployer();
            manager = new AbstractManager(blEmplyer);
        }

        private void Employer_InformationRegister_Load(object sender, EventArgs e)
        {
            txtComName.Text = util.emName;
            txtAddress.Text = util.address;
            txtPhoneNum.Text = util.phoneNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            util.emName = txtComName.Text.Trim();
            util.address = txtAddress.Text.Trim();
            util.phoneNumber = txtPhoneNum.Text.Trim();

            manager.Update();
            Employer_InformationRegister_Load(sender, e);
        }
    }
}

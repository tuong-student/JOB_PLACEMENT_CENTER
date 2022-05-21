namespace JOB_PLACEMENT_CENTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Example create User
            User u =  new User { Email = "tanhtuong@gmail.com", Password="alkjsfdljsaf", UserName="kjaslfkjlskjf", Type="ajsfdjskljf" };
            util.user = u;
        }
    }
}
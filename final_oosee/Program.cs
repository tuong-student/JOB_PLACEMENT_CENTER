using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_oosee.EmployerInterface;
using final_oosee.StudentInterfaces;
using final_oosee.AdministratorInterface;
using final_oosee.Notification;


namespace final_oosee
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm_Student());
        }
    }
}

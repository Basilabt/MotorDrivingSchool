using MotorDrivingSchool.Screens.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchool
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLoginScreen());
            }
            catch (Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.ToString()}");
            }
        }
    }
}

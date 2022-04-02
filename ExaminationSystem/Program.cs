using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystem.Forms.Student;
using ExaminationSystem.Forms.Instractor;
using ExaminationSystem.Forms.Main;


namespace ExaminationSystem
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
           Application.Run(new LoginPage());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DIR;
using Controller.Abstract;
using Ninject;
using Controller;
using System.Diagnostics;

namespace UVS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Detect existing instances
            string processName = Process.GetCurrentProcess().ProcessName;
            Process[] instances = Process.GetProcessesByName(processName);

            if (instances.Length > 1)
            {
                return;
            }
            // End of detection

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(NinjectFactory.Resolve<MainForm>());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tools;
using Controller.Abstract;
using Ninject;
using Controller;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(NinjectFactory.Resolve<MainForm>());
        }
    }
}

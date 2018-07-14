using EFCoreWinApp.Custom;
using EFCoreWinApp.Data;
using EFCoreWinApp.Data.Interface;
using EFCoreWinApp.Data.Model;
using EFCoreWinApp.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace EFCoreWinApp
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

            DBInitializer.Seed();

            Global.Container = new UnityContainer();
            Global.Container.RegisterType<EmployeeContext>();
            Global.Container.RegisterType<IEmployee,EmployeeRepository>();
           

            Application.Run(new Form1());
        }
    }
}

using ServiceSetup;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USBViewer
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string [] Args)
        {
            System.Security.Principal.WindowsIdentity wid = System.Security.Principal.WindowsIdentity.GetCurrent();
            System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(wid);

            if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
            {
                if (Args.Length == 1 && Args[0] == "-u")
                {
                    serviceUninstall();
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                serviceUninstall();
            }
            else
            {
                System.Diagnostics.ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Application.ExecutablePath;
                startInfo.Arguments = string.Join(" ", Args ); //Environment.GetCommandLineArgs()
                startInfo.Verb = "runas";
                System.Diagnostics.Process.Start(startInfo);
                System.Windows.Forms.Application.Exit();
            }
                
        }

        private static void serviceUninstall()
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string serviceFileName = location.Substring(0, location.LastIndexOf('\\')) + "\\" + Form1.SERVICE_NAME + ".exe";

            ServiceAPI.UnInstallmyService(serviceFileName);
        }
    }
}

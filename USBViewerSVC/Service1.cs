using Hprose.Server;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USBViewerSVC
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                HproseHttpListenerServer server = new HproseHttpListenerServer("http://localhost:2012/");
                TestService ts = new TestService();
                server.Add("RemoveUSBSTOR", ts);
                server.IsCrossDomainEnabled = true;
                //server.CrossDomainXmlFile = "crossdomain.xml";
                server.Start();
                Debug.WriteLine("Server started.");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        protected override void OnStop()
        {

            Debug.WriteLine("Server stopped.");
        }
    }
}

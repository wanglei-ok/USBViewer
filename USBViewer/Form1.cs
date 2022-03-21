using Hprose.Client;
using Microsoft.Win32;
using ServiceSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USBViewer
{
    public partial class Form1 : Form
    {
        public const string SERVICE_NAME = "UsbViewerSVC";

        public List<UCCard> SelectedCard
        {
            get
            {
                List<UCCard> selectedCard = new List<UCCard>();

                foreach (UCCard card in flowLayoutPanel1.Controls)
                {
                    if (card.BackColor != Color.White)
                    {
                        selectedCard.Add(card);
                    }
                }
                return selectedCard;
            }
        }

        public List<UCCard> AllCard
        {
            get
            {
                List<UCCard> allCard = new List<UCCard>();

                foreach (UCCard card in flowLayoutPanel1.Controls)
                {
                    allCard.Add(card);
                }
                return allCard;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serviceInit();

        }

        private void tsbTrace_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey usbstor = hklm.OpenSubKey(@"SYSTEM\ControlSet001\Enum\USBSTOR");
            foreach( string utype in usbstor.GetSubKeyNames() )
            {
                RegistryKey utypeKey = usbstor.OpenSubKey(utype);
                foreach( string udev in utypeKey.GetSubKeyNames() )
                {
                    RegistryKey udevKey = utypeKey.OpenSubKey(udev);
                    var hids = udevKey.GetValue("HardwareID") as string[];
                    string hid = string.Empty;
                    if (hids != null && hids.Length > 0)
                    {
                        hid = hids[0];
                    }
                    var card = new UCCard();
                    card.lblName.Text = udevKey.GetValue("FriendlyName").ToString();
                    card.lblClass.Text = udevKey.GetValue("Class")?.ToString();
                    card.lblService.Text = udevKey.GetValue("Service").ToString();
                    card.lblClassGUID.Text = udevKey.GetValue("ClassGUID")?.ToString();
                    card.lblDriver.Text = udevKey.GetValue("Driver").ToString();
                    card.lblHID.Text = hid;
                    card.lblDevInstId.Text = $"USBSTOR\\{utype}\\{udev}";

                    card.VID = utype;
                    card.PID = udev;

                    flowLayoutPanel1.Controls.Add(card);

                    udevKey.Close();
                }

                utypeKey.Close();
            }

            usbstor.Close();
        }

        private void tsbLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (UCCard card in flowLayoutPanel1.Controls)
                    {
                        sw.WriteLine("".PadLeft(80, '='));
                        sw.WriteLine("Name: {0}", card.lblName.Text);
                        sw.WriteLine("Class: {0}", card.lblClass.Text);
                        sw.WriteLine("Service: {0}", card.lblService.Text);
                        sw.WriteLine("ClassGUID: {0}", card.lblClassGUID.Text);
                        sw.WriteLine("Driver: {0}", card.lblDriver.Text);
                        sw.WriteLine("HID: {0}", card.lblHID.Text);
                        sw.WriteLine("DevInstId: {0}", card.lblDevInstId.Text);
                    }
                }
            }
        }

        private void eraserAll_Click(object sender, EventArgs e)
        {
            foreach (var card in AllCard)
            {
                removeCard(card);
            }
        }

        private void eraserSelected_Click(object sender, EventArgs e)
        {
            foreach( var card in SelectedCard)
            {
                removeCard(card);
            }
        }

        private void tsbEraser_ButtonClick(object sender, EventArgs e)
        {
            var selectedCard = this.SelectedCard;

            if (selectedCard.Count == 0)
            {
                if (flowLayoutPanel1.Controls.Count == 1
                    || (flowLayoutPanel1.Controls.Count > 1 && MessageBox.Show("确认要删除所有记录吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                {
                    eraserAll_Click(null, null);
                }
            }
            else
            {
                eraserSelected_Click(null, null);
            }
            
        }

        private void serviceInit()
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string serviceFileName = location.Substring(0, location.LastIndexOf('\\')) + "\\" + SERVICE_NAME + ".exe";

            if (!ServiceAPI.IsServiceIsExisted(SERVICE_NAME))
            {
                ServiceAPI.InstallmyService(null, serviceFileName);
            }
            if (!ServiceAPI.IsServiceIsExisted(SERVICE_NAME))
            {
                return;
            }
            ServiceAPI.RunService(SERVICE_NAME);
            tsbEraser.Enabled = true;
        }


        private void removeCard(UCCard card)
        {

            try
            {
                HproseHttpClient client = new HproseHttpClient(" http://localhost:2012/");

                ITestService testService = client.UseService<ITestService>();
                bool droped = testService.RemoveUSBSTOR(card.VID, card.PID);
                if (droped)
                {
                    flowLayoutPanel1.Controls.Remove(card);
                }
                else
                {
                    MessageBox.Show("清除痕迹失败");
                }
            }
            catch
            {
                MessageBox.Show("清除痕迹失败.");
            }

        }

        public interface ITestService
        {
            bool RemoveUSBSTOR(string vid, string pid);
        }

    }
}

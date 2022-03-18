using Microsoft.Win32;
using System;

namespace USBViewerSVC
{
    internal class TestService
    {

        public bool RemoveUSBSTOR(string vid, string pid)
        {
            try
            {
                RegistryKey hklm = Registry.LocalMachine;
                RegistryKey usbstor = hklm.OpenSubKey(@"SYSTEM\ControlSet001\Enum\USBSTOR", true);

                RegistryKey utypeKey = usbstor.OpenSubKey(vid, true);

                utypeKey.DeleteSubKeyTree(pid);
                bool isEmpty = (utypeKey.SubKeyCount == 0);
                utypeKey.Close();

                if (isEmpty)
                {
                    usbstor.DeleteSubKey(vid);
                }
                usbstor.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
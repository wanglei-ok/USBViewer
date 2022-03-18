using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USBViewer
{
    public partial class UCCard : UserControl
    {
        public UCCard()
        {
            InitializeComponent();
        }

        public string VID { get; set; }
        public string PID { get; set; }

        private void UCCard_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void UCCard_Click(object sender, EventArgs e)
        {

            this.BackColor = this.BackColor == Color.White? Color.CornflowerBlue:Color.White;
        }
    }
}

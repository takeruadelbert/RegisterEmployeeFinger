using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegisterEmployeeFinger.src.Class.Forms;
using RegisterEmployeeFinger.src.Class.FingerprintDevice;
using RegisterEmployeeFinger.src.Class.Helper;

namespace RegisterEmployeeFinger.src.Class.Forms
{
    public partial class ScanFinger : Form
    {
        private int EmployeeID;
        private int IndexFinger;
        private int templateLength;
        private Device device;
        private TKHelper tk;

        public ScanFinger(int EmployeeID, int IndexFinger, int templateLength)
        {
            InitializeComponent();
            tk = new TKHelper();
            btnStart.Enabled = false;
            this.EmployeeID = EmployeeID;
            this.IndexFinger = IndexFinger;
            this.templateLength = templateLength;
            labelPreviousQuality.Text = tk.CalculatePercentageTemplateFingerprint(templateLength);
            string fingerType = "";
            switch (this.IndexFinger)
            {
                case 0:
                    fingerType = "Thumb";
                    break;
                case 1:
                    fingerType = "Index Finger";
                    break;
                case 2:
                    fingerType = "Middle Finger";
                    break;
                case 3:
                    fingerType = "Ring Finger";
                    break;
                default:
                    fingerType = "Pinky Finger";
                    break;
            }
            txtFinger.Text = "Type : " + fingerType;
            device = new Device(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dispose();
            device.CloseDevice();
            device.Dispose();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInitDevice_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            device.OpenDevice();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            device.CloseDevice();
        }

        public void SetImage(Image image)
        {
            if (imgScannedFinger.InvokeRequired)
            {
                imgScannedFinger.Invoke(new MethodInvoker(delegate { imgScannedFinger.BackgroundImage = image; }));
            }
        }

        public void SetPresentQuality(string presentQuality)
        {
            // have to invoke this because we want to set the label from another thread.
            if (labelPresentQuality.InvokeRequired)
            {
                labelPresentQuality.Invoke(new MethodInvoker(delegate { labelPresentQuality.Text = presentQuality; }));
            }
        }
    }
}

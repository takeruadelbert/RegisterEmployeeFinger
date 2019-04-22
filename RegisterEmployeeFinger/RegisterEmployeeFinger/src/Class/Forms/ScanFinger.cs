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
using RegisterEmployeeFinger.src.Class.Database;

namespace RegisterEmployeeFinger.src.Class.Forms
{
    public partial class ScanFinger : Form
    {
        private int EmployeeID;
        private int IndexFinger;
        private int templateLength;
        public string DataFinger { get; set; }
        public int DataFingerLength { get; set; }
        public static int TemplateID { get; set; }
        private Device device;
        private TKHelper tk;
        private DB db;
        private FormRegister register;

        public ScanFinger(FormRegister register, int EmployeeID, int IndexFinger, int templateLength)
        {
            InitializeComponent();
            tk = new TKHelper();
            db = new DB();
            btnStart.Enabled = false;
            this.EmployeeID = EmployeeID;
            this.IndexFinger = IndexFinger;
            this.templateLength = templateLength;
            this.DataFinger = "";
            this.register = register;
            labelPreviousQuality.Text = tk.CalculatePercentageTemplateFingerprint(templateLength);
            string fingerType = GetFingerType(this.IndexFinger);
            txtFinger.Text = "Type : " + fingerType;
            device = new Device(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (db.CheckMySQLConnection())
            {
                if (EmployeeID > 0)
                {
                    if (!string.IsNullOrEmpty(DataFinger))
                    {
                        int resultCheck = db.CheckDataFingerExist(EmployeeID, IndexFinger);
                        int effective = 1, template_type = 10, flag = 1;
                        switch (resultCheck)
                        {
                            case 0:
                                string query = "INSERT into hr_template (effective, template_type, template_len, template_str, flag, template_index, employee_id) VALUES("
                                    + effective + "," + template_type + "," + this.DataFingerLength + ",'" + this.DataFinger + "'," + flag + "," + this.IndexFinger + "," + this.EmployeeID + ")";
                                try
                                {
                                    db.Insert(query);
                                    MessageBox.Show("Record has been inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error : Fail to Insert Record into Database.\nMessage : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                break;
                            case 1:
                                if (TemplateID > 0)
                                {
                                    string update_query = "UPDATE hr_template SET template_len = " + this.DataFingerLength + ", template_str = '" + this.DataFinger + "' WHERE id = " + TemplateID;
                                    try
                                    {
                                        db.Update(update_query);
                                        MessageBox.Show("Record has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    } catch(Exception ex)
                                    {
                                        MessageBox.Show("Error : Fail to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Template ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                break;
                            default:
                                MessageBox.Show("Error : Something's wrong when connecting to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Scan Your Finger First.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Error : Invalid Employee ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error : Failed to Connect Database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            device.CloseDevice();
            device.Dispose();
            register.FetchDataEmployee();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dispose();
            device.CloseDevice();
            device.Dispose();
            register.FetchDataEmployee();
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

        private string GetFingerType(int indexFinger)
        {
            string fingerType = "";
            switch (indexFinger)
            {
                case 0:
                    fingerType = "Left Pinky";
                    break;
                case 1:
                    fingerType = "Left Ring";
                    break;
                case 2:
                    fingerType = "Left Middle";
                    break;
                case 3:
                    fingerType = "Left Index";
                    break;
                case 4:
                    fingerType = "Left Thumb";
                    break;
                case 5:
                    fingerType = "Right Thumb";
                    break;
                case 6:
                    fingerType = "Right Index";
                    break;
                case 7:
                    fingerType = "Right Middle";
                    break;
                case 8:
                    fingerType = "Right Ring";
                    break;
                default:
                    fingerType = "Right Pinky";
                    break;
            }
            return fingerType;
        }
    }
}

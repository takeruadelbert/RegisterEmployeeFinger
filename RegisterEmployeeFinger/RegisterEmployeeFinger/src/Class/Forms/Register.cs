using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RegisterEmployeeFinger.src.Class.API;
using RegisterEmployeeFinger.src.Class.Database;
using RegisterEmployeeFinger.src.Class.Forms;

namespace RegisterEmployeeFinger
{
    public partial class FormRegister : Form
    {
        private ScanFinger scanFinger;
        private About about;
        private DatabaseConifg DBConfig;
        private int EmployeeID { get; set; }

        public FormRegister()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            EmployeeID = -1;
            thumb.BackColor = Color.Red;
            ResetDataFingers();
            this.about = new About();
            this.DBConfig = new DatabaseConifg(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNIK_TextChanged(object sender, EventArgs e)
        {
            this.ChangeTextListener("NIK", true);
        }

        private void ChangeTextListener(string field, bool is_textchanged = false)
        {
            if (!is_textchanged)
            {
                if (field == "NIK")
                {
                    txtNIK.Clear();
                }
                else
                {
                    txtEmpName.Clear();
                }
            }
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
            txtNIK.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.ForeColor = Color.WhiteSmoke;
            txtEmpName.ForeColor = Color.WhiteSmoke;
        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {
            this.ChangeTextListener("Nama Pegawai", true);
        }

        private void txtNIK_Click(object sender, EventArgs e)
        {
            if (txtNIK.Text == "NIK")
                this.ChangeTextListener("NIK");
        }

        private void txtEmpName_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "Nama Pegawai")
                this.ChangeTextListener("NAma Pegawai");
        }

        private void txtNIK_KeyDown(object sender, KeyEventArgs e)
        {
            // Keyboard's Enter Event Binding
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtNIK.Text))
                {
                    RestAPI restAPI = new RestAPI();
                    string ip = "http://localhost";
                    string url = "/vms/api/fetch-data-employee";
                    JObject param = new JObject();
                    param["nik"] = txtNIK.Text;

                    var sent_param = JsonConvert.SerializeObject(param);

                    DataResponseFull dataResponse = restAPI.API_Post(ip, url, sent_param);
                    if (dataResponse != null)
                    {
                        switch (dataResponse.Status)
                        {
                            case 205:
                                JObject responseData = dataResponse.Data;

                                // set Employee ID
                                EmployeeID = Convert.ToInt32(responseData["Employee"]["id"].ToString());

                                // set employee name
                                txtEmpName.Text = responseData["Employee"]["full_name"].ToString();

                                // set index finger data if it's already exist.
                                var dataFingerprint = responseData["Template"];
                                if (((JArray)dataFingerprint).Count != 0)
                                {
                                    foreach (JToken template in dataFingerprint)
                                    {
                                        int indexFinger = Convert.ToInt32(template.SelectToken("template_index"));
                                        ChangeIndexFingerColor(indexFinger);

                                        int template_len = Convert.ToInt32(template.SelectToken("template_len"));
                                        SetDataFinger(indexFinger, template_len);
                                    }
                                }
                                else
                                {
                                    ResetIndexFinger();
                                }
                                break;
                            default:
                                EmployeeID = -1;
                                ResetField();
                                MessageBox.Show(dataResponse.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error occurred while retrieving response from server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid NIK : Must be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void thumb_Click(object sender, EventArgs e)
        {

        }

        private void ChangeIndexFingerColor(int index)
        {
            switch (index)
            {
                case 0:
                    thumb.BackColor = Color.Green;
                    break;
                case 1:
                    indexFinger.BackColor = Color.Green;
                    break;
                case 2:
                    middleFinger.BackColor = Color.Green;
                    break;
                case 3:
                    ringFinger.BackColor = Color.Green;
                    break;
                default:
                    pinky.BackColor = Color.Green;
                    break;
            }
        }

        private void ResetIndexFinger()
        {
            thumb.BackColor = Color.Red;
            indexFinger.BackColor = Color.Red;
            middleFinger.BackColor = Color.Red;
            ringFinger.BackColor = Color.Red;
            pinky.BackColor = Color.Red;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Dispose();
                System.Environment.Exit(1);
            }
        }

        private void thumb_Click_1(object sender, EventArgs e)
        {
            if (EmployeeID != -1)
            {
                int template_length = !string.IsNullOrEmpty(dataThumb.Text) ? Convert.ToInt32(dataThumb.Text) : -1;
                scanFinger = new ScanFinger(EmployeeID, 0, template_length);
                scanFinger.Show();
            }
            else
            {
                MessageBox.Show("Invalid Employee ID / Still Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void indexFinger_Click(object sender, EventArgs e)
        {
            if (EmployeeID != -1)
            {
                int template_length = !string.IsNullOrEmpty(dataIndexFinger.Text) ? Convert.ToInt32(dataIndexFinger.Text) : -1;
                scanFinger = new ScanFinger(EmployeeID, 1, template_length);
                scanFinger.Show();
            }
            else
            {
                MessageBox.Show("Invalid Employee ID / Still Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void middleFinger_Click(object sender, EventArgs e)
        {
            if (EmployeeID != -1)
            {
                int template_length = !string.IsNullOrEmpty(dataMiddleFinger.Text) ? Convert.ToInt32(dataMiddleFinger.Text) : -1;
                scanFinger = new ScanFinger(EmployeeID, 2, template_length);
                scanFinger.Show();
            }
            else
            {
                MessageBox.Show("Invalid Employee ID / Still Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ringFinger_Click(object sender, EventArgs e)
        {
            if (EmployeeID != -1)
            {
                int template_length = !string.IsNullOrEmpty(dataRingFinger.Text) ? Convert.ToInt32(dataRingFinger.Text) : -1;
                scanFinger = new ScanFinger(EmployeeID, 3, template_length);
                scanFinger.Show();
            }
            else
            {
                MessageBox.Show("Invalid Employee ID / Still Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void pinky_Click(object sender, EventArgs e)
        {
            if (EmployeeID != -1)
            {
                int template_length = !string.IsNullOrEmpty(dataPinkyFinger.Text) ? Convert.ToInt32(dataPinkyFinger.Text) : -1;
                scanFinger = new ScanFinger(EmployeeID, 4, template_length);
                scanFinger.Show();
            }
            else
            {
                MessageBox.Show("Invalid Employee ID / Still Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ResetField()
        {
            txtEmpName.Text = "Nama Pegawai";
            txtNIK.Text = "NIK";
        }

        private void ResetDataFingers()
        {
            dataThumb.Text = "";
            dataIndexFinger.Text = "";
            dataMiddleFinger.Text = "";
            dataRingFinger.Text = "";
            dataPinkyFinger.Text = "";
        }

        private void SetDataFinger(int templateIndex, int template_len)
        {
            switch(templateIndex)
            {
                case 0:
                    dataThumb.Text = template_len.ToString();
                    break;
                case 1:
                    dataIndexFinger.Text = template_len.ToString();
                    break;
                case 2:
                    dataMiddleFinger.Text = template_len.ToString();
                    break;
                case 3:
                    dataRingFinger.Text = template_len.ToString();
                    break;
                default:
                    dataPinkyFinger.Text = template_len.ToString();
                    break;
            }
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            DBConfig.Show();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!about.Visible)
            {
                about = new About();
                about.Show();
            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip1.Show(this.PointToScreen(e.Location));
            }
        }
    }
}

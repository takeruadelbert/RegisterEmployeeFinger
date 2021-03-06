﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RegisterEmployeeFinger.src.Class.API;
using RegisterEmployeeFinger.src.Class.Database;
using RegisterEmployeeFinger.src.Class.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterEmployeeFinger
{
    public partial class FormRegister : Form
    {
        private ScanFinger scanFinger;
        private About about;
        private DatabaseConifg DBConfig;
        private DB db;
        private int EmployeeID { get; set; }
        private Loading loading;

        public FormRegister()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            EmployeeID = -1;
            thumbRight.BackColor = Color.Red;
            ResetDataFingers();
            this.about = new About();
            //MessageBox.Show("Start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DBConfig = new DatabaseConifg(this);
            this.db = new DB();
            this.loading = new Loading();
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

        private async void txtNIK_KeyDown(object sender, KeyEventArgs e)
        {
            // Keyboard's Enter Event Binding
            if (e.KeyCode == Keys.Enter)
            {
                loading.Visible = true;
                if (db.CheckMySQLConnection())
                {
                    if (!string.IsNullOrEmpty(txtNIK.Text))
                    {
                        ResetDataFingers();
                        ResetIndexFinger();
                        await Task.Run(() => FetchDataEmployee());
                        loading.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid NIK : Must be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        loading.Visible = false;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Warning : Please setup database configuration properly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loading.Visible = false;
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
                    pinkyLeft.BackColor = Color.Green;
                    break;
                case 1:
                    ringFingerLeft.BackColor = Color.Green;
                    break;
                case 2:
                    middleFingerLeft.BackColor = Color.Green;
                    break;
                case 3:
                    indexFingerLeft.BackColor = Color.Green;
                    break;
                case 4:
                    thumbLeft.BackColor = Color.Green;
                    break;
                case 5:
                    thumbRight.BackColor = Color.Green;
                    break;
                case 6:
                    indexFingerRight.BackColor = Color.Green;
                    break;
                case 7:
                    middleFingerRight.BackColor = Color.Green;
                    break;
                case 8:
                    ringFingerRight.BackColor = Color.Green;
                    break;
                default:
                    pinkyRight.BackColor = Color.Green;
                    break;
            }
        }

        private void ResetIndexFinger()
        {
            thumbRight.BackColor = Color.Red;
            indexFingerRight.BackColor = Color.Red;
            middleFingerRight.BackColor = Color.Red;
            ringFingerRight.BackColor = Color.Red;
            pinkyRight.BackColor = Color.Red;

            thumbLeft.BackColor = Color.Red;
            indexFingerLeft.BackColor = Color.Red;
            middleFingerLeft.BackColor = Color.Red;
            ringFingerLeft.BackColor = Color.Red;
            pinkyLeft.BackColor = Color.Red;
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
            SetDataFingerButton(dataThumbRight, thumbRight);
        }

        private void indexFinger_Click(object sender, EventArgs e)
        {
            SetDataFingerButton(dataIndexFingerRight, indexFingerRight);
        }

        private void middleFinger_Click(object sender, EventArgs e)
        {
            SetDataFingerButton(dataMiddleFingerLeft, middleFingerRight);
        }

        private void ringFinger_Click(object sender, EventArgs e)
        {
            SetDataFingerButton(dataRingFingerRight, ringFingerRight);
        }

        private void pinky_Click(object sender, EventArgs e)
        {
            SetDataFingerButton(dataPinkyFingerRight, pinkyRight);
        }

        private void ResetField()
        {
            txtEmpName.Text = "Nama Pegawai";
            txtNIK.Text = "NIK";
        }

        private void ResetDataFingers()
        {
            dataThumbRight.Text = "0";
            dataIndexFingerRight.Text = "0";
            dataMiddleFingerRight.Text = "0";
            dataRingFingerRight.Text = "0";
            dataPinkyFingerRight.Text = "0";

            dataPinkyFingerLeft.Text = "0";
            dataRingFingerLeft.Text = "0";
            dataMiddleFingerLeft.Text = "0";
            dataIndexFingerLeft.Text = "0";
            dataThumbLeft.Text = "0";
        }

        private void SetDataFinger(int templateIndex, int template_len)
        {
            switch (templateIndex)
            {
                case 0:
                    dataPinkyFingerLeft.Text = template_len.ToString();
                    break;
                case 1:
                    dataRingFingerLeft.Text = template_len.ToString();
                    break;
                case 2:
                    dataMiddleFingerLeft.Text = template_len.ToString();
                    break;
                case 3:
                    dataIndexFingerLeft.Text = template_len.ToString();
                    break;
                case 4:
                    dataThumbLeft.Text = template_len.ToString();
                    break;
                case 5:
                    dataThumbRight.Text = template_len.ToString();
                    break;
                case 6:
                    dataIndexFingerRight.Text = template_len.ToString();
                    break;
                case 7:
                    dataMiddleFingerRight.Text = template_len.ToString();
                    break;
                case 8:
                    dataRingFingerRight.Text = template_len.ToString();
                    break;
                default:
                    dataPinkyFingerRight.Text = template_len.ToString();
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

        public void FetchDataEmployee()
        {
            this.Invoke((MethodInvoker)delegate
           {
               string nik = txtNIK.Text;
               IDictionary<string, Object> dataEmployee = db.get_employee(nik);
               int employee_id = (int)dataEmployee["id"];
               string employee_name = dataEmployee["name"].ToString();

               // set Employee ID
               EmployeeID = employee_id;

               // set employee name
               txtEmpName.Text = employee_name;

               // set index finger data if it's already exist.
               List<IDictionary<string, Object>> dataTemplate = db.get_template(employee_id);
               if (dataTemplate.Count > 0)
               {
                   foreach (IDictionary<string, Object> temp in dataTemplate)
                   {
                       int indexFinger = (int)temp["finger"];
                       ChangeIndexFingerColor(indexFinger);

                       int template_length = (int)temp["length"];
                       SetDataFinger(indexFinger, template_length);
                   }
               }
               else
               {
                   ResetDataFingers();
               }
           });
        }

        private void thumbLeft_Click(object sender, EventArgs e)
        {
            SetDataFingerButton(dataThumbLeft, thumbLeft);
        }

        private void indexFingerLeft_Click(object sender, EventArgs e)
        {
            SetDataFingerButton(dataIndexFingerLeft, indexFingerLeft);
        }

        private void middleFingerLeft_Click(object sender, EventArgs e)
        {
            SetDataFingerButton(dataMiddleFingerLeft, middleFingerLeft);
        }

        private void ringFingerLeft_Click(object sender, EventArgs e)
        {
            SetDataFingerButton(dataRingFingerLeft, ringFingerLeft);
        }

        private void SetDataFingerButton(Label finger, Button btnFinger)
        {
            if (EmployeeID != -1)
            {
                int template_length = !string.IsNullOrEmpty(finger.Text) ? Convert.ToInt32(finger.Text) : -1;
                scanFinger = new ScanFinger(this, EmployeeID, Convert.ToInt32(btnFinger.Text) - 1, template_length);
                scanFinger.Show();
            }
            else
            {
                MessageBox.Show("Invalid Employee ID / Still Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void pinkyLeft_Click_1(object sender, EventArgs e)
        {
            SetDataFingerButton(dataPinkyFingerLeft, pinkyLeft);
        }

        private void dataPinkyFingerLeft_Click(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            db = new DB();
            Properties.Settings.Default.Reload();
        }
    }
}

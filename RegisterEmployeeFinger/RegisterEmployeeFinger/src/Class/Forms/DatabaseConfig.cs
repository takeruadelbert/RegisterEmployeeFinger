﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegisterEmployeeFinger.src.Class.Helper;
using RegisterEmployeeFinger.src.Class.Database;

namespace RegisterEmployeeFinger.src.Class.Forms
{
    public partial class DatabaseConifg : Form
    {
        private FormRegister register;
        public string DBHost { get; set; }
        public string DBName { get; set; }
        public string DBUsername { get; set; }
        public string DBPassword { get; set; }

        public DatabaseConifg(FormRegister register)
        {
            InitializeComponent();
            this.register = register;
            InitData();
        }

        private void DatabaseConifg_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        private void InitData()
        {
            if (Properties.Settings.Default.DBHost != string.Empty)
            {
                txtDBHost.Text = Properties.Settings.Default.DBHost;
                this.DBHost = Properties.Settings.Default.DBHost;
            }

            if (Properties.Settings.Default.DBName != string.Empty)
            {
                txtDBName.Text = Properties.Settings.Default.DBName;
                this.DBName = Properties.Settings.Default.DBName;
            }

            if (Properties.Settings.Default.DBUsername != string.Empty)
            {
                txtDBUsername.Text = Properties.Settings.Default.DBUsername;
                this.DBUsername = Properties.Settings.Default.DBUsername;
            }

            if (Properties.Settings.Default.DBPassword != string.Empty)
            {
                txtDBPassword.Text = Properties.Settings.Default.DBPassword;
                this.DBPassword = Properties.Settings.Default.DBPassword;
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Dispose();
                System.Environment.Exit(1);
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string db_host = txtDBHost.Text.ToString();
            string db_name = txtDBName.Text.ToString();
            string db_username = txtDBUsername.Text.ToString();
            string db_password = txtDBPassword.Text.ToString();
            if (this.ValidateFields(db_host, db_name, db_username, db_password))
            {
                Properties.Settings.Default.DBHost = db_host;
                Properties.Settings.Default.DBName = db_name;
                Properties.Settings.Default.DBUsername = db_username;
                Properties.Settings.Default.DBPassword = db_password;
                this.DBHost = db_host;
                this.DBName = db_name;
                this.DBUsername = db_username;
                this.DBPassword = db_password;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();                
                MessageBox.Show("Konfigurasi Database Berhasil Diupdate.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private bool ValidateFields(string db_host, string db_name, string db_username, string db_password)
        {
            bool result = true;
            TKHelper tk = new TKHelper();
            if (string.IsNullOrEmpty(db_host) || db_host == "Host")
            {
                MessageBox.Show("Field 'Host' Belum Diisi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (db_host.ToLower() != "localhost")
            {
                if (!tk.ValidateIPv4(db_host))
                {
                    MessageBox.Show("Invalid Host.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (string.IsNullOrEmpty(db_name) || db_name == "Database Name")
            {
                MessageBox.Show("Field 'Name' Belum Diisi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(db_username) || db_username == "Username")
            {
                MessageBox.Show("Field 'Username' Belum Diisi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(db_password) || db_password == "Password")
            {
                MessageBox.Show("Field 'Password' Belum Diisi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return result;
        }

        private void txtDBHost_TextChanged(object sender, EventArgs e)
        {
            this.TextChangeListener(txtDBHost.Text.ToString(), true);
        }

        private void txtDBHost_Click(object sender, EventArgs e)
        {
            this.TextChangeListener(txtDBHost.Text.ToString());
        }

        private void txtDBName_TextChanged(object sender, EventArgs e)
        {
            this.TextChangeListener(txtDBName.Text.ToString(), true);
        }

        private void txtDBName_Click(object sender, EventArgs e)
        {
            this.TextChangeListener(txtDBName.Text.ToString());
        }

        private void txtDBUsername_TextChanged(object sender, EventArgs e)
        {
            this.TextChangeListener(txtDBUsername.Text.ToString(), true);
        }

        private void txtDBUsername_Click(object sender, EventArgs e)
        {
            this.TextChangeListener(txtDBUsername.Text.ToString());
        }

        private void txtDBPassword_TextChanged(object sender, EventArgs e)
        {
            this.TextChangeListener(txtDBPassword.Text.ToString(), true);
        }

        private void txtDBPassword_Click(object sender, EventArgs e)
        {
            this.TextChangeListener(txtDBPassword.Text.ToString());
        }

        private void TextChangeListener(string fieldName, bool is_textchanged = false)
        {
            if (!is_textchanged)
            {
                if (fieldName == "Host")
                    txtDBHost.Clear();
                if (fieldName == "Database Name")
                    txtDBName.Clear();
                if (fieldName == "Username")
                    txtDBUsername.Clear();
                if (fieldName == "Password")
                    txtDBPassword.Clear();
            }
            txtDBPassword.PasswordChar = '●';
            txtDBHost.ForeColor = Color.FromArgb(78, 184, 206);
            txtDBName.ForeColor = Color.FromArgb(78, 184, 206);
            txtDBUsername.ForeColor = Color.FromArgb(78, 184, 206);
            txtDBPassword.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string serverHost = txtDBHost.Text.ToString();
            string dbName = txtDBName.Text.ToString();
            string username = txtDBUsername.Text.ToString();
            string password = txtDBPassword.Text.ToString();
            if (ValidateFields(serverHost, dbName, username, password))
            {
                DB db = new DB(serverHost, dbName, username, password);
                if (db.CheckMySQLConnection())
                {
                    MessageBox.Show("Connection Established.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to connect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("There's still invalid field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            register.Show();
        }
    }
}

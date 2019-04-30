namespace RegisterEmployeeFinger.src.Class.Forms
{
    partial class DatabaseConifg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConifg));
            this.minimize = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDBHost = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.PictureBox();
            this.txtDBUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.PictureBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.quit = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(665, 9);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(21, 24);
            this.minimize.TabIndex = 28;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDBHost);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.txtDBUsername);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.txtDBName);
            this.groupBox1.Controls.Add(this.txtDBPassword);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.ForeColor = System.Drawing.Color.Wheat;
            this.groupBox1.Location = new System.Drawing.Point(50, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 169);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Configuration";
            // 
            // txtDBHost
            // 
            this.txtDBHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDBHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDBHost.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBHost.ForeColor = System.Drawing.Color.White;
            this.txtDBHost.Location = new System.Drawing.Point(56, 43);
            this.txtDBHost.Name = "txtDBHost";
            this.txtDBHost.Size = new System.Drawing.Size(229, 18);
            this.txtDBHost.TabIndex = 13;
            this.txtDBHost.Text = "Host";
            this.txtDBHost.Click += new System.EventHandler(this.txtDBHost_Click);
            this.txtDBHost.TextChanged += new System.EventHandler(this.txtDBHost_TextChanged);
            // 
            // username
            // 
            this.username.BackgroundImage = global::RegisterEmployeeFinger.Properties.Resources.username5;
            this.username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.username.Location = new System.Drawing.Point(25, 98);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(24, 24);
            this.username.TabIndex = 6;
            this.username.TabStop = false;
            // 
            // txtDBUsername
            // 
            this.txtDBUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDBUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDBUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBUsername.ForeColor = System.Drawing.Color.White;
            this.txtDBUsername.Location = new System.Drawing.Point(56, 102);
            this.txtDBUsername.Name = "txtDBUsername";
            this.txtDBUsername.Size = new System.Drawing.Size(229, 18);
            this.txtDBUsername.TabIndex = 7;
            this.txtDBUsername.Text = "Username";
            this.txtDBUsername.Click += new System.EventHandler(this.txtDBUsername_Click);
            this.txtDBUsername.TextChanged += new System.EventHandler(this.txtDBUsername_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(25, 127);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(260, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(342, 67);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(260, 1);
            this.panel3.TabIndex = 15;
            // 
            // password
            // 
            this.password.BackgroundImage = global::RegisterEmployeeFinger.Properties.Resources.password3;
            this.password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.password.Location = new System.Drawing.Point(342, 98);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(24, 24);
            this.password.TabIndex = 10;
            this.password.TabStop = false;
            // 
            // txtDBName
            // 
            this.txtDBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDBName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDBName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBName.ForeColor = System.Drawing.Color.White;
            this.txtDBName.Location = new System.Drawing.Point(374, 43);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(228, 18);
            this.txtDBName.TabIndex = 17;
            this.txtDBName.Text = "Database Name";
            this.txtDBName.Click += new System.EventHandler(this.txtDBName_Click);
            this.txtDBName.TextChanged += new System.EventHandler(this.txtDBName_TextChanged);
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDBPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBPassword.ForeColor = System.Drawing.Color.White;
            this.txtDBPassword.Location = new System.Drawing.Point(374, 102);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.Size = new System.Drawing.Size(228, 18);
            this.txtDBPassword.TabIndex = 11;
            this.txtDBPassword.Text = "Password";
            this.txtDBPassword.Click += new System.EventHandler(this.txtDBPassword_Click);
            this.txtDBPassword.TextChanged += new System.EventHandler(this.txtDBPassword_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::RegisterEmployeeFinger.Properties.Resources.database;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(342, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(342, 126);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(260, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(25, 68);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel4.Size = new System.Drawing.Size(260, 1);
            this.panel4.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::RegisterEmployeeFinger.Properties.Resources.host;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(25, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.Color.White;
            this.quit.Location = new System.Drawing.Point(687, 11);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(24, 24);
            this.quit.TabIndex = 24;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.save.Location = new System.Drawing.Point(312, 341);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(111, 34);
            this.save.TabIndex = 25;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(314, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 78);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConnection.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnTestConnection.Location = new System.Drawing.Point(446, 341);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(125, 34);
            this.btnTestConnection.TabIndex = 29;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.back.Location = new System.Drawing.Point(179, 341);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(111, 34);
            this.back.TabIndex = 26;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // DatabaseConifg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(723, 425);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseConifg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.Load += new System.EventHandler(this.DatabaseConifg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDBHost;
        private System.Windows.Forms.PictureBox username;
        private System.Windows.Forms.TextBox txtDBUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox password;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.TextBox txtDBPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label quit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button back;
    }
}
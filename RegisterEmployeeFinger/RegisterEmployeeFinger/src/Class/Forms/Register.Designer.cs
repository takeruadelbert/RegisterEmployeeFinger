namespace RegisterEmployeeFinger
{
    partial class FormRegister
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNIK = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.thumb = new System.Windows.Forms.Button();
            this.indexFinger = new System.Windows.Forms.Button();
            this.middleFinger = new System.Windows.Forms.Button();
            this.ringFinger = new System.Windows.Forms.Button();
            this.pinky = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNote1 = new System.Windows.Forms.Button();
            this.labelNote2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataThumb = new System.Windows.Forms.Label();
            this.dataIndexFinger = new System.Windows.Forms.Label();
            this.dataMiddleFinger = new System.Windows.Forms.Label();
            this.dataRingFinger = new System.Windows.Forms.Label();
            this.dataPinkyFinger = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtNIK);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(47, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(394, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 12;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtEmpName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.ForeColor = System.Drawing.Color.White;
            this.txtEmpName.Location = new System.Drawing.Point(449, 36);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(187, 18);
            this.txtEmpName.TabIndex = 11;
            this.txtEmpName.Text = "Nama Pegawai";
            this.txtEmpName.Click += new System.EventHandler(this.txtEmpName_Click);
            this.txtEmpName.TextChanged += new System.EventHandler(this.txtEmpName_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::RegisterEmployeeFinger.Properties.Resources.employee;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(394, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 42);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(34, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 9;
            // 
            // txtNIK
            // 
            this.txtNIK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtNIK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIK.ForeColor = System.Drawing.Color.White;
            this.txtNIK.Location = new System.Drawing.Point(89, 35);
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Size = new System.Drawing.Size(187, 18);
            this.txtNIK.TabIndex = 8;
            this.txtNIK.Text = "NIK";
            this.txtNIK.Click += new System.EventHandler(this.txtNIK_Click);
            this.txtNIK.TextChanged += new System.EventHandler(this.txtNIK_TextChanged);
            this.txtNIK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNIK_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::RegisterEmployeeFinger.Properties.Resources.nik;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(34, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // thumb
            // 
            this.thumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.thumb.BackColor = System.Drawing.Color.Red;
            this.thumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thumb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thumb.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.thumb.Location = new System.Drawing.Point(256, 377);
            this.thumb.Name = "thumb";
            this.thumb.Size = new System.Drawing.Size(22, 26);
            this.thumb.TabIndex = 7;
            this.thumb.Text = "1";
            this.thumb.UseVisualStyleBackColor = false;
            this.thumb.Click += new System.EventHandler(this.thumb_Click_1);
            // 
            // indexFinger
            // 
            this.indexFinger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.indexFinger.BackColor = System.Drawing.Color.Red;
            this.indexFinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.indexFinger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indexFinger.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexFinger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.indexFinger.Location = new System.Drawing.Point(296, 314);
            this.indexFinger.Name = "indexFinger";
            this.indexFinger.Size = new System.Drawing.Size(22, 26);
            this.indexFinger.TabIndex = 8;
            this.indexFinger.Text = "2";
            this.indexFinger.UseVisualStyleBackColor = false;
            this.indexFinger.Click += new System.EventHandler(this.indexFinger_Click);
            // 
            // middleFinger
            // 
            this.middleFinger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.middleFinger.BackColor = System.Drawing.Color.Red;
            this.middleFinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.middleFinger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middleFinger.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleFinger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.middleFinger.Location = new System.Drawing.Point(373, 265);
            this.middleFinger.Name = "middleFinger";
            this.middleFinger.Size = new System.Drawing.Size(22, 26);
            this.middleFinger.TabIndex = 9;
            this.middleFinger.Text = "3";
            this.middleFinger.UseVisualStyleBackColor = false;
            this.middleFinger.Click += new System.EventHandler(this.middleFinger_Click);
            // 
            // ringFinger
            // 
            this.ringFinger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ringFinger.BackColor = System.Drawing.Color.Red;
            this.ringFinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ringFinger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ringFinger.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ringFinger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ringFinger.Location = new System.Drawing.Point(424, 280);
            this.ringFinger.Name = "ringFinger";
            this.ringFinger.Size = new System.Drawing.Size(22, 26);
            this.ringFinger.TabIndex = 10;
            this.ringFinger.Text = "4";
            this.ringFinger.UseVisualStyleBackColor = false;
            this.ringFinger.Click += new System.EventHandler(this.ringFinger_Click);
            // 
            // pinky
            // 
            this.pinky.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pinky.BackColor = System.Drawing.Color.Red;
            this.pinky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pinky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinky.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pinky.Location = new System.Drawing.Point(472, 325);
            this.pinky.Name = "pinky";
            this.pinky.Size = new System.Drawing.Size(22, 26);
            this.pinky.TabIndex = 11;
            this.pinky.Text = "5";
            this.pinky.UseVisualStyleBackColor = false;
            this.pinky.Click += new System.EventHandler(this.pinky_Click);
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(742, 7);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(21, 24);
            this.minimize.TabIndex = 13;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(766, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNote1
            // 
            this.labelNote1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote1.BackColor = System.Drawing.Color.Red;
            this.labelNote1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.labelNote1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNote1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.labelNote1.Location = new System.Drawing.Point(47, 427);
            this.labelNote1.Name = "labelNote1";
            this.labelNote1.Size = new System.Drawing.Size(22, 26);
            this.labelNote1.TabIndex = 14;
            this.labelNote1.UseVisualStyleBackColor = false;
            // 
            // labelNote2
            // 
            this.labelNote2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote2.BackColor = System.Drawing.Color.Green;
            this.labelNote2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.labelNote2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNote2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.labelNote2.Location = new System.Drawing.Point(47, 473);
            this.labelNote2.Name = "labelNote2";
            this.labelNote2.Size = new System.Drawing.Size(22, 26);
            this.labelNote2.TabIndex = 15;
            this.labelNote2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Unregistered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Registered";
            // 
            // dataThumb
            // 
            this.dataThumb.AutoSize = true;
            this.dataThumb.Location = new System.Drawing.Point(728, 441);
            this.dataThumb.Name = "dataThumb";
            this.dataThumb.Size = new System.Drawing.Size(60, 13);
            this.dataThumb.TabIndex = 18;
            this.dataThumb.Text = "data thumb";
            this.dataThumb.Visible = false;
            // 
            // dataIndexFinger
            // 
            this.dataIndexFinger.AutoSize = true;
            this.dataIndexFinger.Location = new System.Drawing.Point(728, 462);
            this.dataIndexFinger.Name = "dataIndexFinger";
            this.dataIndexFinger.Size = new System.Drawing.Size(85, 13);
            this.dataIndexFinger.TabIndex = 19;
            this.dataIndexFinger.Text = "data index finger";
            this.dataIndexFinger.Visible = false;
            // 
            // dataMiddleFinger
            // 
            this.dataMiddleFinger.AutoSize = true;
            this.dataMiddleFinger.Location = new System.Drawing.Point(728, 481);
            this.dataMiddleFinger.Name = "dataMiddleFinger";
            this.dataMiddleFinger.Size = new System.Drawing.Size(90, 13);
            this.dataMiddleFinger.TabIndex = 20;
            this.dataMiddleFinger.Text = "data middle finger";
            this.dataMiddleFinger.Visible = false;
            // 
            // dataRingFinger
            // 
            this.dataRingFinger.AutoSize = true;
            this.dataRingFinger.Location = new System.Drawing.Point(728, 501);
            this.dataRingFinger.Name = "dataRingFinger";
            this.dataRingFinger.Size = new System.Drawing.Size(48, 13);
            this.dataRingFinger.TabIndex = 21;
            this.dataRingFinger.Text = "data ring";
            this.dataRingFinger.Visible = false;
            // 
            // dataPinkyFinger
            // 
            this.dataPinkyFinger.AutoSize = true;
            this.dataPinkyFinger.Location = new System.Drawing.Point(728, 523);
            this.dataPinkyFinger.Name = "dataPinkyFinger";
            this.dataPinkyFinger.Size = new System.Drawing.Size(56, 13);
            this.dataPinkyFinger.TabIndex = 22;
            this.dataPinkyFinger.Text = "data pinky";
            this.dataPinkyFinger.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 48);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Image = global::RegisterEmployeeFinger.Properties.Resources.database;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Image = global::RegisterEmployeeFinger.Properties.Resources.version;
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::RegisterEmployeeFinger.Properties.Resources.setting_icon;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(10, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::RegisterEmployeeFinger.Properties.Resources.all_finger;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(284, 287);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(188, 212);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RegisterEmployeeFinger.Properties.Resources.stn;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(324, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataPinkyFinger);
            this.Controls.Add(this.dataRingFinger);
            this.Controls.Add(this.dataMiddleFinger);
            this.Controls.Add(this.dataIndexFinger);
            this.Controls.Add(this.dataThumb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNote2);
            this.Controls.Add(this.labelNote1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinky);
            this.Controls.Add(this.ringFinger);
            this.Controls.Add(this.middleFinger);
            this.Controls.Add(this.indexFinger);
            this.Controls.Add(this.thumb);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Register Employee Fingerprint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNIK;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button thumb;
        private System.Windows.Forms.Button indexFinger;
        private System.Windows.Forms.Button middleFinger;
        private System.Windows.Forms.Button ringFinger;
        private System.Windows.Forms.Button pinky;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button labelNote1;
        private System.Windows.Forms.Button labelNote2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dataThumb;
        private System.Windows.Forms.Label dataIndexFinger;
        private System.Windows.Forms.Label dataMiddleFinger;
        private System.Windows.Forms.Label dataRingFinger;
        private System.Windows.Forms.Label dataPinkyFinger;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
    }
}


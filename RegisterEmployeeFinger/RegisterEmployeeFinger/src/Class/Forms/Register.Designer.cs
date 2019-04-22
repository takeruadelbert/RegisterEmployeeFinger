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
            this.thumbRight = new System.Windows.Forms.Button();
            this.indexFingerRight = new System.Windows.Forms.Button();
            this.middleFingerRight = new System.Windows.Forms.Button();
            this.ringFingerRight = new System.Windows.Forms.Button();
            this.pinkyRight = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNote1 = new System.Windows.Forms.Button();
            this.labelNote2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataThumbRight = new System.Windows.Forms.Label();
            this.dataIndexFingerRight = new System.Windows.Forms.Label();
            this.dataMiddleFingerRight = new System.Windows.Forms.Label();
            this.dataRingFingerRight = new System.Windows.Forms.Label();
            this.dataPinkyFingerRight = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.dataPinkyFingerLeft = new System.Windows.Forms.Label();
            this.dataRingFingerLeft = new System.Windows.Forms.Label();
            this.dataMiddleFingerLeft = new System.Windows.Forms.Label();
            this.dataIndexFingerLeft = new System.Windows.Forms.Label();
            this.dataThumbLeft = new System.Windows.Forms.Label();
            this.thumbLeft = new System.Windows.Forms.Button();
            this.indexFingerLeft = new System.Windows.Forms.Button();
            this.middleFingerLeft = new System.Windows.Forms.Button();
            this.ringFingerLeft = new System.Windows.Forms.Button();
            this.pinkyLeft = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            // thumbRight
            // 
            this.thumbRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbRight.BackColor = System.Drawing.Color.Red;
            this.thumbRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thumbRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thumbRight.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thumbRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.thumbRight.Location = new System.Drawing.Point(432, 392);
            this.thumbRight.Name = "thumbRight";
            this.thumbRight.Size = new System.Drawing.Size(22, 26);
            this.thumbRight.TabIndex = 7;
            this.thumbRight.Text = "6";
            this.thumbRight.UseVisualStyleBackColor = false;
            this.thumbRight.Click += new System.EventHandler(this.thumb_Click_1);
            // 
            // indexFingerRight
            // 
            this.indexFingerRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.indexFingerRight.BackColor = System.Drawing.Color.Red;
            this.indexFingerRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.indexFingerRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indexFingerRight.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexFingerRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.indexFingerRight.Location = new System.Drawing.Point(472, 329);
            this.indexFingerRight.Name = "indexFingerRight";
            this.indexFingerRight.Size = new System.Drawing.Size(22, 26);
            this.indexFingerRight.TabIndex = 8;
            this.indexFingerRight.Text = "7";
            this.indexFingerRight.UseVisualStyleBackColor = false;
            this.indexFingerRight.Click += new System.EventHandler(this.indexFinger_Click);
            // 
            // middleFingerRight
            // 
            this.middleFingerRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.middleFingerRight.BackColor = System.Drawing.Color.Red;
            this.middleFingerRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.middleFingerRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middleFingerRight.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleFingerRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.middleFingerRight.Location = new System.Drawing.Point(549, 280);
            this.middleFingerRight.Name = "middleFingerRight";
            this.middleFingerRight.Size = new System.Drawing.Size(22, 26);
            this.middleFingerRight.TabIndex = 9;
            this.middleFingerRight.Text = "8";
            this.middleFingerRight.UseVisualStyleBackColor = false;
            this.middleFingerRight.Click += new System.EventHandler(this.middleFinger_Click);
            // 
            // ringFingerRight
            // 
            this.ringFingerRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ringFingerRight.BackColor = System.Drawing.Color.Red;
            this.ringFingerRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ringFingerRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ringFingerRight.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ringFingerRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ringFingerRight.Location = new System.Drawing.Point(600, 295);
            this.ringFingerRight.Name = "ringFingerRight";
            this.ringFingerRight.Size = new System.Drawing.Size(22, 26);
            this.ringFingerRight.TabIndex = 10;
            this.ringFingerRight.Text = "9";
            this.ringFingerRight.UseVisualStyleBackColor = false;
            this.ringFingerRight.Click += new System.EventHandler(this.ringFinger_Click);
            // 
            // pinkyRight
            // 
            this.pinkyRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pinkyRight.BackColor = System.Drawing.Color.Red;
            this.pinkyRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pinkyRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinkyRight.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinkyRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pinkyRight.Location = new System.Drawing.Point(648, 340);
            this.pinkyRight.Name = "pinkyRight";
            this.pinkyRight.Size = new System.Drawing.Size(27, 26);
            this.pinkyRight.TabIndex = 11;
            this.pinkyRight.Text = "10";
            this.pinkyRight.UseVisualStyleBackColor = false;
            this.pinkyRight.Click += new System.EventHandler(this.pinky_Click);
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
            this.labelNote1.Location = new System.Drawing.Point(28, 453);
            this.labelNote1.Name = "labelNote1";
            this.labelNote1.Size = new System.Drawing.Size(22, 19);
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
            this.labelNote2.Location = new System.Drawing.Point(28, 484);
            this.labelNote2.Name = "labelNote2";
            this.labelNote2.Size = new System.Drawing.Size(22, 18);
            this.labelNote2.TabIndex = 15;
            this.labelNote2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Unregistered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Registered";
            // 
            // dataThumbRight
            // 
            this.dataThumbRight.AutoSize = true;
            this.dataThumbRight.Location = new System.Drawing.Point(728, 441);
            this.dataThumbRight.Name = "dataThumbRight";
            this.dataThumbRight.Size = new System.Drawing.Size(13, 13);
            this.dataThumbRight.TabIndex = 18;
            this.dataThumbRight.Text = "0";
            this.dataThumbRight.Visible = false;
            // 
            // dataIndexFingerRight
            // 
            this.dataIndexFingerRight.AutoSize = true;
            this.dataIndexFingerRight.Location = new System.Drawing.Point(728, 462);
            this.dataIndexFingerRight.Name = "dataIndexFingerRight";
            this.dataIndexFingerRight.Size = new System.Drawing.Size(13, 13);
            this.dataIndexFingerRight.TabIndex = 19;
            this.dataIndexFingerRight.Text = "0";
            this.dataIndexFingerRight.Visible = false;
            // 
            // dataMiddleFingerRight
            // 
            this.dataMiddleFingerRight.AutoSize = true;
            this.dataMiddleFingerRight.Location = new System.Drawing.Point(728, 481);
            this.dataMiddleFingerRight.Name = "dataMiddleFingerRight";
            this.dataMiddleFingerRight.Size = new System.Drawing.Size(13, 13);
            this.dataMiddleFingerRight.TabIndex = 20;
            this.dataMiddleFingerRight.Text = "0";
            this.dataMiddleFingerRight.Visible = false;
            // 
            // dataRingFingerRight
            // 
            this.dataRingFingerRight.AutoSize = true;
            this.dataRingFingerRight.Location = new System.Drawing.Point(728, 501);
            this.dataRingFingerRight.Name = "dataRingFingerRight";
            this.dataRingFingerRight.Size = new System.Drawing.Size(13, 13);
            this.dataRingFingerRight.TabIndex = 21;
            this.dataRingFingerRight.Text = "0";
            this.dataRingFingerRight.Visible = false;
            // 
            // dataPinkyFingerRight
            // 
            this.dataPinkyFingerRight.AutoSize = true;
            this.dataPinkyFingerRight.Location = new System.Drawing.Point(728, 523);
            this.dataPinkyFingerRight.Name = "dataPinkyFingerRight";
            this.dataPinkyFingerRight.Size = new System.Drawing.Size(13, 13);
            this.dataPinkyFingerRight.TabIndex = 22;
            this.dataPinkyFingerRight.Text = "0";
            this.dataPinkyFingerRight.Visible = false;
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
            this.pictureBox4.Location = new System.Drawing.Point(460, 302);
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
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::RegisterEmployeeFinger.Properties.Resources.left_hand;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(178, 302);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(188, 212);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // dataPinkyFingerLeft
            // 
            this.dataPinkyFingerLeft.AutoSize = true;
            this.dataPinkyFingerLeft.Location = new System.Drawing.Point(343, 531);
            this.dataPinkyFingerLeft.Name = "dataPinkyFingerLeft";
            this.dataPinkyFingerLeft.Size = new System.Drawing.Size(13, 13);
            this.dataPinkyFingerLeft.TabIndex = 30;
            this.dataPinkyFingerLeft.Text = "0";
            this.dataPinkyFingerLeft.Visible = false;
            this.dataPinkyFingerLeft.Click += new System.EventHandler(this.dataPinkyFingerLeft_Click);
            // 
            // dataRingFingerLeft
            // 
            this.dataRingFingerLeft.AutoSize = true;
            this.dataRingFingerLeft.Location = new System.Drawing.Point(343, 509);
            this.dataRingFingerLeft.Name = "dataRingFingerLeft";
            this.dataRingFingerLeft.Size = new System.Drawing.Size(13, 13);
            this.dataRingFingerLeft.TabIndex = 29;
            this.dataRingFingerLeft.Text = "0";
            this.dataRingFingerLeft.Visible = false;
            // 
            // dataMiddleFingerLeft
            // 
            this.dataMiddleFingerLeft.AutoSize = true;
            this.dataMiddleFingerLeft.Location = new System.Drawing.Point(343, 489);
            this.dataMiddleFingerLeft.Name = "dataMiddleFingerLeft";
            this.dataMiddleFingerLeft.Size = new System.Drawing.Size(13, 13);
            this.dataMiddleFingerLeft.TabIndex = 28;
            this.dataMiddleFingerLeft.Text = "0";
            this.dataMiddleFingerLeft.Visible = false;
            // 
            // dataIndexFingerLeft
            // 
            this.dataIndexFingerLeft.AutoSize = true;
            this.dataIndexFingerLeft.Location = new System.Drawing.Point(343, 470);
            this.dataIndexFingerLeft.Name = "dataIndexFingerLeft";
            this.dataIndexFingerLeft.Size = new System.Drawing.Size(13, 13);
            this.dataIndexFingerLeft.TabIndex = 27;
            this.dataIndexFingerLeft.Text = "0";
            this.dataIndexFingerLeft.Visible = false;
            // 
            // dataThumbLeft
            // 
            this.dataThumbLeft.AutoSize = true;
            this.dataThumbLeft.Location = new System.Drawing.Point(343, 449);
            this.dataThumbLeft.Name = "dataThumbLeft";
            this.dataThumbLeft.Size = new System.Drawing.Size(13, 13);
            this.dataThumbLeft.TabIndex = 26;
            this.dataThumbLeft.Text = "0";
            this.dataThumbLeft.Visible = false;
            // 
            // thumbLeft
            // 
            this.thumbLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbLeft.BackColor = System.Drawing.Color.Red;
            this.thumbLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thumbLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thumbLeft.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thumbLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.thumbLeft.Location = new System.Drawing.Point(369, 391);
            this.thumbLeft.Name = "thumbLeft";
            this.thumbLeft.Size = new System.Drawing.Size(22, 26);
            this.thumbLeft.TabIndex = 31;
            this.thumbLeft.Text = "5";
            this.thumbLeft.UseVisualStyleBackColor = false;
            this.thumbLeft.Click += new System.EventHandler(this.thumbLeft_Click);
            // 
            // indexFingerLeft
            // 
            this.indexFingerLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.indexFingerLeft.BackColor = System.Drawing.Color.Red;
            this.indexFingerLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.indexFingerLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indexFingerLeft.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexFingerLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.indexFingerLeft.Location = new System.Drawing.Point(332, 312);
            this.indexFingerLeft.Name = "indexFingerLeft";
            this.indexFingerLeft.Size = new System.Drawing.Size(22, 26);
            this.indexFingerLeft.TabIndex = 32;
            this.indexFingerLeft.Text = "4";
            this.indexFingerLeft.UseVisualStyleBackColor = false;
            this.indexFingerLeft.Click += new System.EventHandler(this.indexFingerLeft_Click);
            // 
            // middleFingerLeft
            // 
            this.middleFingerLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.middleFingerLeft.BackColor = System.Drawing.Color.Red;
            this.middleFingerLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.middleFingerLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middleFingerLeft.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleFingerLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.middleFingerLeft.Location = new System.Drawing.Point(257, 280);
            this.middleFingerLeft.Name = "middleFingerLeft";
            this.middleFingerLeft.Size = new System.Drawing.Size(22, 26);
            this.middleFingerLeft.TabIndex = 33;
            this.middleFingerLeft.Text = "3";
            this.middleFingerLeft.UseVisualStyleBackColor = false;
            this.middleFingerLeft.Click += new System.EventHandler(this.middleFingerLeft_Click);
            // 
            // ringFingerLeft
            // 
            this.ringFingerLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ringFingerLeft.BackColor = System.Drawing.Color.Red;
            this.ringFingerLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ringFingerLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ringFingerLeft.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ringFingerLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ringFingerLeft.Location = new System.Drawing.Point(201, 295);
            this.ringFingerLeft.Name = "ringFingerLeft";
            this.ringFingerLeft.Size = new System.Drawing.Size(22, 26);
            this.ringFingerLeft.TabIndex = 34;
            this.ringFingerLeft.Text = "2";
            this.ringFingerLeft.UseVisualStyleBackColor = false;
            this.ringFingerLeft.Click += new System.EventHandler(this.ringFingerLeft_Click);
            // 
            // pinkyLeft
            // 
            this.pinkyLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pinkyLeft.BackColor = System.Drawing.Color.Red;
            this.pinkyLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pinkyLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinkyLeft.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinkyLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pinkyLeft.Location = new System.Drawing.Point(153, 340);
            this.pinkyLeft.Name = "pinkyLeft";
            this.pinkyLeft.Size = new System.Drawing.Size(22, 26);
            this.pinkyLeft.TabIndex = 35;
            this.pinkyLeft.Text = "1";
            this.pinkyLeft.UseVisualStyleBackColor = false;
            this.pinkyLeft.Click += new System.EventHandler(this.pinkyLeft_Click_1);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.ControlBox = false;
            this.Controls.Add(this.pinkyLeft);
            this.Controls.Add(this.ringFingerLeft);
            this.Controls.Add(this.middleFingerLeft);
            this.Controls.Add(this.indexFingerLeft);
            this.Controls.Add(this.thumbLeft);
            this.Controls.Add(this.dataPinkyFingerLeft);
            this.Controls.Add(this.dataRingFingerLeft);
            this.Controls.Add(this.dataMiddleFingerLeft);
            this.Controls.Add(this.dataIndexFingerLeft);
            this.Controls.Add(this.dataThumbLeft);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataPinkyFingerRight);
            this.Controls.Add(this.dataRingFingerRight);
            this.Controls.Add(this.dataMiddleFingerRight);
            this.Controls.Add(this.dataIndexFingerRight);
            this.Controls.Add(this.dataThumbRight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNote2);
            this.Controls.Add(this.labelNote1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinkyRight);
            this.Controls.Add(this.ringFingerRight);
            this.Controls.Add(this.middleFingerRight);
            this.Controls.Add(this.indexFingerRight);
            this.Controls.Add(this.thumbRight);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.Button thumbRight;
        private System.Windows.Forms.Button indexFingerRight;
        private System.Windows.Forms.Button middleFingerRight;
        private System.Windows.Forms.Button ringFingerRight;
        private System.Windows.Forms.Button pinkyRight;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button labelNote1;
        private System.Windows.Forms.Button labelNote2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dataThumbRight;
        private System.Windows.Forms.Label dataIndexFingerRight;
        private System.Windows.Forms.Label dataMiddleFingerRight;
        private System.Windows.Forms.Label dataRingFingerRight;
        private System.Windows.Forms.Label dataPinkyFingerRight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label dataPinkyFingerLeft;
        private System.Windows.Forms.Label dataRingFingerLeft;
        private System.Windows.Forms.Label dataMiddleFingerLeft;
        private System.Windows.Forms.Label dataIndexFingerLeft;
        private System.Windows.Forms.Label dataThumbLeft;
        private System.Windows.Forms.Button thumbLeft;
        private System.Windows.Forms.Button indexFingerLeft;
        private System.Windows.Forms.Button middleFingerLeft;
        private System.Windows.Forms.Button ringFingerLeft;
        private System.Windows.Forms.Button pinkyLeft;
    }
}


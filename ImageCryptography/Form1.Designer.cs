namespace ImageCryptography
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.creditDone_btn = new System.Windows.Forms.Button();
            this.credits_rtxt = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.receiveImage_tab = new System.Windows.Forms.TabPage();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.decryptImage_btn = new System.Windows.Forms.Button();
            this.saveImage_btn = new System.Windows.Forms.Button();
            this.saveImage_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.receiveRSA_group = new System.Windows.Forms.GroupBox();
            this.sendPublicKey_btn = new System.Windows.Forms.Button();
            this.numberE_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.primeNumber2_txt = new System.Windows.Forms.TextBox();
            this.primeNumber1_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendImage_tab = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectImage_btn = new System.Windows.Forms.Button();
            this.selectImage_txt = new System.Windows.Forms.TextBox();
            this.sendRSA_group = new System.Windows.Forms.GroupBox();
            this.getPublicIP_txt = new System.Windows.Forms.TextBox();
            this.getPublicKey_btn = new System.Windows.Forms.Button();
            this.lbl_pubKey = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.encryptImage_btn = new System.Windows.Forms.Button();
            this.loadImage_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.receiveImage_tab.SuspendLayout();
            this.receiveRSA_group.SuspendLayout();
            this.sendImage_tab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.sendRSA_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(653, 588);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 586);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 104);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(8, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(344, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Image Size:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(344, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Image Resolution: ";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(344, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "File Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(8, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.groupBox2.Size = new System.Drawing.Size(360, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.creditDone_btn);
            this.groupBox6.Controls.Add(this.credits_rtxt);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(0, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(360, 291);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Credits";
            // 
            // creditDone_btn
            // 
            this.creditDone_btn.Location = new System.Drawing.Point(143, 262);
            this.creditDone_btn.Name = "creditDone_btn";
            this.creditDone_btn.Size = new System.Drawing.Size(75, 23);
            this.creditDone_btn.TabIndex = 1;
            this.creditDone_btn.Text = "Done";
            this.creditDone_btn.UseVisualStyleBackColor = true;
            this.creditDone_btn.Click += new System.EventHandler(this.CreditDone);
            // 
            // credits_rtxt
            // 
            this.credits_rtxt.Enabled = false;
            this.credits_rtxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits_rtxt.Location = new System.Drawing.Point(8, 26);
            this.credits_rtxt.Name = "credits_rtxt";
            this.credits_rtxt.Size = new System.Drawing.Size(341, 230);
            this.credits_rtxt.TabIndex = 0;
            this.credits_rtxt.Text = "Developed By:\n    Kishore Prabhakar\n    Likith B.\n    Madhav M Sullad\n    Neeraj " +
    "B.M.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ImageCryptography.Properties.Resources.blank;
            this.pictureBox1.Location = new System.Drawing.Point(8, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.creditToolStripMenuItem.Text = "Credit";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.CreditToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.receiveImage_tab);
            this.tabControl1.Controls.Add(this.sendImage_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(274, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // receiveImage_tab
            // 
            this.receiveImage_tab.Controls.Add(this.progressBar2);
            this.receiveImage_tab.Controls.Add(this.decryptImage_btn);
            this.receiveImage_tab.Controls.Add(this.saveImage_btn);
            this.receiveImage_tab.Controls.Add(this.saveImage_txt);
            this.receiveImage_tab.Controls.Add(this.label5);
            this.receiveImage_tab.Controls.Add(this.receiveRSA_group);
            this.receiveImage_tab.Location = new System.Drawing.Point(4, 28);
            this.receiveImage_tab.Name = "receiveImage_tab";
            this.receiveImage_tab.Padding = new System.Windows.Forms.Padding(3);
            this.receiveImage_tab.Size = new System.Drawing.Size(266, 554);
            this.receiveImage_tab.TabIndex = 1;
            this.receiveImage_tab.Text = "Receive Image";
            this.receiveImage_tab.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(9, 501);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(248, 23);
            this.progressBar2.TabIndex = 18;
            // 
            // decryptImage_btn
            // 
            this.decryptImage_btn.Location = new System.Drawing.Point(9, 455);
            this.decryptImage_btn.Name = "decryptImage_btn";
            this.decryptImage_btn.Size = new System.Drawing.Size(248, 40);
            this.decryptImage_btn.TabIndex = 12;
            this.decryptImage_btn.Text = "Decrypt Image";
            this.decryptImage_btn.UseVisualStyleBackColor = true;
            this.decryptImage_btn.Click += new System.EventHandler(this.DecryptImage);
            // 
            // saveImage_btn
            // 
            this.saveImage_btn.Location = new System.Drawing.Point(220, 415);
            this.saveImage_btn.Name = "saveImage_btn";
            this.saveImage_btn.Size = new System.Drawing.Size(40, 27);
            this.saveImage_btn.TabIndex = 11;
            this.saveImage_btn.Text = "...";
            this.saveImage_btn.UseVisualStyleBackColor = true;
            this.saveImage_btn.Click += new System.EventHandler(this.SaveImage);
            // 
            // saveImage_txt
            // 
            this.saveImage_txt.Enabled = false;
            this.saveImage_txt.Location = new System.Drawing.Point(9, 415);
            this.saveImage_txt.Name = "saveImage_txt";
            this.saveImage_txt.Size = new System.Drawing.Size(208, 27);
            this.saveImage_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Save Image at:";
            // 
            // receiveRSA_group
            // 
            this.receiveRSA_group.Controls.Add(this.sendPublicKey_btn);
            this.receiveRSA_group.Controls.Add(this.numberE_txt);
            this.receiveRSA_group.Controls.Add(this.label3);
            this.receiveRSA_group.Controls.Add(this.primeNumber2_txt);
            this.receiveRSA_group.Controls.Add(this.primeNumber1_txt);
            this.receiveRSA_group.Controls.Add(this.label2);
            this.receiveRSA_group.Controls.Add(this.label1);
            this.receiveRSA_group.Location = new System.Drawing.Point(6, 6);
            this.receiveRSA_group.Name = "receiveRSA_group";
            this.receiveRSA_group.Size = new System.Drawing.Size(254, 248);
            this.receiveRSA_group.TabIndex = 1;
            this.receiveRSA_group.TabStop = false;
            this.receiveRSA_group.Text = "RSA:";
            // 
            // sendPublicKey_btn
            // 
            this.sendPublicKey_btn.Location = new System.Drawing.Point(8, 208);
            this.sendPublicKey_btn.Name = "sendPublicKey_btn";
            this.sendPublicKey_btn.Size = new System.Drawing.Size(240, 32);
            this.sendPublicKey_btn.TabIndex = 6;
            this.sendPublicKey_btn.Text = "Send Public Key";
            this.sendPublicKey_btn.UseVisualStyleBackColor = true;
            this.sendPublicKey_btn.Click += new System.EventHandler(this.SendPublicKey);
            // 
            // numberE_txt
            // 
            this.numberE_txt.Location = new System.Drawing.Point(8, 176);
            this.numberE_txt.Name = "numberE_txt";
            this.numberE_txt.Size = new System.Drawing.Size(240, 27);
            this.numberE_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter \'E\':";
            // 
            // primeNumber2_txt
            // 
            this.primeNumber2_txt.Location = new System.Drawing.Point(8, 112);
            this.primeNumber2_txt.Name = "primeNumber2_txt";
            this.primeNumber2_txt.Size = new System.Drawing.Size(240, 27);
            this.primeNumber2_txt.TabIndex = 3;
            // 
            // primeNumber1_txt
            // 
            this.primeNumber1_txt.Location = new System.Drawing.Point(8, 48);
            this.primeNumber1_txt.Name = "primeNumber1_txt";
            this.primeNumber1_txt.Size = new System.Drawing.Size(240, 27);
            this.primeNumber1_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prime Number 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime Number 1:";
            // 
            // sendImage_tab
            // 
            this.sendImage_tab.Controls.Add(this.label12);
            this.sendImage_tab.Controls.Add(this.send_btn);
            this.sendImage_tab.Controls.Add(this.groupBox1);
            this.sendImage_tab.Controls.Add(this.sendRSA_group);
            this.sendImage_tab.Controls.Add(this.progressBar1);
            this.sendImage_tab.Controls.Add(this.encryptImage_btn);
            this.sendImage_tab.Controls.Add(this.loadImage_btn);
            this.sendImage_tab.Location = new System.Drawing.Point(4, 28);
            this.sendImage_tab.Name = "sendImage_tab";
            this.sendImage_tab.Padding = new System.Windows.Forms.Padding(3);
            this.sendImage_tab.Size = new System.Drawing.Size(266, 554);
            this.sendImage_tab.TabIndex = 0;
            this.sendImage_tab.Text = "Send Image";
            this.sendImage_tab.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 19);
            this.label12.TabIndex = 3;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(8, 487);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(248, 48);
            this.send_btn.TabIndex = 11;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.Send);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectImage_btn);
            this.groupBox1.Controls.Add(this.selectImage_txt);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // selectImage_btn
            // 
            this.selectImage_btn.Location = new System.Drawing.Point(203, 20);
            this.selectImage_btn.Name = "selectImage_btn";
            this.selectImage_btn.Size = new System.Drawing.Size(40, 27);
            this.selectImage_btn.TabIndex = 1;
            this.selectImage_btn.Text = "...";
            this.selectImage_btn.UseVisualStyleBackColor = true;
            this.selectImage_btn.Click += new System.EventHandler(this.SelectImage);
            // 
            // selectImage_txt
            // 
            this.selectImage_txt.Enabled = false;
            this.selectImage_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImage_txt.ForeColor = System.Drawing.Color.Gray;
            this.selectImage_txt.Location = new System.Drawing.Point(6, 21);
            this.selectImage_txt.Name = "selectImage_txt";
            this.selectImage_txt.Size = new System.Drawing.Size(191, 27);
            this.selectImage_txt.TabIndex = 0;
            this.selectImage_txt.Text = "Select an image to send";
            // 
            // sendRSA_group
            // 
            this.sendRSA_group.Controls.Add(this.getPublicIP_txt);
            this.sendRSA_group.Controls.Add(this.getPublicKey_btn);
            this.sendRSA_group.Controls.Add(this.lbl_pubKey);
            this.sendRSA_group.Controls.Add(this.label8);
            this.sendRSA_group.Location = new System.Drawing.Point(8, 12);
            this.sendRSA_group.Name = "sendRSA_group";
            this.sendRSA_group.Size = new System.Drawing.Size(248, 174);
            this.sendRSA_group.TabIndex = 8;
            this.sendRSA_group.TabStop = false;
            this.sendRSA_group.Text = "RSA:";
            // 
            // getPublicIP_txt
            // 
            this.getPublicIP_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getPublicIP_txt.ForeColor = System.Drawing.Color.Gray;
            this.getPublicIP_txt.Location = new System.Drawing.Point(4, 35);
            this.getPublicIP_txt.Name = "getPublicIP_txt";
            this.getPublicIP_txt.Size = new System.Drawing.Size(238, 27);
            this.getPublicIP_txt.TabIndex = 22;
            this.getPublicIP_txt.Text = GetIP();
            this.getPublicIP_txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetPublicIP);
            // 
            // getPublicKey_btn
            // 
            this.getPublicKey_btn.Location = new System.Drawing.Point(4, 68);
            this.getPublicKey_btn.Name = "getPublicKey_btn";
            this.getPublicKey_btn.Size = new System.Drawing.Size(237, 38);
            this.getPublicKey_btn.TabIndex = 21;
            this.getPublicKey_btn.Text = "Get Public Key";
            this.getPublicKey_btn.UseVisualStyleBackColor = true;
            this.getPublicKey_btn.Click += new System.EventHandler(this.GetPublicKey);
            // 
            // lbl_pubKey
            // 
            this.lbl_pubKey.AutoSize = true;
            this.lbl_pubKey.Location = new System.Drawing.Point(11, 145);
            this.lbl_pubKey.Name = "lbl_pubKey";
            this.lbl_pubKey.Size = new System.Drawing.Size(0, 19);
            this.lbl_pubKey.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Public Key :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 411);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // encryptImage_btn
            // 
            this.encryptImage_btn.Location = new System.Drawing.Point(8, 363);
            this.encryptImage_btn.Name = "encryptImage_btn";
            this.encryptImage_btn.Size = new System.Drawing.Size(248, 40);
            this.encryptImage_btn.TabIndex = 5;
            this.encryptImage_btn.Text = "Encrypt Image";
            this.encryptImage_btn.UseVisualStyleBackColor = true;
            this.encryptImage_btn.Click += new System.EventHandler(this.EncryptImage);
            // 
            // loadImage_btn
            // 
            this.loadImage_btn.Location = new System.Drawing.Point(8, 257);
            this.loadImage_btn.Name = "loadImage_btn";
            this.loadImage_btn.Size = new System.Drawing.Size(248, 40);
            this.loadImage_btn.TabIndex = 0;
            this.loadImage_btn.Text = "Load Image to Encrypt";
            this.loadImage_btn.UseVisualStyleBackColor = true;
            this.loadImage_btn.Click += new System.EventHandler(this.LoadImage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 588);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Encryption using RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.receiveImage_tab.ResumeLayout(false);
            this.receiveImage_tab.PerformLayout();
            this.receiveRSA_group.ResumeLayout(false);
            this.receiveRSA_group.PerformLayout();
            this.sendImage_tab.ResumeLayout(false);
            this.sendImage_tab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sendRSA_group.ResumeLayout(false);
            this.sendRSA_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button selectImage_btn;
        private System.Windows.Forms.TextBox selectImage_txt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sendImage_tab;
        private System.Windows.Forms.TabPage receiveImage_tab;
        private System.Windows.Forms.Button loadImage_btn;
        private System.Windows.Forms.GroupBox receiveRSA_group;
        private System.Windows.Forms.TextBox primeNumber2_txt;
        private System.Windows.Forms.TextBox primeNumber1_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberE_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendPublicKey_btn;
        private System.Windows.Forms.Button encryptImage_btn;
        private System.Windows.Forms.Button decryptImage_btn;
        private System.Windows.Forms.Button saveImage_btn;
        private System.Windows.Forms.TextBox saveImage_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox sendRSA_group;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_pubKey;
        private System.Windows.Forms.TextBox getPublicIP_txt;
        private System.Windows.Forms.Button getPublicKey_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox credits_rtxt;
        private System.Windows.Forms.Button creditDone_btn;
    }
}


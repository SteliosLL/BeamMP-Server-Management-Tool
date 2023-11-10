namespace BeamMP_Tool
{
    partial class setAutoMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setAutoMsg));
            this.baseFormUsrCtrl1 = new BeamMP_Tool.baseFormUsrCtrl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.scheduleMsgBtn = new BeamMP_Tool.customSmoothBtn();
            this.srvautoshutBtn = new BeamMP_Tool.customSmoothBtn();
            this.srvResBtn = new BeamMP_Tool.customSmoothBtn();
            this.srvNamePnlLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.schedMsgPnl = new System.Windows.Forms.Panel();
            this.sendMsgTxtBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new BeamMP_Tool.customSmoothBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.logChatChckB = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.modListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customSmoothBtn1 = new BeamMP_Tool.customSmoothBtn();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.schedMsgPnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseFormUsrCtrl1
            // 
            this.baseFormUsrCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.baseFormUsrCtrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.baseFormUsrCtrl1.ControlBox = true;
            this.baseFormUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseFormUsrCtrl1.Icon = global::BeamMP_Tool.Properties.Resources.icons8_message_22;
            this.baseFormUsrCtrl1.Location = new System.Drawing.Point(0, 0);
            this.baseFormUsrCtrl1.Minimize_Button = true;
            this.baseFormUsrCtrl1.Name = "baseFormUsrCtrl1";
            this.baseFormUsrCtrl1.parentForm = this;
            this.baseFormUsrCtrl1.Size = new System.Drawing.Size(913, 323);
            this.baseFormUsrCtrl1.TabIndex = 0;
            this.baseFormUsrCtrl1.Title = "Set automated messages";
            this.baseFormUsrCtrl1.Load += new System.EventHandler(this.baseFormUsrCtrl1_Load);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::BeamMP_Tool.Properties.Resources.modsPnl;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.scheduleMsgBtn);
            this.panel5.Controls.Add(this.srvautoshutBtn);
            this.panel5.Controls.Add(this.srvResBtn);
            this.panel5.Controls.Add(this.srvNamePnlLbl);
            this.panel5.ForeColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(18, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 274);
            this.panel5.TabIndex = 21;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // scheduleMsgBtn
            // 
            this.scheduleMsgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.scheduleMsgBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.scheduleMsgBtn.Can_Focus = true;
            this.scheduleMsgBtn.ClickTransitionSpeed = 60;
            this.scheduleMsgBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.scheduleMsgBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.scheduleMsgBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.scheduleMsgBtn.EnableSmoothTransitions = true;
            this.scheduleMsgBtn.FlatAppearance.BorderSize = 0;
            this.scheduleMsgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.scheduleMsgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.scheduleMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleMsgBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.scheduleMsgBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.scheduleMsgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scheduleMsgBtn.Location = new System.Drawing.Point(3, 17);
            this.scheduleMsgBtn.Name = "scheduleMsgBtn";
            this.scheduleMsgBtn.Size = new System.Drawing.Size(183, 24);
            this.scheduleMsgBtn.TabIndex = 23;
            this.scheduleMsgBtn.Text = "Scheduled message";
            this.scheduleMsgBtn.TransitionSpeed = 130;
            this.scheduleMsgBtn.UseVisualStyleBackColor = false;
            this.scheduleMsgBtn.Click += new System.EventHandler(this.customSmoothBtn2_Click);
            // 
            // srvautoshutBtn
            // 
            this.srvautoshutBtn.BackColor = System.Drawing.Color.Transparent;
            this.srvautoshutBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.srvautoshutBtn.Can_Focus = true;
            this.srvautoshutBtn.ClickTransitionSpeed = 60;
            this.srvautoshutBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.srvautoshutBtn.ColorNormal = System.Drawing.Color.Transparent;
            this.srvautoshutBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.srvautoshutBtn.EnableSmoothTransitions = true;
            this.srvautoshutBtn.FlatAppearance.BorderSize = 0;
            this.srvautoshutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.srvautoshutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.srvautoshutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srvautoshutBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.srvautoshutBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.srvautoshutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.srvautoshutBtn.Location = new System.Drawing.Point(3, 65);
            this.srvautoshutBtn.Name = "srvautoshutBtn";
            this.srvautoshutBtn.Size = new System.Drawing.Size(183, 24);
            this.srvautoshutBtn.TabIndex = 22;
            this.srvautoshutBtn.Text = "Server auto shutdown";
            this.srvautoshutBtn.TransitionSpeed = 130;
            this.srvautoshutBtn.UseVisualStyleBackColor = false;
            this.srvautoshutBtn.Click += new System.EventHandler(this.customSmoothBtn1_Click);
            // 
            // srvResBtn
            // 
            this.srvResBtn.BackColor = System.Drawing.Color.Transparent;
            this.srvResBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.srvResBtn.Can_Focus = true;
            this.srvResBtn.ClickTransitionSpeed = 60;
            this.srvResBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.srvResBtn.ColorNormal = System.Drawing.Color.Transparent;
            this.srvResBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.srvResBtn.EnableSmoothTransitions = true;
            this.srvResBtn.FlatAppearance.BorderSize = 0;
            this.srvResBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.srvResBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.srvResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srvResBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.srvResBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.srvResBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.srvResBtn.Location = new System.Drawing.Point(3, 41);
            this.srvResBtn.Name = "srvResBtn";
            this.srvResBtn.Size = new System.Drawing.Size(183, 24);
            this.srvResBtn.TabIndex = 21;
            this.srvResBtn.Text = "Server auto restart";
            this.srvResBtn.TransitionSpeed = 130;
            this.srvResBtn.UseVisualStyleBackColor = false;
            this.srvResBtn.Click += new System.EventHandler(this.activateModBtn_Click);
            // 
            // srvNamePnlLbl
            // 
            this.srvNamePnlLbl.AutoSize = true;
            this.srvNamePnlLbl.BackColor = System.Drawing.Color.Transparent;
            this.srvNamePnlLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.srvNamePnlLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.srvNamePnlLbl.Location = new System.Drawing.Point(4, 1);
            this.srvNamePnlLbl.Name = "srvNamePnlLbl";
            this.srvNamePnlLbl.Size = new System.Drawing.Size(52, 15);
            this.srvNamePnlLbl.TabIndex = 20;
            this.srvNamePnlLbl.Text = "-Action-";
            this.srvNamePnlLbl.Click += new System.EventHandler(this.srvNamePnlLbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::BeamMP_Tool.Properties.Resources.modsPnl;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.logChatChckB);
            this.panel1.Controls.Add(this.schedMsgPnl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sendMsgTxtBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(213, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 273);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "-Settings-";
            // 
            // schedMsgPnl
            // 
            this.schedMsgPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schedMsgPnl.BackColor = System.Drawing.Color.Transparent;
            this.schedMsgPnl.BackgroundImage = global::BeamMP_Tool.Properties.Resources.modsPnl;
            this.schedMsgPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.schedMsgPnl.Controls.Add(this.label6);
            this.schedMsgPnl.Controls.Add(this.textBox2);
            this.schedMsgPnl.Controls.Add(this.label5);
            this.schedMsgPnl.Controls.Add(this.textBox1);
            this.schedMsgPnl.Controls.Add(this.label4);
            this.schedMsgPnl.Controls.Add(this.label3);
            this.schedMsgPnl.Controls.Add(this.saveBtn);
            this.schedMsgPnl.ForeColor = System.Drawing.SystemColors.Control;
            this.schedMsgPnl.Location = new System.Drawing.Point(0, 84);
            this.schedMsgPnl.Name = "schedMsgPnl";
            this.schedMsgPnl.Size = new System.Drawing.Size(461, 189);
            this.schedMsgPnl.TabIndex = 23;
            // 
            // sendMsgTxtBox
            // 
            this.sendMsgTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.sendMsgTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendMsgTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sendMsgTxtBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sendMsgTxtBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.sendMsgTxtBox.Location = new System.Drawing.Point(3, 41);
            this.sendMsgTxtBox.Name = "sendMsgTxtBox";
            this.sendMsgTxtBox.Size = new System.Drawing.Size(455, 25);
            this.sendMsgTxtBox.TabIndex = 40;
            this.sendMsgTxtBox.TextChanged += new System.EventHandler(this.sendMsgTxtBox_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.saveBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.saveBtn.Can_Focus = true;
            this.saveBtn.ClickTransitionSpeed = 60;
            this.saveBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.saveBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.saveBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.saveBtn.EnableSmoothTransitions = true;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.Location = new System.Drawing.Point(376, 147);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(82, 39);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.TransitionSpeed = 130;
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Message to show:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Repeat message:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(4, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Every";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(37, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 25);
            this.textBox1.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(75, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "hours and";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(136, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 25);
            this.textBox2.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(174, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "minutes.";
            // 
            // logChatChckB
            // 
            this.logChatChckB.AutoSize = true;
            this.logChatChckB.BackColor = System.Drawing.Color.Transparent;
            this.logChatChckB.ForeColor = System.Drawing.SystemColors.Control;
            this.logChatChckB.Location = new System.Drawing.Point(235, 12);
            this.logChatChckB.Name = "logChatChckB";
            this.logChatChckB.Size = new System.Drawing.Size(59, 17);
            this.logChatChckB.TabIndex = 42;
            this.logChatChckB.Text = "Enable";
            this.logChatChckB.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::BeamMP_Tool.Properties.Resources.modsPnl;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.customSmoothBtn1);
            this.panel2.Controls.Add(this.modListView);
            this.panel2.Controls.Add(this.label7);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(677, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 274);
            this.panel2.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "-All messages-";
            // 
            // modListView
            // 
            this.modListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(84)))));
            this.modListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.modListView.ForeColor = System.Drawing.SystemColors.Control;
            this.modListView.FullRowSelect = true;
            this.modListView.HideSelection = false;
            this.modListView.Location = new System.Drawing.Point(3, 20);
            this.modListView.MultiSelect = false;
            this.modListView.Name = "modListView";
            this.modListView.ShowItemToolTips = true;
            this.modListView.Size = new System.Drawing.Size(217, 251);
            this.modListView.TabIndex = 21;
            this.modListView.UseCompatibleStateImageBehavior = false;
            this.modListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Message";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Action";
            // 
            // customSmoothBtn1
            // 
            this.customSmoothBtn1.BackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn1.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn1.Can_Focus = true;
            this.customSmoothBtn1.ClickTransitionSpeed = 60;
            this.customSmoothBtn1.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.customSmoothBtn1.ColorNormal = System.Drawing.Color.Transparent;
            this.customSmoothBtn1.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.customSmoothBtn1.EnableSmoothTransitions = true;
            this.customSmoothBtn1.FlatAppearance.BorderSize = 0;
            this.customSmoothBtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customSmoothBtn1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customSmoothBtn1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.customSmoothBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customSmoothBtn1.Location = new System.Drawing.Point(143, 0);
            this.customSmoothBtn1.Name = "customSmoothBtn1";
            this.customSmoothBtn1.Size = new System.Drawing.Size(68, 20);
            this.customSmoothBtn1.TabIndex = 24;
            this.customSmoothBtn1.Text = "Remove";
            this.customSmoothBtn1.TransitionSpeed = 130;
            this.customSmoothBtn1.UseVisualStyleBackColor = false;
            // 
            // setAutoMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeamMP_Tool.Properties.Resources._7cs9Ed_gradient1RESIZED1_TOP_PANEL2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 323);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.baseFormUsrCtrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setAutoMsg";
            this.Text = "Set automated messages";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.schedMsgPnl.ResumeLayout(false);
            this.schedMsgPnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private baseFormUsrCtrl baseFormUsrCtrl1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label srvNamePnlLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private customSmoothBtn srvResBtn;
        private customSmoothBtn scheduleMsgBtn;
        private customSmoothBtn srvautoshutBtn;
        private System.Windows.Forms.Panel schedMsgPnl;
        private System.Windows.Forms.TextBox sendMsgTxtBox;
        private customSmoothBtn saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox logChatChckB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView modListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private customSmoothBtn customSmoothBtn1;
    }
}
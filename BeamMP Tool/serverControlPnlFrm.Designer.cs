namespace BeamMP_Tool
{
    partial class serverControlPnlFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverControlPnlFrm));
            this.panel11 = new System.Windows.Forms.Panel();
            this.restartBtn = new BeamMP_Tool.customSmoothBtn();
            this.toolsBtn = new BeamMP_Tool.customSmoothBtn();
            this.startBtn = new BeamMP_Tool.customSmoothBtn();
            this.label11 = new System.Windows.Forms.Label();
            this.nextCfgCheckValLbl = new System.Windows.Forms.Label();
            this.nextSrvRestartValLbl = new System.Windows.Forms.Label();
            this.NextCfgCheckLbl = new System.Windows.Forms.Label();
            this.nextSrvRestartLbl = new System.Windows.Forms.Label();
            this.autoRestartPnl = new System.Windows.Forms.Panel();
            this.customSmoothBtn1 = new BeamMP_Tool.customSmoothBtn();
            this.resetRestartTimerBtn = new BeamMP_Tool.customSmoothBtn();
            this.label3 = new System.Windows.Forms.Label();
            this.resetCfgTimerBtn = new BeamMP_Tool.customSmoothBtn();
            this.msgPnl = new System.Windows.Forms.Panel();
            this.customSmoothBtn5 = new BeamMP_Tool.customSmoothBtn();
            this.sendMsgGrpBox = new System.Windows.Forms.GroupBox();
            this.sendMsgTxtBox = new System.Windows.Forms.TextBox();
            this.customSmoothBtn4 = new BeamMP_Tool.customSmoothBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectCustomStartFile = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.largeViewBtn = new BeamMP_Tool.customSmoothBtn();
            this.stopAutoScrlChckBox = new System.Windows.Forms.CheckBox();
            this.customSmoothBtn3 = new BeamMP_Tool.customSmoothBtn();
            this.outputTxtBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playersPnl = new System.Windows.Forms.Panel();
            this.kickBtn = new BeamMP_Tool.customSmoothBtn();
            this.playersListView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.commandsPnl = new System.Windows.Forms.Panel();
            this.sendCmdBtn = new BeamMP_Tool.customSmoothBtn();
            this.sendCmdTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.autoRestartBtn = new BeamMP_Tool.customSmoothBtn();
            this.playersBtn = new BeamMP_Tool.customSmoothBtn();
            this.sendTabBtn = new BeamMP_Tool.customSmoothBtn();
            this.msgTabBtn = new BeamMP_Tool.customSmoothBtn();
            this.baseFormUsrCtrl1 = new BeamMP_Tool.baseFormUsrCtrl();
            this.panel11.SuspendLayout();
            this.autoRestartPnl.SuspendLayout();
            this.msgPnl.SuspendLayout();
            this.sendMsgGrpBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.playersPnl.SuspendLayout();
            this.commandsPnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel11.BackgroundImage")));
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Controls.Add(this.restartBtn);
            this.panel11.Controls.Add(this.startBtn);
            this.panel11.Controls.Add(this.label11);
            this.panel11.ForeColor = System.Drawing.SystemColors.Control;
            this.panel11.Location = new System.Drawing.Point(149, 34);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(170, 50);
            this.panel11.TabIndex = 27;
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.restartBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.restartBtn.Can_Focus = true;
            this.restartBtn.ClickTransitionSpeed = 60;
            this.restartBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.restartBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.restartBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.restartBtn.Enabled = false;
            this.restartBtn.EnableSmoothTransitions = true;
            this.restartBtn.FlatAppearance.BorderSize = 0;
            this.restartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.restartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.restartBtn.Image = global::BeamMP_Tool.Properties.Resources.refresh16x16;
            this.restartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restartBtn.Location = new System.Drawing.Point(82, 16);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(83, 30);
            this.restartBtn.TabIndex = 31;
            this.restartBtn.Text = "Restart";
            this.restartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restartBtn.TransitionSpeed = 130;
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // toolsBtn
            // 
            this.toolsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.toolsBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.toolsBtn.Can_Focus = true;
            this.toolsBtn.ClickTransitionSpeed = 60;
            this.toolsBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.toolsBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.toolsBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.toolsBtn.EnableSmoothTransitions = true;
            this.toolsBtn.FlatAppearance.BorderSize = 0;
            this.toolsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.toolsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.toolsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toolsBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolsBtn.Image = global::BeamMP_Tool.Properties.Resources.icons8_settings_16;
            this.toolsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolsBtn.Location = new System.Drawing.Point(-58, 35);
            this.toolsBtn.Name = "toolsBtn";
            this.toolsBtn.Size = new System.Drawing.Size(90, 28);
            this.toolsBtn.TabIndex = 30;
            this.toolsBtn.Text = "Tools ▼";
            this.toolsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolsBtn.TransitionSpeed = 130;
            this.toolsBtn.UseVisualStyleBackColor = false;
            this.toolsBtn.Visible = false;
            this.toolsBtn.Click += new System.EventHandler(this.toolsBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.startBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.startBtn.Can_Focus = true;
            this.startBtn.ClickTransitionSpeed = 60;
            this.startBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.startBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.startBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.startBtn.EnableSmoothTransitions = true;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.startBtn.Image = global::BeamMP_Tool.Properties.Resources.SquaregreenArrowRight;
            this.startBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startBtn.Location = new System.Drawing.Point(5, 16);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(74, 30);
            this.startBtn.TabIndex = 22;
            this.startBtn.Text = "Start";
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startBtn.TransitionSpeed = 130;
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(3, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "-Server-";
            // 
            // nextCfgCheckValLbl
            // 
            this.nextCfgCheckValLbl.AutoSize = true;
            this.nextCfgCheckValLbl.BackColor = System.Drawing.Color.Transparent;
            this.nextCfgCheckValLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextCfgCheckValLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nextCfgCheckValLbl.Location = new System.Drawing.Point(267, 66);
            this.nextCfgCheckValLbl.Name = "nextCfgCheckValLbl";
            this.nextCfgCheckValLbl.Size = new System.Drawing.Size(49, 15);
            this.nextCfgCheckValLbl.TabIndex = 35;
            this.nextCfgCheckValLbl.Text = "00:00:00";
            this.nextCfgCheckValLbl.Visible = false;
            // 
            // nextSrvRestartValLbl
            // 
            this.nextSrvRestartValLbl.AutoSize = true;
            this.nextSrvRestartValLbl.BackColor = System.Drawing.Color.Transparent;
            this.nextSrvRestartValLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextSrvRestartValLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nextSrvRestartValLbl.Location = new System.Drawing.Point(82, 66);
            this.nextSrvRestartValLbl.Name = "nextSrvRestartValLbl";
            this.nextSrvRestartValLbl.Size = new System.Drawing.Size(49, 15);
            this.nextSrvRestartValLbl.TabIndex = 34;
            this.nextSrvRestartValLbl.Text = "00:00:00";
            this.nextSrvRestartValLbl.Visible = false;
            // 
            // NextCfgCheckLbl
            // 
            this.NextCfgCheckLbl.AutoSize = true;
            this.NextCfgCheckLbl.BackColor = System.Drawing.Color.Transparent;
            this.NextCfgCheckLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NextCfgCheckLbl.ForeColor = System.Drawing.Color.Lime;
            this.NextCfgCheckLbl.Location = new System.Drawing.Point(240, 50);
            this.NextCfgCheckLbl.Name = "NextCfgCheckLbl";
            this.NextCfgCheckLbl.Size = new System.Drawing.Size(112, 15);
            this.NextCfgCheckLbl.TabIndex = 33;
            this.NextCfgCheckLbl.Text = "Next config check:";
            this.NextCfgCheckLbl.Visible = false;
            // 
            // nextSrvRestartLbl
            // 
            this.nextSrvRestartLbl.AutoSize = true;
            this.nextSrvRestartLbl.BackColor = System.Drawing.Color.Transparent;
            this.nextSrvRestartLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextSrvRestartLbl.ForeColor = System.Drawing.Color.Lime;
            this.nextSrvRestartLbl.Location = new System.Drawing.Point(54, 50);
            this.nextSrvRestartLbl.Name = "nextSrvRestartLbl";
            this.nextSrvRestartLbl.Size = new System.Drawing.Size(123, 15);
            this.nextSrvRestartLbl.TabIndex = 32;
            this.nextSrvRestartLbl.Text = "Next Server Restart:";
            this.nextSrvRestartLbl.Visible = false;
            // 
            // autoRestartPnl
            // 
            this.autoRestartPnl.BackColor = System.Drawing.Color.Transparent;
            this.autoRestartPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("autoRestartPnl.BackgroundImage")));
            this.autoRestartPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.autoRestartPnl.Controls.Add(this.customSmoothBtn1);
            this.autoRestartPnl.Controls.Add(this.resetRestartTimerBtn);
            this.autoRestartPnl.Controls.Add(this.label3);
            this.autoRestartPnl.Controls.Add(this.resetCfgTimerBtn);
            this.autoRestartPnl.Controls.Add(this.nextSrvRestartLbl);
            this.autoRestartPnl.Controls.Add(this.NextCfgCheckLbl);
            this.autoRestartPnl.Controls.Add(this.nextCfgCheckValLbl);
            this.autoRestartPnl.Controls.Add(this.nextSrvRestartValLbl);
            this.autoRestartPnl.ForeColor = System.Drawing.SystemColors.Control;
            this.autoRestartPnl.Location = new System.Drawing.Point(13, 114);
            this.autoRestartPnl.Name = "autoRestartPnl";
            this.autoRestartPnl.Size = new System.Drawing.Size(441, 118);
            this.autoRestartPnl.TabIndex = 28;
            // 
            // customSmoothBtn1
            // 
            this.customSmoothBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn1.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn1.Can_Focus = true;
            this.customSmoothBtn1.ClickTransitionSpeed = 60;
            this.customSmoothBtn1.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.customSmoothBtn1.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn1.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.customSmoothBtn1.EnableSmoothTransitions = true;
            this.customSmoothBtn1.FlatAppearance.BorderSize = 0;
            this.customSmoothBtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customSmoothBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customSmoothBtn1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.customSmoothBtn1.Image = global::BeamMP_Tool.Properties.Resources._264;
            this.customSmoothBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customSmoothBtn1.Location = new System.Drawing.Point(153, 3);
            this.customSmoothBtn1.Name = "customSmoothBtn1";
            this.customSmoothBtn1.Size = new System.Drawing.Size(103, 22);
            this.customSmoothBtn1.TabIndex = 32;
            this.customSmoothBtn1.Text = "Timer Options";
            this.customSmoothBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customSmoothBtn1.TransitionSpeed = 130;
            this.customSmoothBtn1.UseVisualStyleBackColor = false;
            this.customSmoothBtn1.Click += new System.EventHandler(this.customSmoothBtn1_Click);
            // 
            // resetRestartTimerBtn
            // 
            this.resetRestartTimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.resetRestartTimerBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.resetRestartTimerBtn.Can_Focus = true;
            this.resetRestartTimerBtn.ClickTransitionSpeed = 60;
            this.resetRestartTimerBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.resetRestartTimerBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.resetRestartTimerBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.resetRestartTimerBtn.EnableSmoothTransitions = true;
            this.resetRestartTimerBtn.FlatAppearance.BorderSize = 0;
            this.resetRestartTimerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resetRestartTimerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resetRestartTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetRestartTimerBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resetRestartTimerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.resetRestartTimerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetRestartTimerBtn.Location = new System.Drawing.Point(176, 55);
            this.resetRestartTimerBtn.Name = "resetRestartTimerBtn";
            this.resetRestartTimerBtn.Size = new System.Drawing.Size(44, 22);
            this.resetRestartTimerBtn.TabIndex = 36;
            this.resetRestartTimerBtn.Text = "Reset";
            this.resetRestartTimerBtn.TransitionSpeed = 130;
            this.resetRestartTimerBtn.UseVisualStyleBackColor = false;
            this.resetRestartTimerBtn.Visible = false;
            this.resetRestartTimerBtn.Click += new System.EventHandler(this.resetRestartTimerBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "-Auto Restart Timers-";
            // 
            // resetCfgTimerBtn
            // 
            this.resetCfgTimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.resetCfgTimerBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.resetCfgTimerBtn.Can_Focus = true;
            this.resetCfgTimerBtn.ClickTransitionSpeed = 60;
            this.resetCfgTimerBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.resetCfgTimerBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.resetCfgTimerBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.resetCfgTimerBtn.EnableSmoothTransitions = true;
            this.resetCfgTimerBtn.FlatAppearance.BorderSize = 0;
            this.resetCfgTimerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resetCfgTimerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resetCfgTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetCfgTimerBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resetCfgTimerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.resetCfgTimerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetCfgTimerBtn.Location = new System.Drawing.Point(351, 55);
            this.resetCfgTimerBtn.Name = "resetCfgTimerBtn";
            this.resetCfgTimerBtn.Size = new System.Drawing.Size(44, 22);
            this.resetCfgTimerBtn.TabIndex = 32;
            this.resetCfgTimerBtn.Text = "Reset";
            this.resetCfgTimerBtn.TransitionSpeed = 130;
            this.resetCfgTimerBtn.UseVisualStyleBackColor = false;
            this.resetCfgTimerBtn.Visible = false;
            this.resetCfgTimerBtn.Click += new System.EventHandler(this.resetCfgTimerBtn_Click);
            // 
            // msgPnl
            // 
            this.msgPnl.AutoScroll = true;
            this.msgPnl.BackColor = System.Drawing.Color.Transparent;
            this.msgPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("msgPnl.BackgroundImage")));
            this.msgPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msgPnl.Controls.Add(this.customSmoothBtn5);
            this.msgPnl.Controls.Add(this.sendMsgGrpBox);
            this.msgPnl.Controls.Add(this.label1);
            this.msgPnl.ForeColor = System.Drawing.SystemColors.Control;
            this.msgPnl.Location = new System.Drawing.Point(13, 114);
            this.msgPnl.Name = "msgPnl";
            this.msgPnl.Size = new System.Drawing.Size(441, 118);
            this.msgPnl.TabIndex = 29;
            // 
            // customSmoothBtn5
            // 
            this.customSmoothBtn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn5.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn5.Can_Focus = true;
            this.customSmoothBtn5.ClickTransitionSpeed = 60;
            this.customSmoothBtn5.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.customSmoothBtn5.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn5.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.customSmoothBtn5.Enabled = false;
            this.customSmoothBtn5.EnableSmoothTransitions = true;
            this.customSmoothBtn5.FlatAppearance.BorderSize = 0;
            this.customSmoothBtn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customSmoothBtn5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customSmoothBtn5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.customSmoothBtn5.Image = global::BeamMP_Tool.Properties.Resources.icons8_message_22;
            this.customSmoothBtn5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customSmoothBtn5.Location = new System.Drawing.Point(317, 36);
            this.customSmoothBtn5.Name = "customSmoothBtn5";
            this.customSmoothBtn5.Size = new System.Drawing.Size(113, 59);
            this.customSmoothBtn5.TabIndex = 37;
            this.customSmoothBtn5.Text = "Set automated\r\n   messages (Coming soon...)";
            this.customSmoothBtn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customSmoothBtn5.TransitionSpeed = 130;
            this.customSmoothBtn5.UseVisualStyleBackColor = false;
            this.customSmoothBtn5.Click += new System.EventHandler(this.customSmoothBtn5_Click);
            // 
            // sendMsgGrpBox
            // 
            this.sendMsgGrpBox.Controls.Add(this.sendMsgTxtBox);
            this.sendMsgGrpBox.Controls.Add(this.customSmoothBtn4);
            this.sendMsgGrpBox.Enabled = false;
            this.sendMsgGrpBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.sendMsgGrpBox.Location = new System.Drawing.Point(6, 22);
            this.sendMsgGrpBox.Name = "sendMsgGrpBox";
            this.sendMsgGrpBox.Size = new System.Drawing.Size(298, 79);
            this.sendMsgGrpBox.TabIndex = 39;
            this.sendMsgGrpBox.TabStop = false;
            this.sendMsgGrpBox.Text = "Send Message";
            // 
            // sendMsgTxtBox
            // 
            this.sendMsgTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.sendMsgTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendMsgTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sendMsgTxtBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sendMsgTxtBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.sendMsgTxtBox.Location = new System.Drawing.Point(6, 17);
            this.sendMsgTxtBox.Name = "sendMsgTxtBox";
            this.sendMsgTxtBox.Size = new System.Drawing.Size(286, 25);
            this.sendMsgTxtBox.TabIndex = 39;
            this.sendMsgTxtBox.TextChanged += new System.EventHandler(this.authTxtBox_TextChanged);
            // 
            // customSmoothBtn4
            // 
            this.customSmoothBtn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn4.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn4.Can_Focus = true;
            this.customSmoothBtn4.ClickTransitionSpeed = 60;
            this.customSmoothBtn4.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.customSmoothBtn4.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn4.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.customSmoothBtn4.EnableSmoothTransitions = true;
            this.customSmoothBtn4.FlatAppearance.BorderSize = 0;
            this.customSmoothBtn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customSmoothBtn4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customSmoothBtn4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.customSmoothBtn4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customSmoothBtn4.Location = new System.Drawing.Point(120, 45);
            this.customSmoothBtn4.Name = "customSmoothBtn4";
            this.customSmoothBtn4.Size = new System.Drawing.Size(54, 28);
            this.customSmoothBtn4.TabIndex = 38;
            this.customSmoothBtn4.Text = "Send";
            this.customSmoothBtn4.TransitionSpeed = 130;
            this.customSmoothBtn4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "-Messages-";
            // 
            // toolsMenu
            // 
            this.toolsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(84)))));
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(61, 4);
            this.toolsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.toolsMenu_Opening);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.largeViewBtn);
            this.panel3.Controls.Add(this.stopAutoScrlChckBox);
            this.panel3.Controls.Add(this.customSmoothBtn3);
            this.panel3.Controls.Add(this.outputTxtBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(13, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 175);
            this.panel3.TabIndex = 30;
            // 
            // largeViewBtn
            // 
            this.largeViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.largeViewBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.largeViewBtn.Can_Focus = true;
            this.largeViewBtn.ClickTransitionSpeed = 60;
            this.largeViewBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.largeViewBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.largeViewBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.largeViewBtn.EnableSmoothTransitions = true;
            this.largeViewBtn.FlatAppearance.BorderSize = 0;
            this.largeViewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.largeViewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.largeViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.largeViewBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.largeViewBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.largeViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("largeViewBtn.Image")));
            this.largeViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.largeViewBtn.Location = new System.Drawing.Point(338, 0);
            this.largeViewBtn.Name = "largeViewBtn";
            this.largeViewBtn.Size = new System.Drawing.Size(98, 20);
            this.largeViewBtn.TabIndex = 39;
            this.largeViewBtn.Text = "LARGE VIEW";
            this.largeViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.largeViewBtn.TransitionSpeed = 130;
            this.largeViewBtn.UseVisualStyleBackColor = false;
            this.largeViewBtn.Click += new System.EventHandler(this.customSmoothBtn6_Click);
            // 
            // stopAutoScrlChckBox
            // 
            this.stopAutoScrlChckBox.AutoSize = true;
            this.stopAutoScrlChckBox.BackColor = System.Drawing.Color.Transparent;
            this.stopAutoScrlChckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.stopAutoScrlChckBox.Location = new System.Drawing.Point(169, 3);
            this.stopAutoScrlChckBox.Name = "stopAutoScrlChckBox";
            this.stopAutoScrlChckBox.Size = new System.Drawing.Size(113, 17);
            this.stopAutoScrlChckBox.TabIndex = 38;
            this.stopAutoScrlChckBox.Text = "Stop auto-scrolling";
            this.stopAutoScrlChckBox.UseVisualStyleBackColor = false;
            // 
            // customSmoothBtn3
            // 
            this.customSmoothBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn3.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn3.Can_Focus = true;
            this.customSmoothBtn3.ClickTransitionSpeed = 60;
            this.customSmoothBtn3.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.customSmoothBtn3.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.customSmoothBtn3.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.customSmoothBtn3.EnableSmoothTransitions = true;
            this.customSmoothBtn3.FlatAppearance.BorderSize = 0;
            this.customSmoothBtn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.customSmoothBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customSmoothBtn3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customSmoothBtn3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.customSmoothBtn3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customSmoothBtn3.Location = new System.Drawing.Point(119, 0);
            this.customSmoothBtn3.Name = "customSmoothBtn3";
            this.customSmoothBtn3.Size = new System.Drawing.Size(42, 20);
            this.customSmoothBtn3.TabIndex = 34;
            this.customSmoothBtn3.Text = "Clear";
            this.customSmoothBtn3.TransitionSpeed = 130;
            this.customSmoothBtn3.UseVisualStyleBackColor = false;
            this.customSmoothBtn3.Click += new System.EventHandler(this.customSmoothBtn3_Click);
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.outputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTxtBox.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.outputTxtBox.ForeColor = System.Drawing.Color.White;
            this.outputTxtBox.Location = new System.Drawing.Point(3, 21);
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.ReadOnly = true;
            this.outputTxtBox.Size = new System.Drawing.Size(435, 151);
            this.outputTxtBox.TabIndex = 37;
            this.outputTxtBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "-Console Output-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // playersPnl
            // 
            this.playersPnl.BackColor = System.Drawing.Color.Transparent;
            this.playersPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playersPnl.BackgroundImage")));
            this.playersPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playersPnl.Controls.Add(this.kickBtn);
            this.playersPnl.Controls.Add(this.playersListView);
            this.playersPnl.Controls.Add(this.label4);
            this.playersPnl.ForeColor = System.Drawing.SystemColors.Control;
            this.playersPnl.Location = new System.Drawing.Point(13, 114);
            this.playersPnl.Name = "playersPnl";
            this.playersPnl.Size = new System.Drawing.Size(441, 118);
            this.playersPnl.TabIndex = 38;
            // 
            // kickBtn
            // 
            this.kickBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.kickBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.kickBtn.Can_Focus = true;
            this.kickBtn.ClickTransitionSpeed = 60;
            this.kickBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.kickBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.kickBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.kickBtn.Enabled = false;
            this.kickBtn.EnableSmoothTransitions = true;
            this.kickBtn.FlatAppearance.BorderSize = 0;
            this.kickBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.kickBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.kickBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kickBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.kickBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kickBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kickBtn.Location = new System.Drawing.Point(394, 19);
            this.kickBtn.Name = "kickBtn";
            this.kickBtn.Size = new System.Drawing.Size(43, 22);
            this.kickBtn.TabIndex = 33;
            this.kickBtn.Text = "Kick";
            this.kickBtn.TransitionSpeed = 130;
            this.kickBtn.UseVisualStyleBackColor = false;
            // 
            // playersListView
            // 
            this.playersListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.playersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playersListView.ForeColor = System.Drawing.SystemColors.Control;
            this.playersListView.FullRowSelect = true;
            this.playersListView.HideSelection = false;
            this.playersListView.Location = new System.Drawing.Point(3, 19);
            this.playersListView.MultiSelect = false;
            this.playersListView.Name = "playersListView";
            this.playersListView.ShowItemToolTips = true;
            this.playersListView.Size = new System.Drawing.Size(387, 96);
            this.playersListView.TabIndex = 28;
            this.playersListView.UseCompatibleStateImageBehavior = false;
            this.playersListView.SelectedIndexChanged += new System.EventHandler(this.mapsListView_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "-Players-";
            // 
            // commandsPnl
            // 
            this.commandsPnl.AutoScroll = true;
            this.commandsPnl.BackColor = System.Drawing.Color.Transparent;
            this.commandsPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commandsPnl.BackgroundImage")));
            this.commandsPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commandsPnl.Controls.Add(this.sendCmdBtn);
            this.commandsPnl.Controls.Add(this.sendCmdTxtBox);
            this.commandsPnl.Controls.Add(this.label5);
            this.commandsPnl.Enabled = false;
            this.commandsPnl.ForeColor = System.Drawing.SystemColors.Control;
            this.commandsPnl.Location = new System.Drawing.Point(13, 114);
            this.commandsPnl.Name = "commandsPnl";
            this.commandsPnl.Size = new System.Drawing.Size(441, 118);
            this.commandsPnl.TabIndex = 40;
            // 
            // sendCmdBtn
            // 
            this.sendCmdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.sendCmdBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.sendCmdBtn.Can_Focus = true;
            this.sendCmdBtn.ClickTransitionSpeed = 60;
            this.sendCmdBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.sendCmdBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.sendCmdBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.sendCmdBtn.EnableSmoothTransitions = true;
            this.sendCmdBtn.FlatAppearance.BorderSize = 0;
            this.sendCmdBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendCmdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendCmdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendCmdBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sendCmdBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.sendCmdBtn.Location = new System.Drawing.Point(184, 61);
            this.sendCmdBtn.Name = "sendCmdBtn";
            this.sendCmdBtn.Size = new System.Drawing.Size(70, 30);
            this.sendCmdBtn.TabIndex = 38;
            this.sendCmdBtn.Text = "Send";
            this.sendCmdBtn.TransitionSpeed = 130;
            this.sendCmdBtn.UseVisualStyleBackColor = false;
            this.sendCmdBtn.Click += new System.EventHandler(this.customSmoothBtn7_Click);
            // 
            // sendCmdTxtBox
            // 
            this.sendCmdTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.sendCmdTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendCmdTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sendCmdTxtBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sendCmdTxtBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.sendCmdTxtBox.Location = new System.Drawing.Point(6, 18);
            this.sendCmdTxtBox.Name = "sendCmdTxtBox";
            this.sendCmdTxtBox.Size = new System.Drawing.Size(431, 25);
            this.sendCmdTxtBox.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "-Send Commands-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label6);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(13, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 129);
            this.panel2.TabIndex = 39;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(3, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "-Information-";
            // 
            // autoRestartBtn
            // 
            this.autoRestartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.autoRestartBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.autoRestartBtn.Can_Focus = true;
            this.autoRestartBtn.ClickTransitionSpeed = 60;
            this.autoRestartBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.autoRestartBtn.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.autoRestartBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.autoRestartBtn.EnableSmoothTransitions = true;
            this.autoRestartBtn.FlatAppearance.BorderSize = 0;
            this.autoRestartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.autoRestartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.autoRestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoRestartBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.autoRestartBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.autoRestartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoRestartBtn.Location = new System.Drawing.Point(13, 88);
            this.autoRestartBtn.Name = "autoRestartBtn";
            this.autoRestartBtn.Size = new System.Drawing.Size(81, 24);
            this.autoRestartBtn.TabIndex = 42;
            this.autoRestartBtn.Text = "Auto restart";
            this.autoRestartBtn.TransitionSpeed = 130;
            this.autoRestartBtn.UseVisualStyleBackColor = false;
            this.autoRestartBtn.Click += new System.EventHandler(this.autoRestartBtn_Click);
            // 
            // playersBtn
            // 
            this.playersBtn.BackColor = System.Drawing.Color.Transparent;
            this.playersBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.playersBtn.Can_Focus = true;
            this.playersBtn.ClickTransitionSpeed = 60;
            this.playersBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.playersBtn.ColorNormal = System.Drawing.Color.Transparent;
            this.playersBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.playersBtn.Enabled = false;
            this.playersBtn.EnableSmoothTransitions = true;
            this.playersBtn.FlatAppearance.BorderSize = 0;
            this.playersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playersBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.playersBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.playersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playersBtn.Location = new System.Drawing.Point(271, 88);
            this.playersBtn.Name = "playersBtn";
            this.playersBtn.Size = new System.Drawing.Size(56, 24);
            this.playersBtn.TabIndex = 41;
            this.playersBtn.Text = "Players";
            this.playersBtn.TransitionSpeed = 130;
            this.playersBtn.UseVisualStyleBackColor = false;
            this.playersBtn.Click += new System.EventHandler(this.playersBtn_Click);
            // 
            // sendTabBtn
            // 
            this.sendTabBtn.BackColor = System.Drawing.Color.Transparent;
            this.sendTabBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.sendTabBtn.Can_Focus = true;
            this.sendTabBtn.ClickTransitionSpeed = 60;
            this.sendTabBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.sendTabBtn.ColorNormal = System.Drawing.Color.Transparent;
            this.sendTabBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.sendTabBtn.Enabled = false;
            this.sendTabBtn.EnableSmoothTransitions = true;
            this.sendTabBtn.FlatAppearance.BorderSize = 0;
            this.sendTabBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendTabBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendTabBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sendTabBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.sendTabBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendTabBtn.Location = new System.Drawing.Point(164, 88);
            this.sendTabBtn.Name = "sendTabBtn";
            this.sendTabBtn.Size = new System.Drawing.Size(106, 24);
            this.sendTabBtn.TabIndex = 40;
            this.sendTabBtn.Text = "Send commands";
            this.sendTabBtn.TransitionSpeed = 130;
            this.sendTabBtn.UseVisualStyleBackColor = false;
            this.sendTabBtn.Click += new System.EventHandler(this.sendTabBtn_Click);
            // 
            // msgTabBtn
            // 
            this.msgTabBtn.BackColor = System.Drawing.Color.Transparent;
            this.msgTabBtn.BackgroundBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.msgTabBtn.Can_Focus = true;
            this.msgTabBtn.ClickTransitionSpeed = 60;
            this.msgTabBtn.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.msgTabBtn.ColorNormal = System.Drawing.Color.Transparent;
            this.msgTabBtn.ColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.msgTabBtn.Enabled = false;
            this.msgTabBtn.EnableSmoothTransitions = true;
            this.msgTabBtn.FlatAppearance.BorderSize = 0;
            this.msgTabBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.msgTabBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.msgTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msgTabBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.msgTabBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.msgTabBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.msgTabBtn.Location = new System.Drawing.Point(95, 88);
            this.msgTabBtn.Name = "msgTabBtn";
            this.msgTabBtn.Size = new System.Drawing.Size(68, 24);
            this.msgTabBtn.TabIndex = 39;
            this.msgTabBtn.Text = "Messages";
            this.msgTabBtn.TransitionSpeed = 130;
            this.msgTabBtn.UseVisualStyleBackColor = false;
            this.msgTabBtn.Click += new System.EventHandler(this.msgTabBtn_Click);
            // 
            // baseFormUsrCtrl1
            // 
            this.baseFormUsrCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.baseFormUsrCtrl1.ControlBox = false;
            this.baseFormUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseFormUsrCtrl1.Icon = global::BeamMP_Tool.Properties.Resources.BeamMP_32512_3;
            this.baseFormUsrCtrl1.Location = new System.Drawing.Point(0, 0);
            this.baseFormUsrCtrl1.Minimize_Button = false;
            this.baseFormUsrCtrl1.Name = "baseFormUsrCtrl1";
            this.baseFormUsrCtrl1.parentForm = this;
            this.baseFormUsrCtrl1.Size = new System.Drawing.Size(467, 245);
            this.baseFormUsrCtrl1.TabIndex = 0;
            this.baseFormUsrCtrl1.Title = "Server Control Panel";
            this.baseFormUsrCtrl1.Load += new System.EventHandler(this.baseFormUsrCtrl1_Load);
            // 
            // serverControlPnlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeamMP_Tool.Properties.Resources._7cs9Ed_gradient1RESIZED1_TOP_PANEL2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 245);
            this.ControlBox = false;
            this.Controls.Add(this.toolsBtn);
            this.Controls.Add(this.autoRestartPnl);
            this.Controls.Add(this.msgPnl);
            this.Controls.Add(this.playersPnl);
            this.Controls.Add(this.autoRestartBtn);
            this.Controls.Add(this.commandsPnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.playersBtn);
            this.Controls.Add(this.sendTabBtn);
            this.Controls.Add(this.msgTabBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.baseFormUsrCtrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "serverControlPnlFrm";
            this.Text = "Server Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.serverControlPnlFrm_FormClosing);
            this.Load += new System.EventHandler(this.serverControlPnlFrm_Load);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.autoRestartPnl.ResumeLayout(false);
            this.autoRestartPnl.PerformLayout();
            this.msgPnl.ResumeLayout(false);
            this.msgPnl.PerformLayout();
            this.sendMsgGrpBox.ResumeLayout(false);
            this.sendMsgGrpBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.playersPnl.ResumeLayout(false);
            this.playersPnl.PerformLayout();
            this.commandsPnl.ResumeLayout(false);
            this.commandsPnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public baseFormUsrCtrl baseFormUsrCtrl1;
        private System.Windows.Forms.Panel panel11;
        private customSmoothBtn resetRestartTimerBtn;
        private customSmoothBtn restartBtn;
        private customSmoothBtn resetCfgTimerBtn;
        private customSmoothBtn toolsBtn;
        private System.Windows.Forms.Label nextCfgCheckValLbl;
        private customSmoothBtn startBtn;
        private System.Windows.Forms.Label nextSrvRestartValLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label NextCfgCheckLbl;
        private System.Windows.Forms.Label nextSrvRestartLbl;
        private System.Windows.Forms.Panel autoRestartPnl;
        private System.Windows.Forms.Label label3;
        private customSmoothBtn customSmoothBtn1;
        private System.Windows.Forms.Panel msgPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip toolsMenu;
        private System.Windows.Forms.OpenFileDialog selectCustomStartFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox outputTxtBox;
        private System.Windows.Forms.Panel playersPnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView playersListView;
        private customSmoothBtn kickBtn;
        private customSmoothBtn customSmoothBtn3;
        private System.Windows.Forms.GroupBox sendMsgGrpBox;
        private customSmoothBtn customSmoothBtn4;
        private System.Windows.Forms.TextBox sendMsgTxtBox;
        private customSmoothBtn customSmoothBtn5;
        private customSmoothBtn sendTabBtn;
        private customSmoothBtn msgTabBtn;
        private System.Windows.Forms.Panel commandsPnl;
        private System.Windows.Forms.TextBox sendCmdTxtBox;
        private customSmoothBtn sendCmdBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox stopAutoScrlChckBox;
        private customSmoothBtn playersBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private customSmoothBtn autoRestartBtn;
        private customSmoothBtn largeViewBtn;
    }
}
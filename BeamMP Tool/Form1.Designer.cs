
namespace BeamMP_Tool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mapgrp = new System.Windows.Forms.GroupBox();
            this.mapsListView = new System.Windows.Forms.ListView();
            this.mainMapImgList = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.defMapsImgList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.authTxtBox = new System.Windows.Forms.TextBox();
            this.portTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxCarsCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxPlayerCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.privChckBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectResLocBtn = new System.Windows.Forms.Button();
            this.debugChckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.restartBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.selectCustomStartFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.modListView = new System.Windows.Forms.ListView();
            this.modsImgList = new System.Windows.Forms.ImageList(this.components);
            this.activateModBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pluginlistView = new System.Windows.Forms.ListView();
            this.pluginImgList = new System.Windows.Forms.ImageList(this.components);
            this.activatePluginsBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reloadCfgBtn = new System.Windows.Forms.Button();
            this.searchMapsBtn = new System.Windows.Forms.Button();
            this.searchPluginsBtn = new System.Windows.Forms.Button();
            this.searchModsBtn = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.setCustomStartupFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRestartTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mapgrp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapgrp
            // 
            this.mapgrp.Controls.Add(this.mapsListView);
            this.mapgrp.Controls.Add(this.button3);
            this.mapgrp.Location = new System.Drawing.Point(6, 137);
            this.mapgrp.Name = "mapgrp";
            this.mapgrp.Size = new System.Drawing.Size(538, 215);
            this.mapgrp.TabIndex = 0;
            this.mapgrp.TabStop = false;
            this.mapgrp.Text = "Choose map";
            // 
            // mapsListView
            // 
            this.mapsListView.FullRowSelect = true;
            this.mapsListView.HideSelection = false;
            this.mapsListView.LargeImageList = this.mainMapImgList;
            this.mapsListView.Location = new System.Drawing.Point(6, 18);
            this.mapsListView.MultiSelect = false;
            this.mapsListView.Name = "mapsListView";
            this.mapsListView.ShowItemToolTips = true;
            this.mapsListView.Size = new System.Drawing.Size(526, 191);
            this.mapsListView.SmallImageList = this.mainMapImgList;
            this.mapsListView.TabIndex = 18;
            this.mapsListView.UseCompatibleStateImageBehavior = false;
            // 
            // mainMapImgList
            // 
            this.mainMapImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainMapImgList.ImageStream")));
            this.mainMapImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.mainMapImgList.Images.SetKeyName(0, "custommap.png");
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(75, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 17);
            this.button3.TabIndex = 18;
            this.button3.Text = "Open maps folder";
            this.toolTip1.SetToolTip(this.button3, "Put maps in this folder");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // defMapsImgList
            // 
            this.defMapsImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("defMapsImgList.ImageStream")));
            this.defMapsImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.defMapsImgList.Images.SetKeyName(0, "custommap.png");
            this.defMapsImgList.Images.SetKeyName(1, "GridMap_preview4.jpg");
            this.defMapsImgList.Images.SetKeyName(2, "automation_test_track_preview1.jpg");
            this.defMapsImgList.Images.SetKeyName(3, "east_coast_usa_preview1_v2.jpg");
            this.defMapsImgList.Images.SetKeyName(4, "hirochi_raceway_preview.jpg");
            this.defMapsImgList.Images.SetKeyName(5, "italy_preview0.jpg");
            this.defMapsImgList.Images.SetKeyName(6, "Industrial_preview.jpg");
            this.defMapsImgList.Images.SetKeyName(7, "small_island_preview.jpg");
            this.defMapsImgList.Images.SetKeyName(8, "smallgrid_preview.jpg");
            this.defMapsImgList.Images.SetKeyName(9, "utah_preview4.jpg");
            this.defMapsImgList.Images.SetKeyName(10, "west_coast_usa_preview1.jpg");
            this.defMapsImgList.Images.SetKeyName(11, "driver_training_preview.jpg");
            this.defMapsImgList.Images.SetKeyName(12, "derby_preview_1.jpg");
            this.defMapsImgList.Images.SetKeyName(13, "jungle_rock_island_preview1.jpg");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.authTxtBox);
            this.groupBox2.Controls.Add(this.portTxtBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.maxCarsCombo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maxPlayerCombo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.descTxtBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nameTxtBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General Settings";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(141, 89);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Auth Key:";
            this.toolTip1.SetToolTip(this.linkLabel1, resources.GetString("linkLabel1.ToolTip"));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // authTxtBox
            // 
            this.authTxtBox.Location = new System.Drawing.Point(194, 86);
            this.authTxtBox.Name = "authTxtBox";
            this.authTxtBox.Size = new System.Drawing.Size(197, 20);
            this.authTxtBox.TabIndex = 10;
            // 
            // portTxtBox
            // 
            this.portTxtBox.Location = new System.Drawing.Point(41, 86);
            this.portTxtBox.Name = "portTxtBox";
            this.portTxtBox.Size = new System.Drawing.Size(87, 20);
            this.portTxtBox.TabIndex = 8;
            this.portTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.portTxtBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Port:";
            this.toolTip1.SetToolTip(this.label5, "Server Port");
            // 
            // maxCarsCombo
            // 
            this.maxCarsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxCarsCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.maxCarsCombo.FormattingEnabled = true;
            this.maxCarsCombo.Location = new System.Drawing.Point(432, 79);
            this.maxCarsCombo.MaxDropDownItems = 10;
            this.maxCarsCombo.Name = "maxCarsCombo";
            this.maxCarsCombo.Size = new System.Drawing.Size(65, 21);
            this.maxCarsCombo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max Cars for each player:";
            this.toolTip1.SetToolTip(this.label4, "Max vehicles a player is allowed to spawn");
            // 
            // maxPlayerCombo
            // 
            this.maxPlayerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxPlayerCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.maxPlayerCombo.FormattingEnabled = true;
            this.maxPlayerCombo.Location = new System.Drawing.Point(432, 29);
            this.maxPlayerCombo.MaxDropDownItems = 10;
            this.maxPlayerCombo.Name = "maxPlayerCombo";
            this.maxPlayerCombo.Size = new System.Drawing.Size(65, 21);
            this.maxPlayerCombo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Players:";
            this.toolTip1.SetToolTip(this.label3, "Maximum Amount of Clients(players)");
            // 
            // descTxtBox
            // 
            this.descTxtBox.Location = new System.Drawing.Point(75, 41);
            this.descTxtBox.Multiline = true;
            this.descTxtBox.Name = "descTxtBox";
            this.descTxtBox.Size = new System.Drawing.Size(316, 41);
            this.descTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            this.toolTip1.SetToolTip(this.label2, "The description that will be shown in the BeamMP client server list");
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(50, 17);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(341, 20);
            this.nameTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.toolTip1.SetToolTip(this.label1, "The name that will be shown in the BeamMP client server list");
            // 
            // privChckBox
            // 
            this.privChckBox.AutoSize = true;
            this.privChckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.privChckBox.Location = new System.Drawing.Point(8, 17);
            this.privChckBox.Name = "privChckBox";
            this.privChckBox.Size = new System.Drawing.Size(65, 18);
            this.privChckBox.TabIndex = 11;
            this.privChckBox.Text = "Private";
            this.toolTip1.SetToolTip(this.privChckBox, "If you have an Auth key, by setting the server to private it won\'t be shown in th" +
        "e server list. Other people will have to join using your IP address");
            this.privChckBox.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.saveBtn.Location = new System.Drawing.Point(462, 356);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(82, 39);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectResLocBtn);
            this.groupBox1.Controls.Add(this.debugChckBox);
            this.groupBox1.Controls.Add(this.privChckBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 43);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other";
            // 
            // selectResLocBtn
            // 
            this.selectResLocBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selectResLocBtn.Location = new System.Drawing.Point(341, 9);
            this.selectResLocBtn.Name = "selectResLocBtn";
            this.selectResLocBtn.Size = new System.Drawing.Size(89, 30);
            this.selectResLocBtn.TabIndex = 18;
            this.selectResLocBtn.Text = "Resource folder location...";
            this.selectResLocBtn.UseVisualStyleBackColor = true;
            this.selectResLocBtn.Visible = false;
            this.selectResLocBtn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // debugChckBox
            // 
            this.debugChckBox.AutoSize = true;
            this.debugChckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.debugChckBox.Location = new System.Drawing.Point(75, 17);
            this.debugChckBox.Name = "debugChckBox";
            this.debugChckBox.Size = new System.Drawing.Size(84, 18);
            this.debugChckBox.TabIndex = 12;
            this.debugChckBox.Text = "Debugging";
            this.toolTip1.SetToolTip(this.debugChckBox, "Enable debug console output");
            this.debugChckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(154, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Open mods folder";
            this.toolTip1.SetToolTip(this.button2, "Put any kind of mods in this folder (preferably don\'t put maps here)");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 60;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(155, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Open plugins folder";
            this.toolTip1.SetToolTip(this.button4, "Put plugins in this folder");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toolStrip1);
            this.groupBox3.Controls.Add(this.restartBtn);
            this.groupBox3.Controls.Add(this.startBtn);
            this.groupBox3.Location = new System.Drawing.Point(275, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 39);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(82, 11);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(32, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.restartBtn.Enabled = false;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartBtn.Location = new System.Drawing.Point(206, 13);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(75, 22);
            this.restartBtn.TabIndex = 1;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(4, 13);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 22);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchModsBtn);
            this.groupBox4.Controls.Add(this.modListView);
            this.groupBox4.Controls.Add(this.activateModBtn);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(568, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 243);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mods (Maps not included)";
            // 
            // modListView
            // 
            this.modListView.FullRowSelect = true;
            this.modListView.HideSelection = false;
            this.modListView.LargeImageList = this.modsImgList;
            this.modListView.Location = new System.Drawing.Point(6, 13);
            this.modListView.MultiSelect = false;
            this.modListView.Name = "modListView";
            this.modListView.ShowItemToolTips = true;
            this.modListView.Size = new System.Drawing.Size(256, 199);
            this.modListView.SmallImageList = this.modsImgList;
            this.modListView.TabIndex = 15;
            this.modListView.UseCompatibleStateImageBehavior = false;
            this.modListView.SelectedIndexChanged += new System.EventHandler(this.modListView_SelectedIndexChanged);
            // 
            // modsImgList
            // 
            this.modsImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.modsImgList.ImageSize = new System.Drawing.Size(64, 64);
            this.modsImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // activateModBtn
            // 
            this.activateModBtn.Enabled = false;
            this.activateModBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.activateModBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.activateModBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.activateModBtn.Location = new System.Drawing.Point(6, 215);
            this.activateModBtn.Name = "activateModBtn";
            this.activateModBtn.Size = new System.Drawing.Size(64, 23);
            this.activateModBtn.TabIndex = 0;
            this.activateModBtn.Text = "Activate";
            this.activateModBtn.UseVisualStyleBackColor = true;
            this.activateModBtn.Click += new System.EventHandler(this.activateModBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.searchPluginsBtn);
            this.groupBox5.Controls.Add(this.pluginlistView);
            this.groupBox5.Controls.Add(this.activatePluginsBtn);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Location = new System.Drawing.Point(567, 252);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 198);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Plugins";
            // 
            // pluginlistView
            // 
            this.pluginlistView.FullRowSelect = true;
            this.pluginlistView.HideSelection = false;
            this.pluginlistView.LargeImageList = this.pluginImgList;
            this.pluginlistView.Location = new System.Drawing.Point(6, 13);
            this.pluginlistView.MultiSelect = false;
            this.pluginlistView.Name = "pluginlistView";
            this.pluginlistView.ShowItemToolTips = true;
            this.pluginlistView.Size = new System.Drawing.Size(257, 154);
            this.pluginlistView.SmallImageList = this.pluginImgList;
            this.pluginlistView.TabIndex = 15;
            this.pluginlistView.UseCompatibleStateImageBehavior = false;
            this.pluginlistView.View = System.Windows.Forms.View.SmallIcon;
            this.pluginlistView.SelectedIndexChanged += new System.EventHandler(this.pluginlistView_SelectedIndexChanged);
            // 
            // pluginImgList
            // 
            this.pluginImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pluginImgList.ImageStream")));
            this.pluginImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.pluginImgList.Images.SetKeyName(0, "plugin.png");
            // 
            // activatePluginsBtn
            // 
            this.activatePluginsBtn.Enabled = false;
            this.activatePluginsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.activatePluginsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.activatePluginsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.activatePluginsBtn.Location = new System.Drawing.Point(7, 170);
            this.activatePluginsBtn.Name = "activatePluginsBtn";
            this.activatePluginsBtn.Size = new System.Drawing.Size(64, 23);
            this.activatePluginsBtn.TabIndex = 0;
            this.activatePluginsBtn.Text = "Activate";
            this.activatePluginsBtn.UseVisualStyleBackColor = true;
            this.activatePluginsBtn.Click += new System.EventHandler(this.activatePluginsBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.searchMapsBtn);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.mapgrp);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.saveBtn);
            this.groupBox6.Location = new System.Drawing.Point(12, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(550, 403);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ServerConfig.toml";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(523, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button1, "Help-Information");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reloadCfgBtn
            // 
            this.reloadCfgBtn.FlatAppearance.BorderSize = 0;
            this.reloadCfgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadCfgBtn.Image = ((System.Drawing.Image)(resources.GetObject("reloadCfgBtn.Image")));
            this.reloadCfgBtn.Location = new System.Drawing.Point(-3, -3);
            this.reloadCfgBtn.Name = "reloadCfgBtn";
            this.reloadCfgBtn.Size = new System.Drawing.Size(24, 24);
            this.reloadCfgBtn.TabIndex = 2;
            this.toolTip1.SetToolTip(this.reloadCfgBtn, "Reload settings, maps etc");
            this.reloadCfgBtn.UseVisualStyleBackColor = true;
            this.reloadCfgBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchMapsBtn
            // 
            this.searchMapsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchMapsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchMapsBtn.Image = global::BeamMP_Tool.Properties.Resources.search;
            this.searchMapsBtn.Location = new System.Drawing.Point(504, 131);
            this.searchMapsBtn.Name = "searchMapsBtn";
            this.searchMapsBtn.Size = new System.Drawing.Size(27, 24);
            this.searchMapsBtn.TabIndex = 20;
            this.toolTip1.SetToolTip(this.searchMapsBtn, "Search Maps");
            this.searchMapsBtn.UseVisualStyleBackColor = true;
            this.searchMapsBtn.Click += new System.EventHandler(this.searchMapsBtn_Click);
            // 
            // searchPluginsBtn
            // 
            this.searchPluginsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchPluginsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchPluginsBtn.Image = global::BeamMP_Tool.Properties.Resources.search;
            this.searchPluginsBtn.Location = new System.Drawing.Point(100, 170);
            this.searchPluginsBtn.Name = "searchPluginsBtn";
            this.searchPluginsBtn.Size = new System.Drawing.Size(27, 24);
            this.searchPluginsBtn.TabIndex = 19;
            this.toolTip1.SetToolTip(this.searchPluginsBtn, "Search Plugins");
            this.searchPluginsBtn.UseVisualStyleBackColor = true;
            this.searchPluginsBtn.Click += new System.EventHandler(this.searchPluginsBtn_Click);
            // 
            // searchModsBtn
            // 
            this.searchModsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchModsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchModsBtn.Image = global::BeamMP_Tool.Properties.Resources.search;
            this.searchModsBtn.Location = new System.Drawing.Point(99, 215);
            this.searchModsBtn.Name = "searchModsBtn";
            this.searchModsBtn.Size = new System.Drawing.Size(27, 24);
            this.searchModsBtn.TabIndex = 18;
            this.toolTip1.SetToolTip(this.searchModsBtn, "Search Mods");
            this.searchModsBtn.UseVisualStyleBackColor = true;
            this.searchModsBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCustomStartupFileToolStripMenuItem,
            this.autoRestartTimerToolStripMenuItem,
            this.logToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 22);
            // 
            // setCustomStartupFileToolStripMenuItem
            // 
            this.setCustomStartupFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.resetToDefaultToolStripMenuItem});
            this.setCustomStartupFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setCustomStartupFileToolStripMenuItem.Image")));
            this.setCustomStartupFileToolStripMenuItem.Name = "setCustomStartupFileToolStripMenuItem";
            this.setCustomStartupFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.setCustomStartupFileToolStripMenuItem.Text = "Set custom startup file...";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.selectToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.selectToolStripMenuItem.Text = "Select...";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // resetToDefaultToolStripMenuItem
            // 
            this.resetToDefaultToolStripMenuItem.Name = "resetToDefaultToolStripMenuItem";
            this.resetToDefaultToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.resetToDefaultToolStripMenuItem.Text = "Reset to default (BeamMP-Server.exe)";
            this.resetToDefaultToolStripMenuItem.Click += new System.EventHandler(this.resetToDefaultToolStripMenuItem_Click);
            // 
            // autoRestartTimerToolStripMenuItem
            // 
            this.autoRestartTimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("autoRestartTimerToolStripMenuItem.Image")));
            this.autoRestartTimerToolStripMenuItem.Name = "autoRestartTimerToolStripMenuItem";
            this.autoRestartTimerToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.autoRestartTimerToolStripMenuItem.Text = "Auto restart timer";
            this.autoRestartTimerToolStripMenuItem.Click += new System.EventHandler(this.autoRestartTimerToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logToolStripMenuItem.Image")));
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BeamMP_Tool.Properties.Resources.paypal_donate_button_high_quality_png_1_orig;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(5, 417);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 36);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reloadCfgBtn);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BeamMP Server Management Tool v2.1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mapgrp.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mapgrp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox descTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox maxPlayerCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox maxCarsCombo;
        private System.Windows.Forms.TextBox portTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox authTxtBox;
        private System.Windows.Forms.Button reloadCfgBtn;
        private System.Windows.Forms.CheckBox privChckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox debugChckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem setCustomStartupFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRestartTimerToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog selectCustomStartFile;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.Button selectResLocBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button activateModBtn;
        private System.Windows.Forms.ListView modListView;
        private System.Windows.Forms.ImageList modsImgList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView pluginlistView;
        private System.Windows.Forms.Button activatePluginsBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList pluginImgList;
        private System.Windows.Forms.ListView mapsListView;
        private System.Windows.Forms.ImageList defMapsImgList;
        private System.Windows.Forms.ImageList mainMapImgList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button searchModsBtn;
        private System.Windows.Forms.Button searchPluginsBtn;
        private System.Windows.Forms.Button searchMapsBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


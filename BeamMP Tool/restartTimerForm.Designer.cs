
namespace BeamMP_Tool
{
    partial class restartTimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(restartTimerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setAutoResMsgBtn = new System.Windows.Forms.Button();
            this.msgResChckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restartHoursTxtBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cfgResSetMsgBtn = new System.Windows.Forms.Button();
            this.modPluginChangesChckBox = new System.Windows.Forms.CheckBox();
            this.msgCfgResChckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.restartCfgSecondsTxtBox = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.baseFormUsrCtrl1 = new BeamMP_Tool.baseFormUsrCtrl();
            this.restartMinsTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.restartMinsTxtBox);
            this.groupBox1.Controls.Add(this.setAutoResMsgBtn);
            this.groupBox1.Controls.Add(this.msgResChckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.restartHoursTxtBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(14, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto restart";
            // 
            // setAutoResMsgBtn
            // 
            this.setAutoResMsgBtn.Enabled = false;
            this.setAutoResMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.setAutoResMsgBtn.Location = new System.Drawing.Point(229, 31);
            this.setAutoResMsgBtn.Name = "setAutoResMsgBtn";
            this.setAutoResMsgBtn.Size = new System.Drawing.Size(75, 23);
            this.setAutoResMsgBtn.TabIndex = 4;
            this.setAutoResMsgBtn.Text = "Set message";
            this.setAutoResMsgBtn.UseVisualStyleBackColor = true;
            this.setAutoResMsgBtn.Visible = false;
            this.setAutoResMsgBtn.Click += new System.EventHandler(this.setAutoResMsgBtn_Click);
            // 
            // msgResChckBox
            // 
            this.msgResChckBox.AutoSize = true;
            this.msgResChckBox.Location = new System.Drawing.Point(190, 15);
            this.msgResChckBox.Name = "msgResChckBox";
            this.msgResChckBox.Size = new System.Drawing.Size(161, 17);
            this.msgResChckBox.TabIndex = 4;
            this.msgResChckBox.Text = "Send message before restart";
            this.msgResChckBox.UseVisualStyleBackColor = true;
            this.msgResChckBox.Visible = false;
            this.msgResChckBox.CheckedChanged += new System.EventHandler(this.msgResChckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours : Minutes between restarts:\r\n";
            // 
            // restartHoursTxtBox
            // 
            this.restartHoursTxtBox.Location = new System.Drawing.Point(6, 33);
            this.restartHoursTxtBox.MaxLength = 6;
            this.restartHoursTxtBox.Name = "restartHoursTxtBox";
            this.restartHoursTxtBox.Size = new System.Drawing.Size(84, 20);
            this.restartHoursTxtBox.TabIndex = 2;
            this.restartHoursTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restartHoursTxtBox_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(223, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cfgResSetMsgBtn);
            this.groupBox2.Controls.Add(this.modPluginChangesChckBox);
            this.groupBox2.Controls.Add(this.msgCfgResChckBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.restartCfgSecondsTxtBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(14, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check for config update and restart";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cfgResSetMsgBtn
            // 
            this.cfgResSetMsgBtn.Enabled = false;
            this.cfgResSetMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cfgResSetMsgBtn.Location = new System.Drawing.Point(229, 32);
            this.cfgResSetMsgBtn.Name = "cfgResSetMsgBtn";
            this.cfgResSetMsgBtn.Size = new System.Drawing.Size(75, 23);
            this.cfgResSetMsgBtn.TabIndex = 5;
            this.cfgResSetMsgBtn.Text = "Set message";
            this.cfgResSetMsgBtn.UseVisualStyleBackColor = true;
            this.cfgResSetMsgBtn.Visible = false;
            // 
            // modPluginChangesChckBox
            // 
            this.modPluginChangesChckBox.AutoSize = true;
            this.modPluginChangesChckBox.Enabled = false;
            this.modPluginChangesChckBox.Location = new System.Drawing.Point(127, 32);
            this.modPluginChangesChckBox.Name = "modPluginChangesChckBox";
            this.modPluginChangesChckBox.Size = new System.Drawing.Size(116, 30);
            this.modPluginChangesChckBox.TabIndex = 6;
            this.modPluginChangesChckBox.Text = "Check for mod and\r\n  plugin changes";
            this.modPluginChangesChckBox.UseVisualStyleBackColor = true;
            this.modPluginChangesChckBox.Visible = false;
            // 
            // msgCfgResChckBox
            // 
            this.msgCfgResChckBox.AutoSize = true;
            this.msgCfgResChckBox.Location = new System.Drawing.Point(190, 15);
            this.msgCfgResChckBox.Name = "msgCfgResChckBox";
            this.msgCfgResChckBox.Size = new System.Drawing.Size(161, 17);
            this.msgCfgResChckBox.TabIndex = 6;
            this.msgCfgResChckBox.Text = "Send message before restart";
            this.msgCfgResChckBox.UseVisualStyleBackColor = true;
            this.msgCfgResChckBox.Visible = false;
            this.msgCfgResChckBox.CheckedChanged += new System.EventHandler(this.msgCfgResChckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seconds between config checks:";
            // 
            // restartCfgSecondsTxtBox
            // 
            this.restartCfgSecondsTxtBox.Location = new System.Drawing.Point(6, 37);
            this.restartCfgSecondsTxtBox.MaxLength = 6;
            this.restartCfgSecondsTxtBox.Name = "restartCfgSecondsTxtBox";
            this.restartCfgSecondsTxtBox.Size = new System.Drawing.Size(111, 20);
            this.restartCfgSecondsTxtBox.TabIndex = 4;
            this.restartCfgSecondsTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restartHoursTxtBox_KeyPress);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(222, 100);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Enable";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveBtn.Location = new System.Drawing.Point(113, 175);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // baseFormUsrCtrl1
            // 
            this.baseFormUsrCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.baseFormUsrCtrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.baseFormUsrCtrl1.ControlBox = true;
            this.baseFormUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseFormUsrCtrl1.Icon = global::BeamMP_Tool.Properties.Resources._264;
            this.baseFormUsrCtrl1.Location = new System.Drawing.Point(0, 0);
            this.baseFormUsrCtrl1.Minimize_Button = false;
            this.baseFormUsrCtrl1.Name = "baseFormUsrCtrl1";
            this.baseFormUsrCtrl1.parentForm = this;
            this.baseFormUsrCtrl1.Size = new System.Drawing.Size(300, 210);
            this.baseFormUsrCtrl1.TabIndex = 0;
            this.baseFormUsrCtrl1.Title = "Restart Timers";
            this.baseFormUsrCtrl1.Load += new System.EventHandler(this.baseFormUsrCtrl1_Load);
            // 
            // restartMinsTxtBox
            // 
            this.restartMinsTxtBox.Location = new System.Drawing.Point(100, 33);
            this.restartMinsTxtBox.MaxLength = 6;
            this.restartMinsTxtBox.Name = "restartMinsTxtBox";
            this.restartMinsTxtBox.Size = new System.Drawing.Size(71, 20);
            this.restartMinsTxtBox.TabIndex = 5;
            this.restartMinsTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.restartMinsTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restartHoursTxtBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(90, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // restartTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.baseFormUsrCtrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "restartTimerForm";
            this.Text = "Restart Timers";
            this.Load += new System.EventHandler(this.restartTimerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox restartHoursTxtBox;
        private baseFormUsrCtrl baseFormUsrCtrl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox restartCfgSecondsTxtBox;
        private System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox modPluginChangesChckBox;
        private System.Windows.Forms.Button setAutoResMsgBtn;
        private System.Windows.Forms.CheckBox msgResChckBox;
        private System.Windows.Forms.Button cfgResSetMsgBtn;
        private System.Windows.Forms.CheckBox msgCfgResChckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox restartMinsTxtBox;
    }
}

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
            this.label1 = new System.Windows.Forms.Label();
            this.restartHoursTxtBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.modPluginChangesChckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.restartCfgSecondsTxtBox = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.restartHoursTxtBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto restart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours between restarts:\r\n";
            // 
            // restartHoursTxtBox
            // 
            this.restartHoursTxtBox.Location = new System.Drawing.Point(6, 33);
            this.restartHoursTxtBox.Name = "restartHoursTxtBox";
            this.restartHoursTxtBox.Size = new System.Drawing.Size(127, 20);
            this.restartHoursTxtBox.TabIndex = 2;
            this.restartHoursTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restartHoursTxtBox_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(194, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.modPluginChangesChckBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.restartCfgSecondsTxtBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(9, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check for config update and restart";
            // 
            // modPluginChangesChckBox
            // 
            this.modPluginChangesChckBox.AutoSize = true;
            this.modPluginChangesChckBox.Enabled = false;
            this.modPluginChangesChckBox.Location = new System.Drawing.Point(131, 32);
            this.modPluginChangesChckBox.Name = "modPluginChangesChckBox";
            this.modPluginChangesChckBox.Size = new System.Drawing.Size(116, 30);
            this.modPluginChangesChckBox.TabIndex = 6;
            this.modPluginChangesChckBox.Text = "Check for mod and\r\n  plugin changes";
            this.modPluginChangesChckBox.UseVisualStyleBackColor = true;
            this.modPluginChangesChckBox.Visible = false;
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
            this.restartCfgSecondsTxtBox.Name = "restartCfgSecondsTxtBox";
            this.restartCfgSecondsTxtBox.Size = new System.Drawing.Size(111, 20);
            this.restartCfgSecondsTxtBox.TabIndex = 4;
            this.restartCfgSecondsTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restartHoursTxtBox_KeyPress);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(194, 70);
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
            this.saveBtn.Location = new System.Drawing.Point(95, 137);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // restartTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 163);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "restartTimerForm";
            this.Text = "Restart Timer";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox restartCfgSecondsTxtBox;
        private System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox modPluginChangesChckBox;
    }
}
namespace BeamMP_Tool
{
    partial class largeSrvConsoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(largeSrvConsoleForm));
            this.baseFormUsrCtrl1 = new BeamMP_Tool.baseFormUsrCtrl();
            this.customSmoothBtn3 = new BeamMP_Tool.customSmoothBtn();
            this.outputTxtBox = new System.Windows.Forms.RichTextBox();
            this.stopAutoScrlChckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // baseFormUsrCtrl1
            // 
            this.baseFormUsrCtrl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.baseFormUsrCtrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.baseFormUsrCtrl1.ControlBox = true;
            this.baseFormUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseFormUsrCtrl1.Icon = global::BeamMP_Tool.Properties.Resources.icons8_code_48;
            this.baseFormUsrCtrl1.Location = new System.Drawing.Point(0, 0);
            this.baseFormUsrCtrl1.Minimize_Button = true;
            this.baseFormUsrCtrl1.Name = "baseFormUsrCtrl1";
            this.baseFormUsrCtrl1.parentForm = this;
            this.baseFormUsrCtrl1.Size = new System.Drawing.Size(826, 402);
            this.baseFormUsrCtrl1.TabIndex = 0;
            this.baseFormUsrCtrl1.Title = "BeamMP Server Console";
            this.baseFormUsrCtrl1.Load += new System.EventHandler(this.baseFormUsrCtrl1_Load);
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
            this.customSmoothBtn3.Location = new System.Drawing.Point(193, 5);
            this.customSmoothBtn3.Name = "customSmoothBtn3";
            this.customSmoothBtn3.Size = new System.Drawing.Size(42, 20);
            this.customSmoothBtn3.TabIndex = 38;
            this.customSmoothBtn3.Text = "Clear";
            this.customSmoothBtn3.TransitionSpeed = 130;
            this.customSmoothBtn3.UseVisualStyleBackColor = false;
            this.customSmoothBtn3.Click += new System.EventHandler(this.customSmoothBtn3_Click);
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.outputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTxtBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.outputTxtBox.ForeColor = System.Drawing.Color.White;
            this.outputTxtBox.Location = new System.Drawing.Point(10, 28);
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.ReadOnly = true;
            this.outputTxtBox.Size = new System.Drawing.Size(806, 364);
            this.outputTxtBox.TabIndex = 39;
            this.outputTxtBox.Text = "";
            // 
            // stopAutoScrlChckBox
            // 
            this.stopAutoScrlChckBox.AutoSize = true;
            this.stopAutoScrlChckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(33)))), ((int)(((byte)(57)))));
            this.stopAutoScrlChckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.stopAutoScrlChckBox.Location = new System.Drawing.Point(241, 7);
            this.stopAutoScrlChckBox.Name = "stopAutoScrlChckBox";
            this.stopAutoScrlChckBox.Size = new System.Drawing.Size(113, 17);
            this.stopAutoScrlChckBox.TabIndex = 40;
            this.stopAutoScrlChckBox.Text = "Stop auto-scrolling";
            this.stopAutoScrlChckBox.UseVisualStyleBackColor = false;
            // 
            // largeSrvConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 402);
            this.ControlBox = false;
            this.Controls.Add(this.stopAutoScrlChckBox);
            this.Controls.Add(this.customSmoothBtn3);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.baseFormUsrCtrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "largeSrvConsoleForm";
            this.Text = "BeamMP Server Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.largeSrvConsoleForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private baseFormUsrCtrl baseFormUsrCtrl1;
        public System.Windows.Forms.RichTextBox outputTxtBox;
        public customSmoothBtn customSmoothBtn3;
        public System.Windows.Forms.CheckBox stopAutoScrlChckBox;
    }
}
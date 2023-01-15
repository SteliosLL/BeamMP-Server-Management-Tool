using System;
using System.Windows.Forms;

namespace BeamMP_Tool
{
    public partial class restartTimerForm : Form
    {
        public restartTimerForm()
        {
            InitializeComponent();
        }
        public int restartTimerHours { get; set; }
        public int restartCfgTimerSecs { get; set; }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = checkBox2.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = checkBox1.Checked;

        }

        private void restartTimerForm_Load(object sender, EventArgs e)
        {
            restartHoursTxtBox.Text = Properties.Settings.Default.restartTimerHours.ToString();
            checkBox1.Checked = Properties.Settings.Default.restartTimer;
            restartCfgSecondsTxtBox.Text = Properties.Settings.Default.checkRestartCfgTimerSeconds.ToString(); ;
            checkBox2.Checked = Properties.Settings.Default.checkRestartCfgTimer;
            modPluginChangesChckBox.Checked = Properties.Settings.Default.checkModPluginChanges;//CURRENTLY UNUSED
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (restartHoursTxtBox.Text == "" || restartHoursTxtBox.Text == "0")
                {
                    MessageBox.Show("Please fill out all the required areas", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (checkBox2.Checked)
            {
                if (restartCfgSecondsTxtBox.Text == ""|| restartCfgSecondsTxtBox.Text == "0")
                {
                    MessageBox.Show("Please fill out all the required areas", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            this.restartTimerHours = int.Parse(restartHoursTxtBox.Text);
            this.restartCfgTimerSecs = int.Parse(restartCfgSecondsTxtBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void restartHoursTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

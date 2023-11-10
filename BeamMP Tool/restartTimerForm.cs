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
        public int restartTimerMins{ get; set; }
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
            var totalMinutes = Properties.Settings.Default.restartTimerMins;
            var time = TimeSpan.FromMinutes(totalMinutes);
            restartHoursTxtBox.Text = ((int)time.TotalHours).ToString();
            restartMinsTxtBox.Text = time.Minutes.ToString();
            checkBox1.Checked = Properties.Settings.Default.restartTimer;
            restartCfgSecondsTxtBox.Text = Properties.Settings.Default.checkRestartCfgTimerSeconds.ToString(); ;
            checkBox2.Checked = Properties.Settings.Default.checkRestartCfgTimer;
            modPluginChangesChckBox.Checked = Properties.Settings.Default.checkModPluginChanges;//CURRENTLY UNUSED
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if ((restartHoursTxtBox.Text.Trim() == "" || restartHoursTxtBox.Text.Trim() == "0") && (restartMinsTxtBox.Text.Trim() == "" || restartMinsTxtBox.Text.Trim() =="0"))
                {
                    MessageBox.Show("Please fill out all the required areas", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (restartMinsTxtBox.Text.Trim() == "0") restartMinsTxtBox.Text = "0";
            }
            if (checkBox2.Checked)
            {
                if (restartCfgSecondsTxtBox.Text.Trim() == "" || restartCfgSecondsTxtBox.Text.Trim() == "0")
                {
                    MessageBox.Show("Please fill out all the required areas", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (restartHoursTxtBox.Text.Trim() == "") restartHoursTxtBox.Text = "0";
            if (restartMinsTxtBox.Text.Trim() == "") restartMinsTxtBox.Text = "0";
            this.restartTimerMins = int.Parse(restartHoursTxtBox.Text.Trim()) * 60 + int.Parse(restartMinsTxtBox.Text.Trim());
            this.restartCfgTimerSecs = int.Parse(restartCfgSecondsTxtBox.Text.Trim());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void restartHoursTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') )
            {
                e.Handled = true;
            }
        }
        private void msgResChckBox_CheckedChanged(object sender, EventArgs e)
        {
            setAutoResMsgBtn.Enabled = msgResChckBox.Checked;
        }

        private void msgCfgResChckBox_CheckedChanged(object sender, EventArgs e)
        {
            cfgResSetMsgBtn.Enabled = msgCfgResChckBox.Checked;
        }

        private void setAutoResMsgBtn_Click(object sender, EventArgs e)
        {
            msgBox.inputBoxShow(this, "Enter the message to display 1 minute before the restart ", "Set Auto restart timer");
        }
        public static string setMsgInputBoxShow(Form parent, string body = "", string title = "")
        {
            string diagRes;
            msgBox MsgBox = new msgBox();
            Label lbl = new Label();
            diagRes = MsgBox.showInput(parent, body, title);
            MsgBox.Dispose();
            return diagRes;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void baseFormUsrCtrl1_Load(object sender, EventArgs e)
        {

        }
    }
}

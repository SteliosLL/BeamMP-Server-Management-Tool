using System;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace BeamMP_Tool
{
    public partial class customizeNameFrm : Form
    {
        public customizeNameFrm(Form callingFrm, RichTextBox box, string title)
        {
            callingForm = callingFrm as Form1;
            InitializeComponent();
            rBox = box;
            Text = title;
            RTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.callingForm.nameTxtBox_KeyPress);
            baseFormUsrCtrl1.Title = title;
        }

        private void appendLog(string text)
        {
            log.Append(text);
            callingForm.InvokeIfRequired(callingForm.logForm.textBox1, () => { callingForm.logForm.textBox1.AppendText(DateTime.Now.ToString("hh:mm tt") + ">>> " + text + Environment.NewLine); });
        }
        public void showMenuStripAtBtn(ContextMenuStrip menuStrip, Button btn)
        {
            //menuStrip.Visible = true;
            menuStrip.Show(btn, new Point(btn.Width - btn.Width, btn.Height));
        }
        Form1 callingForm;
        RichTextBox rBox;
        private void baseFormUsrCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void customizeNameFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            callingForm.customNamefrm = null;

        }

        private void customizeNameFrm_Load(object sender, EventArgs e)
        {

            RTxtBox.Rtf = rBox.Rtf;
            if (Text == "Customize Server Name")
            {
                RTxtBox.Multiline = false;
                this.Width = this.Width + 85;
            }
            underLnBtn.Font = new Font(underLnBtn.Font, FontStyle.Underline);
            strikeBtn.Font = new Font(strikeBtn.Font, FontStyle.Strikeout);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            rBox.Rtf = RTxtBox.Rtf;
            this.Close();
        }
        string richTxt;

        private void button1_Click(object sender, EventArgs e)
        {
            richTxt = RTxtBox.Rtf;
            //richTextBox1.Clear();
            RTxtBox.Text = richTxt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RTxtBox.Rtf = RTxtBox.Text;
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            RTxtBox.SelectionColor = colorBtn.FlatAppearance.BorderColor;
        }

        private void colorDropBtn_Click(object sender, EventArgs e)
        {
            showMenuStripAtBtn(contextMenuStrip1, colorBtn);

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedBtn;
            clickedBtn = (ToolStripMenuItem)sender;
            //DO WHATEVER YOU WANT HERE.
            colorBtn.FlatAppearance.BorderColor = clickedBtn.BackColor;
            RTxtBox.SelectionColor = clickedBtn.BackColor;
        }


        private void underLnBtn_Click(object sender, EventArgs e)
        {

            callingForm.setSelectionFormatting("underline", RTxtBox);
        }
        private void customSmoothBtn1_Click(object sender, EventArgs e)
        {

            callingForm.setSelectionFormatting("bold", RTxtBox);
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            callingForm.setSelectionFormatting("italic", RTxtBox);
        }
        private void strikeBtn_Click(object sender, EventArgs e)
        {
            callingForm.setSelectionFormatting("strike", RTxtBox);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            callingForm.BeamMPtoRTF_conv(callingForm.descTxtBox.Text, RTxtBox);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void customSmoothBtn1_Click_1(object sender, EventArgs e)
        {
            RTxtBox.SelectAll();
            RTxtBox.SelectionFont = new Font(RTxtBox.SelectionFont, FontStyle.Regular);
            RTxtBox.SelectionColor = Color.White;
        }
    }
}

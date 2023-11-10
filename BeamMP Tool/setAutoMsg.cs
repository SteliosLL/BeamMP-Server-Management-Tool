using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeamMP_Tool
{
    public partial class setAutoMsg : Form
    {
        public setAutoMsg()
        {
            InitializeComponent();
        }
        private void baseFormUsrCtrl1_Load(object sender, EventArgs e)
        {

        }
        private void tabBtnClick(customSmoothBtn btn, Panel pnl)
        {
            scheduleMsgBtn.BackColor = Color.Transparent;
            scheduleMsgBtn.ColorNormal = Color.Transparent;
            srvResBtn.BackColor = Color.Transparent;
            srvResBtn.ColorNormal = Color.Transparent;
            srvautoshutBtn.BackColor = Color.Transparent;
            srvautoshutBtn.ColorNormal = Color.Transparent;

            btn.BackColor = Form1.colorNormal;
            btn.ColorNormal = Form1.colorNormal;
            pnl.BringToFront();
        }
        private void srvNamePnlLbl_Click(object sender, EventArgs e)
        {

        }

        private void activateModBtn_Click(object sender, EventArgs e)
        {
            tabBtnClick(srvResBtn, schedMsgPnl);
        }

        private void customSmoothBtn2_Click(object sender, EventArgs e)
        {
            tabBtnClick(scheduleMsgBtn, schedMsgPnl);
        }

        private void customSmoothBtn1_Click(object sender, EventArgs e)
        {
            tabBtnClick(srvautoshutBtn, schedMsgPnl);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sendMsgTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

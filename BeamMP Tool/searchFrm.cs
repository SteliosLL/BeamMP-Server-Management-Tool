using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace BeamMP_Tool
{
    public partial class searchFrm : Form
    {
        public searchFrm()
        {
            InitializeComponent();
        }

        private void searchFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            textBox1.Text = "";
            this.Hide();
        }

        private void searchFrm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void baseFormUsrCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Transition.run((TextBox)sender, "BackColor", Color.FromArgb(39, 54, 84), new TransitionType_Linear(200));

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Transition.run((TextBox)sender, "BackColor", Color.FromArgb(23, 31, 51), new TransitionType_Linear(150));
        }
    }
}

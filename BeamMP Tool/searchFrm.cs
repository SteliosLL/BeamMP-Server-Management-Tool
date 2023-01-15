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

        }
    }
}

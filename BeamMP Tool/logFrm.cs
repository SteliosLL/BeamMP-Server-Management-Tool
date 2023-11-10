using BeamMP_Tool;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace BeamMP_Tool
{
    public partial class logFrm : Form
    {
        public logFrm()
        {
            InitializeComponent();
        }

        private void logFrm_Load(object sender, EventArgs e)
        {
            logSaver.DoWork += new DoWorkEventHandler(logSaver_DoWork);
            logSaver.RunWorkerAsync();
        }
        BackgroundWorker logSaver = new BackgroundWorker();
        void logSaver_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                log.Save();  //write log to file
                Thread.Sleep(10000);  // Wait 10 seconds
            }
        }

        private void logFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { System.Diagnostics.Process.Start(Application.StartupPath + @"\BeamMP_Server_MT_Logs"); }
            catch { MessageBox.Show("The logs folder couldn't be found!"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

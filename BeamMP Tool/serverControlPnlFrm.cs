using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeamMP_Tool
{
    public partial class serverControlPnlFrm : Form
    {
        public serverControlPnlFrm(Form callingForm)
        {
            callingFrm = callingForm as Form1;
            InitializeComponent();
        }

        public Form1 callingFrm;
        public string srvStartFile;
        private void serverControlPnlFrm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = callingFrm.BackgroundImage;
            //  checkIfSrvIsRunning();
            setTimers();
            mainLoop();

        }

        private void baseFormUsrCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void customSmoothBtn1_Click(object sender, EventArgs e)
        {
            using (var form = new restartTimerForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Properties.Settings.Default.restartTimerMins = form.restartTimerMins;
                    Properties.Settings.Default.restartTimer = form.checkBox1.Checked;
                    Properties.Settings.Default.checkRestartCfgTimerSeconds = form.restartCfgTimerSecs;
                    Properties.Settings.Default.checkRestartCfgTimer = form.checkBox2.Checked;
                    Properties.Settings.Default.checkModPluginChanges = form.modPluginChangesChckBox.Checked;
                    Properties.Settings.Default.Save();
                    setTimers();
                }
            }
        }

        private void toolsBtn_Click(object sender, EventArgs e)
        {
            callingFrm.showMenuStripAtBtn(toolsMenu, toolsBtn);
        }
        public bool beamMPProcRunning()
        {
            try
            {
                if (beamMPServer == null) return false;
                else
                {
                    if (beamMPServer.HasExited)
                    { return false; }
                    else { return true; }
                }
            }
            catch { return false; }

        }
        public Process beamMPServer;
        private bool startServer()
        {
            callingFrm.InvokeIfRequired(outputTxtBox, () => { outputTxtBox.Clear(); });
            callingFrm.InvokeIfRequired(lrgConslFrm.outputTxtBox, () => { lrgConslFrm.outputTxtBox.Clear(); });
            try
            {
                beamMPServer = new Process();
                beamMPServer.StartInfo.FileName = srvStartFile;
                beamMPServer.StartInfo.WorkingDirectory = Application.StartupPath;
               // beamMPServer.StartInfo.UseShellExecute = false;
               // beamMPServer.StartInfo.CreateNoWindow = true;
               // beamMPServer.StartInfo.RedirectStandardOutput = true;
              //  beamMPServer.StartInfo.RedirectStandardError = true;
              //  beamMPServer.StartInfo.RedirectStandardInput = true;
              //  beamMPServer.StartInfo.StandardOutputEncoding = Encoding.Default;
               // beamMPServer.OutputDataReceived += p_OutputDataReceived;
               // beamMPServer.ErrorDataReceived += p_OutputDataReceived;
               // beamMPServer.EnableRaisingEvents = true;
                beamMPServer.Start();
               // beamMPServer.BeginOutputReadLine();
               // beamMPServer.BeginErrorReadLine();

                checkIfSrvIsRunning();
                callingFrm.appendLog("Server started");
                return true;
            }
            catch (Exception)
            {
                callingFrm.appendLog("ERROR: Failed to start the server!");
                msgBox.msgBoxShow(this, "Could not start server! Make sure the server executable is not missing!", "Start Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //why is this not working?????
                startBtn.Text = "Start";
                startBtn.ForeColor = SystemColors.Control;
                enableCtrls_SrvState(false);
                return false;
            }
        }
        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Process p = sender as Process;
            if (p == null) return;
            string formattedData = e.Data;
            callingFrm.InvokeIfRequired(outputTxtBox, () =>
            {
                //clean output by removing leading escape characters and other trash
                int i = 0;
                string Dateformat = "MM/dd/y HH:mm:ss";
                foreach (char ch in formattedData)
                {
                    if (ch == '[')
                    {
                        try
                        {
                            string possibleDate = formattedData.Substring(i + 1, formattedData.IndexOf(']', i) - i - 1);
                            DateTime dateTime;
                            if (DateTime.TryParseExact(possibleDate, Dateformat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                            {
                                formattedData = "> " + formattedData.Remove(0, i);
                                break;
                            }
                        }
                        catch { if (formattedData.Length < 12) formattedData = ">"; }

                    }
                    i++;
                }
                outputTxtBox.AppendText(formattedData + "\n");
                if (!stopAutoScrlChckBox.Checked)
                {
                    callingFrm.scrolltoTxtBoxEnd(null, outputTxtBox);
                }

            });
            //large view
            if (lrgConslFrm != null)
            {
                if (lrgConslFrm.Visible)
                {
                    callingFrm.InvokeIfRequired(lrgConslFrm.outputTxtBox, () =>
                    {
                        lrgConslFrm.outputTxtBox.AppendText(formattedData + "\n");
                        if (!lrgConslFrm.stopAutoScrlChckBox.Checked)
                        { callingFrm.scrolltoTxtBoxEnd(null, lrgConslFrm.outputTxtBox); }

                    });
                }
            }

        }
        private void restartSrv(string restartLogMsg = "Restarting server...")
        {
            callingFrm.appendLog(restartLogMsg);
            try
            { beamMPServer.Kill(); }
            catch (Exception ex) { msgBox.msgBoxShow(this, "Restart failed! Failed to stop the server"); callingFrm.appendLog("ERROR: Failed to restart the server" + Environment.NewLine + ex.ToString()); return; }
            while (!beamMPServer.HasExited)
            { System.Threading.Thread.Sleep(50); }
            startServer();
            callingFrm.appendLog("Server successfully restarted");

        }
        void enableCtrls_SrvState(bool enable)
        {
            callingFrm.InvokeIfRequired(commandsPnl, () => { commandsPnl.Enabled = enable; });
            callingFrm.InvokeIfRequired(sendMsgGrpBox, () => { sendMsgGrpBox.Enabled = enable; });
            callingFrm.InvokeIfRequired(restartBtn, () => { restartBtn.Enabled = enable; });
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (startBtn.Text == "Start")
            {
                if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(srvStartFile)).Length > 0)
                {
                    if (msgBox.msgBoxShow(this, @"A BeamMP Server instance is already running! It needs to exit before you can start the server. Close it by yourself or force quit it right now by clicking ""Yes""", "Start Server", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        try
                        {
                            foreach (Process proc in Process.GetProcessesByName(Path.GetFileNameWithoutExtension(srvStartFile)))
                            { proc.Kill(); }
                        }
                        catch { }
                    }
                    else return;
                }
                if (!startServer()) return;
                startBtn.Text = "Stop";
                startBtn.ForeColor = Color.Red;
                enableCtrls_SrvState(true);

            }
            else if (startBtn.Text == "Stop")
            {
                if (msgBox.msgBoxShow(this, "Continue?", "Stop Server", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        beamMPServer.Kill();
                        startBtn.Text = "Start";
                        startBtn.ForeColor = SystemColors.Control;
                        enableCtrls_SrvState(false);
                    }
                    catch (Exception ex) { callingFrm.appendLog("ERROR: Failed to stop the server! " + ex.ToString()); msgBox.msgBoxShow(this, "Failed to stop the server!"); }

                }

            }
        }
        CountDownTimer restartTimer1 = new CountDownTimer();
        CountDownTimer checkCfgRestartTimer = new CountDownTimer();
        public void mainLoop()
        {
            restartTimer1.CountDownFinished += () => restartSrv("Performing scheduled server restart");
            checkCfgRestartTimer.CountDownFinished += () => checkCfg();
            restartTimer1.TimeChanged += () => callingFrm.InvokeIfRequired(nextSrvRestartValLbl, () =>
            {
                nextSrvRestartValLbl.Text = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
         restartTimer1.tLeft.Hours,
         restartTimer1.tLeft.Minutes,
         restartTimer1.tLeft.Seconds);
            });
            checkCfgRestartTimer.TimeChanged += () => callingFrm.InvokeIfRequired(nextCfgCheckValLbl, () =>
            {
                nextCfgCheckValLbl.Text = string.Format("{0:D2}m:{1:D2}s",
         checkCfgRestartTimer.tLeft.Minutes,
         checkCfgRestartTimer.tLeft.Seconds);
            });
            Task t = Task.Run(() =>
            {
                while (true)
                {
                    //restart timer
                    if (Properties.Settings.Default.restartTimer && beamMPProcRunning() && !restartTimer1.isRunning)
                    {
                        TimeSpan restartIntervalHours = TimeSpan.FromMinutes(Properties.Settings.Default.restartTimerMins);
                        restartTimer1.Start((int)restartIntervalHours.TotalSeconds);

                    }
                    else if ((!Properties.Settings.Default.restartTimer || !beamMPProcRunning()) && restartTimer1.isRunning)
                    {
                        restartTimer1.Stop();
                    }

                    //cfg check restart timer
                    if (Properties.Settings.Default.checkRestartCfgTimer && beamMPProcRunning() && !checkCfgRestartTimer.isRunning)
                    {
                        try
                        { oldCfgFile = File.ReadAllText(Application.StartupPath + Form1.cfgFilePath); }
                        catch { }
                        int checkIntervalSecs = Properties.Settings.Default.checkRestartCfgTimerSeconds;
                        checkCfgRestartTimer.Start(checkIntervalSecs);
                    }
                    else if ((!Properties.Settings.Default.checkRestartCfgTimer || !beamMPProcRunning()) && checkCfgRestartTimer.isRunning)
                    {
                        checkCfgRestartTimer.Stop();
                    }


                    if (!beamMPProcRunning() && (Properties.Settings.Default.restartTimer || Properties.Settings.Default.checkRestartCfgTimer))
                    {
                        setTimers();
                    }
                    System.Threading.Thread.Sleep(200);
                }
            });
        }
        public string oldCfgFile = "";
        public void checkCfg()
        {
            //if both timers are close to zero-ing, temporarily disable one of them so that the countDownFinished events don't fire at the same time
            if ((int)restartTimer1.tLeft.TotalSeconds < 10 && (int)checkCfgRestartTimer.tLeft.TotalSeconds < 10 && restartTimer1.isRunning) return;
            if (System.IO.File.Exists(Application.StartupPath + Form1.cfgFilePath))
            {
                try
                {
                    string newcfg = File.ReadAllText(Application.StartupPath + Form1.cfgFilePath);
                    if (oldCfgFile != newcfg)
                    {
                        oldCfgFile = newcfg;
                        restartSrv("A change in the config file has been detected. Restarting");
                    }
                }
                catch (IOException)
                {
                    callingFrm.appendLog("ERROR: Couldn't read the configuration file.");
                    callingFrm.notifyIcon1.ShowBalloonTip(4000, "Config check and restart ERROR", "Couldn't read the configuration file.", ToolTipIcon.Error);
                }
            }
            else
            {
                callingFrm.appendLog("ERROR: Couldn't find the configuration file.");
                callingFrm.notifyIcon1.ShowBalloonTip(4000, "Config check and restart ERROR", "Couldn't read the configuration file. ", ToolTipIcon.Error);
            }
        }

        public void setTimers()
        {
            TimeSpan tspan1 = TimeSpan.FromMinutes(Properties.Settings.Default.restartTimerMins);
            TimeSpan tspan2 = TimeSpan.FromSeconds(Properties.Settings.Default.checkRestartCfgTimerSeconds);
            callingFrm.InvokeIfRequired(nextSrvRestartLbl, () =>
            {
                nextSrvRestartLbl.Visible = Properties.Settings.Default.restartTimer;
            });
            callingFrm.InvokeIfRequired(nextSrvRestartValLbl, () =>
            {
                nextSrvRestartValLbl.Visible = Properties.Settings.Default.restartTimer;
                nextSrvRestartValLbl.Text = string.Format("{0:00}h:{1:D2}m:{2:D2}s",
      (int)tspan1.TotalHours,
       tspan1.Minutes,
       tspan1.Seconds);
            });
            callingFrm.InvokeIfRequired(resetRestartTimerBtn, () =>
            {
                resetRestartTimerBtn.Visible = Properties.Settings.Default.restartTimer;
            });
            //
            callingFrm.InvokeIfRequired(NextCfgCheckLbl, () =>
            {
                NextCfgCheckLbl.Visible = Properties.Settings.Default.checkRestartCfgTimer;
            });
            callingFrm.InvokeIfRequired(nextCfgCheckValLbl, () =>
            {
                nextCfgCheckValLbl.Visible = Properties.Settings.Default.checkRestartCfgTimer;
                nextCfgCheckValLbl.Text = string.Format("{0:00}m:{1:D2}s",
       (int)tspan2.TotalMinutes,
       tspan2.Seconds);
            });
            callingFrm.InvokeIfRequired(resetCfgTimerBtn, () =>
            {
                resetCfgTimerBtn.Visible = Properties.Settings.Default.checkRestartCfgTimer;
            });
        }
        public void checkIfSrvIsRunning()
        {
            Task t = Task.Run(() =>
            {
                bool serverRunning = true;
                while (serverRunning)
                {
                    if (beamMPServer.HasExited)
                    {
                        //not found
                        callingFrm.InvokeIfRequired(startBtn, () =>
                        {
                            startBtn.Text = "Start";
                            startBtn.ForeColor = SystemColors.Control;
                        });
                        callingFrm.appendLog("Server stopped");
                        enableCtrls_SrvState(false);
                        serverRunning = false;
                    }
                    System.Threading.Thread.Sleep(1500);
                }
            });
        }
        private void restartBtn_Click(object sender, EventArgs e)
        {
            if (msgBox.msgBoxShow(this, "Continue?", "Restart Server", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                restartSrv();
            }

        }

        private void resetRestartTimerBtn_Click(object sender, EventArgs e)
        {
            restartTimer1.Stop();
        }

        private void resetCfgTimerBtn_Click(object sender, EventArgs e)
        {
            checkCfgRestartTimer.Stop();
        }

        private void serverControlPnlFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


        setAutoMsg setautoMsgFrm = new setAutoMsg();

        private void customSmoothBtn5_Click(object sender, EventArgs e)
        {
            showFrm(setautoMsgFrm, setautoMsgFrm.GetType());
        }

        private void showFrm(Form form, Type type)
        {
            if (form == null || form.IsDisposed)
            {
                form = (Form)Activator.CreateInstance(type);
                form.Show();
            }
            else
            {
                form.Show();
                form.Focus();
            }
        }
        private void authTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void tabBtnClick(customSmoothBtn btn, Panel pnl)
        {
            sendTabBtn.BackColor = Color.Transparent;
            sendTabBtn.ColorNormal = Color.Transparent;
            msgTabBtn.BackColor = Color.Transparent;
            msgTabBtn.ColorNormal = Color.Transparent;
            playersBtn.BackColor = Color.Transparent;
            playersBtn.ColorNormal = Color.Transparent;
            autoRestartBtn.BackColor = Color.Transparent;
            autoRestartBtn.ColorNormal = Color.Transparent;

            btn.BackColor = Form1.colorNormal;
            btn.ColorNormal = Form1.colorNormal;
            pnl.BringToFront();
        }
        private void msgTabBtn_Click(object sender, EventArgs e)
        {
            tabBtnClick(msgTabBtn, msgPnl);
        }

        private void sendTabBtn_Click(object sender, EventArgs e)
        {
            tabBtnClick(sendTabBtn, commandsPnl);

        }

        private void mapsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playersListView.SelectedItems.Count > 0)
            {
                kickBtn.Enabled = true;
            }
            else
            {
                kickBtn.Enabled = false;
            }
        }

        private void customSmoothBtn3_Click(object sender, EventArgs e)
        {
            outputTxtBox.Clear();

        }

        private void customSmoothBtn7_Click(object sender, EventArgs e)
        {
            beamMPServer.StandardInput.WriteLine(sendCmdTxtBox.Text.Trim());
            sendCmdTxtBox.Clear();
        }

        private void playersBtn_Click(object sender, EventArgs e)
        {
            tabBtnClick(playersBtn, playersPnl);
        }

        private void autoRestartBtn_Click(object sender, EventArgs e)
        {
            tabBtnClick(autoRestartBtn, autoRestartPnl);
        }

        largeSrvConsoleForm lrgConslFrm = new largeSrvConsoleForm();
        private void customSmoothBtn6_Click(object sender, EventArgs e)
        {
            if (lrgConslFrm == null || lrgConslFrm.IsDisposed)
            {
                lrgConslFrm = new largeSrvConsoleForm();
            }
            lrgConslFrm.Show();
            lrgConslFrm.Focus();
            lrgConslFrm.outputTxtBox.Text = outputTxtBox.Text;
            callingFrm.scrolltoTxtBoxEnd(null, lrgConslFrm.outputTxtBox);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolsMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

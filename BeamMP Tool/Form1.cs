using Newtonsoft.Json;
using Server_Creation_Tool.myClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tommy;

namespace BeamMP_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void InvokeIfRequired(Control control, MethodInvoker action)
        {
            if (control.InvokeRequired)
            { control.Invoke(action); }
            else
            { action(); }
        }
        logFrm logForm = new logFrm();
        string cfgFilePath = @"\ServerConfig.toml";
        private void makeFolders()
        {
            try
            {
                if (!System.IO.Directory.Exists(Application.StartupPath + @"\custom_maps"))
                { System.IO.Directory.CreateDirectory(Application.StartupPath + @"\custom_maps"); }
                if (!System.IO.Directory.Exists(Application.StartupPath + @"\" + resFold + @"\Client\deactivated_mods"))
                { System.IO.Directory.CreateDirectory(Application.StartupPath + @"\" + resFold + @"\Client\deactivated_mods"); }
                if (!System.IO.Directory.Exists(Application.StartupPath + @"\" + resFold + @"\Server\deactivated_plugins"))
                { System.IO.Directory.CreateDirectory(Application.StartupPath + @"\" + resFold + @"\Server\deactivated_plugins"); }
            }
            catch { }
        }
        string resFold;
        private void Form1_Load(object sender, EventArgs e)
        {
            logForm.Show();
            logForm.Hide();
            setControls();
            checkIfSrvIsRunning();
            loadCfg();
            if (!Directory.Exists(resFold))
            { resFold = "Resources"; }
            makeFolders();
            loadMaps();
            configureMaps();
            loadMods();
            loadPlugins();
            toolStrip1.Location = new Point(82, 11);
            srvStartFile = Properties.Settings.Default.srvStartFile;
            if (Properties.Settings.Default.srvStartFile == "")
            { srvStartFile = Application.StartupPath + @"\BeamMP-Server.exe"; selectToolStripMenuItem.ToolTipText = "Default"; }
            else
            { srvStartFile = Properties.Settings.Default.srvStartFile; selectToolStripMenuItem.ToolTipText = srvStartFile; }
            checkRestartCfgTimer();
            restartTimer();
        }

        private void setControls()
        {
            int i = 0;
            while (i < 100)
            {
                i += 1;
                maxPlayerCombo.Items.Add(i);
                maxCarsCombo.Items.Add(i);
            }
        }

        private string assembleFullMapPath(string mapName)
        {
            return @"/levels/" + mapName + @"/info.json";
        }
        string srvStartFile;
        private void loadMaps()
        {
            mapsListView.Clear();
            backupMapListview.Clear();
            mainMapImgList.Images.Clear();
            foreach (Image img in defMapsImgList.Images)
            { mainMapImgList.Images.Add(img); }
            //load default maps
            mapsListView.Items.Add("Gridmap", 1).Tag = @"/levels/gridmap_v2/info.json";
            mapsListView.Items.Add("Automation Test Track", 2).Tag = @"/levels/automation_test_track/info.json";
            mapsListView.Items.Add("East Coast USA", 3).Tag = @"/levels/east_coast_usa/info.json";
            mapsListView.Items.Add("Hirochi Raceway", 4).Tag = @"/levels/hirochi_raceway/info.json";
            mapsListView.Items.Add("Italy", 5).Tag = @"/levels/italy/info.json";
            mapsListView.Items.Add("Industrial", 6).Tag = @"/levels/industrial/info.json";
            mapsListView.Items.Add("Small Island", 7).Tag = @"/levels/small_island/info.json";
            mapsListView.Items.Add("Small Grid", 8).Tag = @"/levels/smallgrid/info.json";
            mapsListView.Items.Add("Utah", 9).Tag = @"/levels/utah/info.json";
            mapsListView.Items.Add("West Coast USA", 10).Tag = @"/levels/west_coast_usa/info.json";
            mapsListView.Items.Add("Driver Training", 11).Tag = @"/levels/driver_training/info.json";
            mapsListView.Items.Add("Derby", 12).Tag = @"/levels/derby/info.json";
            mapsListView.Items.Add("Jungle Rock Island", 13).Tag = @"/levels/jungle_rock_island/info.json";
            foreach (ListViewItem item in mapsListView.Items)
            { backupMapListview.Items.Add((ListViewItem)item.Clone()); ; }

            //load custom mod maps
            List<string> filePaths = new List<string>();
            string[] filePathsCLIENTFold;
            string[] filePathscustom_mapsFold;
            try
            {
                filePathsCLIENTFold = Directory.GetFiles(Application.StartupPath + @"\" + resFold + @"\Client", "*.zip", SearchOption.TopDirectoryOnly);
                filePathscustom_mapsFold = Directory.GetFiles(Application.StartupPath + @"\custom_maps", "*.zip", SearchOption.TopDirectoryOnly);
            }
            catch (Exception) { appendLog(@"The ""custom_maps"" or ""Client"" folder could not be found. No maps loaded"); return; }
            filePaths.AddRange(filePathsCLIENTFold.OfType<string>().ToList());
            filePaths.AddRange(filePathscustom_mapsFold.OfType<string>().ToList());
            foreach (string f in filePaths)
            {
                string[] previewImgName = null;
                string InfJsonmapTitle = null;
                string modInfJsonmapTitle = null;
                string finalMapTitle = null;
                string mapCodeName = null;
                Image img = Properties.Resources.custommap;
                Image secondImg = null;
                using (ZipArchive zip = ZipFile.Open(f, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry jsonEntry = null;
                    ZipArchiveEntry modInfJsonEntry = null;
                    foreach (ZipArchiveEntry entry in zip.Entries)
                    {
                        if (entry.Name == "info.json" && entry.FullName.Contains(@"levels/"))
                        {
                            mapCodeName = entry.FullName.Substring(entry.FullName.IndexOf(@"levels/") + 7, entry.FullName.LastIndexOf(@"/info.json") - entry.FullName.IndexOf(@"levels/") - 7).Trim();
                            jsonEntry = entry;
                        }
                        if (entry.Name == "info.json" && entry.FullName.Contains(@"mod_info/"))
                        { modInfJsonEntry = entry; }
                        if (entry.Name == "icon.png" || entry.Name == "icon.jpg")
                        {
                            Stream s = entry.Open();
                            secondImg = (Image)Image.FromStream(s);
                        }
                    }
                    if (jsonEntry == null) continue;

                    // try
                    //  {
                    using (StreamReader r = new StreamReader(jsonEntry.Open()))
                    {
                        string json = r.ReadToEnd();
                        mapItem items;
                        try
                        {
                            items = JsonConvert.DeserializeObject<mapItem>(json);
                            InfJsonmapTitle = items.title;
                            if (InfJsonmapTitle == "" || InfJsonmapTitle == null) InfJsonmapTitle = Path.GetFileNameWithoutExtension(f);
                            previewImgName = items.previews;
                            if (items.previews[0] != "" || items.previews != null)
                            {
                                foreach (ZipArchiveEntry entry in zip.Entries)
                                {
                                    if (entry.Name == previewImgName[0])
                                    {
                                        Stream s = entry.Open();
                                        img = (Image)Image.FromStream(s);
                                    }
                                }
                            }
                        }
                        catch// if it throws exception it means it cant parse the json
                        { if (secondImg != null) { img = secondImg; } }
                        if (modInfJsonEntry != null)
                        {
                            try
                            {
                                using (StreamReader r2 = new StreamReader(modInfJsonEntry.Open()))
                                {
                                    json = r2.ReadToEnd();
                                    mapItem items2;
                                    items2 = JsonConvert.DeserializeObject<mapItem>(json);
                                    modInfJsonmapTitle = items2.title;
                                    if (modInfJsonmapTitle == "" || modInfJsonmapTitle == null)
                                    { finalMapTitle = Path.GetFileNameWithoutExtension(f); }
                                    else
                                    { finalMapTitle = modInfJsonmapTitle; }
                                }
                            }
                            catch
                            { finalMapTitle = Path.GetFileNameWithoutExtension(f); }
                        }
                        else
                        { finalMapTitle = Path.GetFileNameWithoutExtension(f); }
                    }
                    // }
                    //  catch
                    // {
                    //MessageBox.Show("coc");
                    //  }
                    ListViewItem listMapItem = new ListViewItem();
                    mainMapImgList.Images.Add(img);
                    listMapItem.ImageIndex = mainMapImgList.Images.Count - 1;
                    listMapItem.Tag = assembleFullMapPath(mapCodeName) + "*" + Path.GetFileName(f).Trim();
                    listMapItem.ToolTipText = Path.GetFileName(f);
                    string mapTitleEdited;
                    if (finalMapTitle.Contains('_') || finalMapTitle.Contains('.'))
                    { mapTitleEdited = finalMapTitle.Replace("_", " ").Replace(".", " "); }
                    else { mapTitleEdited = finalMapTitle; }
                    listMapItem.Text = mapTitleEdited;
                    mapsListView.Items.Add(listMapItem);
                    backupMapListview.Items.Add((ListViewItem)listMapItem.Clone());
                }
            }
        }
        private void configureMaps()
        {
            try
            {
                foreach (ListViewItem item in mapsListView.Items)
                {
                    if (item.Tag != null)
                    {
                        if (item.Tag.ToString().Contains(cfgMapFULLname.Trim()))
                        {
                            item.BackColor = Color.Green;
                            mapsListView.Items[item.Index].Selected = true;
                            mapsListView.Items[item.Index].EnsureVisible();
                            mapsListView.Select();
                        }
                    }
                }
            }
            catch { }

        }
        private void loadMods()
        {
            //clear stuff
            modListView.Clear();
            backupModListview.Clear();
            modsImgList.Images.Clear();
            int imgIndexCount = 0;
            List<string> filePaths = new List<string>();
            string[] filePathsCLIENTFold;
            string[] filePathsDEACTIVAEDFold;
            try
            {
                filePathsCLIENTFold = Directory.GetFiles(Application.StartupPath + @"\" + resFold + @"\Client\deactivated_mods", "*.zip", SearchOption.TopDirectoryOnly);
                filePathsDEACTIVAEDFold = Directory.GetFiles(Application.StartupPath + @"\" + resFold + @"\Client", "*.zip", SearchOption.TopDirectoryOnly);
            }
            catch (Exception) { appendLog(@"The ""deactivated_mods"" or ""Client"" folder could not be found. No mods loaded"); return; }
            filePaths.AddRange(filePathsCLIENTFold.OfType<string>().ToList());
            filePaths.AddRange(filePathsDEACTIVAEDFold.OfType<string>().ToList());
            foreach (string f in filePaths)
            {
                // string previewImgName = null;
                string modTitle = null;
                string modCodeName = null;
                bool modActivated = false;
                bool isMap = false;
                Image img = Properties.Resources.mod;
                using (ZipArchive zip = ZipFile.Open(f, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry vehiclesEntry = null;
                    ZipArchiveEntry mod_InfoJsonEntry = null;
                    foreach (ZipArchiveEntry entry in zip.Entries)
                    {
                        if (entry.FullName.Contains("levels/")) isMap = true;
                        if (entry.Name == "info.json")
                        { vehiclesEntry = entry; }
                        if (entry.Name == "icon.png" || entry.Name == "icon.jpg")
                        {
                            Stream s = entry.Open();
                            img = (Image)Image.FromStream(s);
                        }
                    }
                    if (isMap) continue;
                    ZipArchiveEntry finalEntry = null;
                    foreach (ZipArchiveEntry entry in zip.Entries)
                    {
                        if (vehiclesEntry == null)
                        {
                            if (entry.Name == "info.json" && entry.FullName.Contains(@"mod_info/"))
                            { mod_InfoJsonEntry = entry; }
                        }
                    }
                    if (vehiclesEntry != null)
                    { finalEntry = vehiclesEntry; }
                    else if (mod_InfoJsonEntry != null) { finalEntry = mod_InfoJsonEntry; }
                    else { modTitle = Path.GetFileNameWithoutExtension(f); }
                    modsImgList.Images.Add(img);
                    modCodeName = Path.GetFileName(f);
                    if (finalEntry != null)
                    {
                        try
                        {
                            using (StreamReader r = new StreamReader(finalEntry.Open()))
                            {
                                string json = r.ReadToEnd();
                                var items = JsonConvert.DeserializeObject<ModItem>(json);
                                // dynamic array = JsonConvert.DeserializeObject(json);
                                modTitle = items.title;
                                if (modTitle == "" || modTitle == null) modTitle = Path.GetFileNameWithoutExtension(f);
                                // foreach (var item in array)
                                //   {
                                //  }
                            }
                        }
                        catch
                        {
                            modTitle = Path.GetFileNameWithoutExtension(f);
                        }
                    }
                    if (f.Contains(@"\deactivated_mods"))
                    { modActivated = false; }
                    else { modActivated = true; }
                    //add to list
                    ListViewItem listItem = new ListViewItem();
                    listItem.Tag = modCodeName;
                    listItem.Name = modCodeName + "_listItem";
                    listItem.Text = modTitle;
                    listItem.ImageIndex = imgIndexCount;
                    if (modActivated)
                    { listItem.ToolTipText = "Activated, " + modCodeName; listItem.ForeColor = SystemColors.WindowText; }
                    else
                    { listItem.ToolTipText = "Deactivated, " + modCodeName; listItem.ForeColor = Color.Red; }
                    modListView.Items.Add(listItem);
                    backupModListview.Items.Add((ListViewItem)listItem.Clone());
                }
                imgIndexCount += 1;
            }
        }

        public class ModItem
        {
            public string title;
        }
        public class mapItem
        {
            public string title { get; set; }
            public string[] previews { get; set; }
        }
        private void loadPlugins()
        {
            //clear stuff
            pluginlistView.Clear();
            backupPluginListview.Clear();
            //  pluginImgList.Images.Clear();

            List<string> DirPaths = new List<string>();
            string[] DirPathsCLIENTFold;
            string[] DirPathsDEACTIVAEDFold;
            try
            {
                DirPathsCLIENTFold = Directory.GetDirectories(Application.StartupPath + @"\" + resFold + @"\Server\deactivated_plugins", "*", SearchOption.TopDirectoryOnly);
                DirPathsDEACTIVAEDFold = Directory.GetDirectories(Application.StartupPath + @"\" + resFold + @"\Server", "*", SearchOption.TopDirectoryOnly);
            }
            catch (Exception) { appendLog(@"The ""deactivated_plugins"" or ""Server"" folder could not be found. No plugins loaded"); return; }
            DirPaths.AddRange(DirPathsCLIENTFold.OfType<string>().ToList());
            DirPaths.AddRange(DirPathsDEACTIVAEDFold.OfType<string>().ToList());
            foreach (string foldPath in DirPaths)
            {
                if (foldPath.Substring(Math.Max(0, foldPath.Length - 21)).Contains(@"\deactivated_plugins")) continue;
                // string previewImgName = null;
                string pluginTitle = null;
                string pluginCodeName = null;
                bool pluginActivated;
                if (foldPath.Contains(@"\deactivated_plugins"))
                { pluginActivated = false; }
                else { pluginActivated = true; }
                pluginTitle = Path.GetFileName(foldPath);
                pluginCodeName = Path.GetFileName(foldPath);
                //add to list
                ListViewItem listItem = new ListViewItem();
                listItem.Tag = pluginCodeName;
                listItem.Name = pluginCodeName.Replace(" ", "_") + "_listItem";
                listItem.Text = pluginTitle;
                listItem.ImageIndex = 0;
                if (pluginActivated)
                { listItem.ToolTipText = "Activated"; listItem.ForeColor = SystemColors.WindowText; }
                else
                { listItem.ToolTipText = "Deactivated"; listItem.ForeColor = Color.Red; }
                pluginlistView.Items.Add(listItem);
                backupPluginListview.Items.Add((ListViewItem)listItem.Clone());
            }
        }
        private string getComment(string line)
        {
            return " #" + line.Substring(line.LastIndexOf('#') + 1);
        }//unused
        private void loadCfg()
        {
            if (System.IO.File.Exists(Application.StartupPath + cfgFilePath))
            {
                saveBtn.Enabled = true;
                using (StreamReader reader = new StreamReader(File.OpenRead(Application.StartupPath + cfgFilePath)))
                {
                    // Parse the table
                    TomlTable table = TOML.Parse(reader);
                    authTxtBox.Text = table["General"]["AuthKey"];
                    debugChckBox.Checked = table["General"]["Debug"];
                    descTxtBox.Text = table["General"]["Description"];
                    cfgMapFULLname = table["General"]["Map"];
                    maxCarsCombo.Text = table["General"]["MaxCars"];
                    maxPlayerCombo.Text = table["General"]["MaxPlayers"];
                    nameTxtBox.Text = table["General"]["Name"];
                    portTxtBox.Text = table["General"]["Port"];
                    privChckBox.Checked = table["General"]["Private"];
                    selectResLocBtn.Tag = table["General"]["ResourceFolder"];
                    resFold = table["General"]["ResourceFolder"];
                }
            }
            else
            {
                MessageBox.Show(@"The file ""ServerConfig.toml"" which contains the settings was not found! Please run the server at least once to generate the file and then click the reload button at top-left to reload the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveBtn.Enabled = false;
            }
        }

        private void portTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            { e.Handled = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadMaps();
            loadCfg();
            configureMaps();
            loadMods();
            loadPlugins();
        }
        string cfgMapFULLname;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (mapsListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a map!", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string mapItemTag = mapsListView.SelectedItems[0].Tag.ToString();
            string mapZipName;
            string mapName;
            if (mapItemTag.Contains(@"info.json*"))
            {
                mapName = mapItemTag.Substring(0, mapItemTag.IndexOf('*')).Trim();
                mapZipName = mapItemTag.Substring(mapItemTag.IndexOf('*') + 1, mapItemTag.Length - mapItemTag.IndexOf('*') - 1).Trim();
            }
            else
            {
                mapName = mapItemTag;
                mapZipName = "";
            }
            try
            {
                TomlNode node;
                if (File.Exists(Application.StartupPath + cfgFilePath))
                {
                    using (var sr = File.OpenText(Application.StartupPath + cfgFilePath))
                        node = TOML.Parse(sr);
                }
                else
                { MessageBox.Show("ServerConfig.toml file could not be found! ", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Error); appendLog("ERROR:  Could not find Could not find ServerConfig.toml!"); return; }
                node["General"]["AuthKey"] = authTxtBox.Text;
                node["General"]["Debug"] = debugChckBox.Checked;
                node["General"]["Description"] = descTxtBox.Text;
                makeFolders();
                //save map
                string[] clientFiles;
                try
                { clientFiles = Directory.GetFiles(Application.StartupPath + @"\" + resFold + @"\Client", "*.zip"); }
                catch { appendLog(@"ERROR: Couldn't find ""Clients"" folder"); MessageBox.Show(@"The ""Clients"" folder could not be found"); return; }
                List<string> files2Move = new List<string>();
                foreach (string f in clientFiles)
                {
                    if (Path.GetFileName(f) == mapZipName)
                    { continue; }
                    using (ZipArchive zip = ZipFile.Open(f, ZipArchiveMode.Read))
                    {
                        foreach (ZipArchiveEntry entry in zip.Entries)
                        {
                            if (entry.Name == "info.json" && entry.FullName.Contains(@"levels/"))
                            {
                                files2Move.Add(f);
                                break;
                            }
                        }
                    }
                }
                //move other maps back to custom_maps folder
                foreach (string f in files2Move.ToArray())
                {
                    if (File.Exists(Application.StartupPath + @"\custom_maps\" + Path.GetFileName(f)))
                    { File.Delete(Application.StartupPath + @"\" + resFold + @"\Client\" + Path.GetFileName(f)); }
                    else
                    { File.Move(Application.StartupPath + @"\" + resFold + @"\Client\" + Path.GetFileName(f), Application.StartupPath + @"\custom_maps\" + Path.GetFileName(f)); }
                }
                //   try
                //    {
                if (mapZipName != "")
                {
                    if (!File.Exists(Application.StartupPath + @"\" + resFold + @"\Client\" + mapZipName))
                    { File.Move(Application.StartupPath + @"\custom_maps\" + mapZipName, Application.StartupPath + @"\" + resFold + @"\Client\" + mapZipName); }
                }
                //  }
                //   catch { }
                //
                node["General"]["Map"] = mapName;
                node["General"]["MaxCars"] = int.Parse(maxCarsCombo.Text);
                node["General"]["MaxPlayers"] = int.Parse(maxPlayerCombo.Text);
                node["General"]["Name"] = nameTxtBox.Text;
                node["General"]["Port"] = int.Parse(portTxtBox.Text);
                node["General"]["Private"] = privChckBox.Checked;
                using (var sw = File.CreateText(Application.StartupPath + cfgFilePath))
                { node.WriteTo(sw); }
                appendLog("Saved server settings");
                MessageBox.Show("Saved! If your server is running, please restart it so that the changes take effect", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the settings!" + Environment.NewLine + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appendLog("ERROR:  Could not save the settings!" + Environment.NewLine + ex.ToString());
            }
            reloadCfgBtn.PerformClick();
        }

        private void appendLog(string text)
        {
            log.Append(text);
            InvokeIfRequired(logForm.textBox1, () => { logForm.textBox1.AppendText(DateTime.Now.ToString("hh:mm tt") + ">>> " + text + Environment.NewLine); });
        }

        infoHelpFrm helpForm = new infoHelpFrm();
        private void button1_Click(object sender, EventArgs e)
        {
            helpForm.ShowDialog();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://beammp.com/k/keys");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(Application.StartupPath + @"\" + resFold + @"\Client"))
            { System.Diagnostics.Process.Start(Application.StartupPath + @"\" + resFold + @"\Client"); }
            else { appendLog(@"ERROR: Failed to open ""Client"" folder "); MessageBox.Show("The mod folder could not be found! Run the server at least once to prepare the files and folders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void checkIfSrvIsRunning()
        {
            Task t = Task.Run(() =>
            {
                bool serverRunning = false;
                while (true)
                {

                    if (Process.GetProcessesByName("BeamMP-Server").Length == 0)
                    {
                        //not found
                        InvokeIfRequired(startBtn, () =>
                    {
                        startBtn.Text = "Start";
                        startBtn.ForeColor = SystemColors.ControlText;
                    });
                        InvokeIfRequired(restartBtn, () => { restartBtn.Enabled = false; });
                        if (serverRunning)
                        {
                            appendLog("Server stopped");
                            serverRunning = false;
                        }
                    }
                    else
                    {
                        //found
                        beamMPServer = Process.GetProcessesByName("BeamMP-Server")[0];
                        InvokeIfRequired(startBtn, () =>
                        {
                            startBtn.Text = "Stop";
                            startBtn.ForeColor = Color.Red;
                        });
                        InvokeIfRequired(restartBtn, () => { restartBtn.Enabled = true; });
                        serverRunning = true;
                    }
                    System.Threading.Thread.Sleep(3000);
                }
            });
        }
        Process beamMPServer;
        private void startServer()
        {
            try
            {
                beamMPServer = new Process();
                beamMPServer.StartInfo.FileName = srvStartFile;
                beamMPServer.StartInfo.WorkingDirectory = Application.StartupPath;
                beamMPServer.Start();
                appendLog("Server started");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not start server! Make sure the server executable is not missing!", "Start Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appendLog("ERROR: Failed to start the server!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (startBtn.Text == "Start")
            {
                startServer();
                startBtn.Text = "Stop";
                startBtn.ForeColor = Color.Red;
                restartBtn.Enabled = true;

            }
            else if (startBtn.Text == "Stop")
            {
                try
                {
                    beamMPServer.Kill();
                    startBtn.Text = "Start";
                    startBtn.ForeColor = SystemColors.ControlText;
                    restartBtn.Enabled = false;
                    appendLog("Server stopped");
                }
                catch { MessageBox.Show("Failed to stop the server!"); appendLog("ERROR: Failed to stop the server!"); }
            }
        }
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectCustomStartFile.InitialDirectory = Application.StartupPath;
            if (selectCustomStartFile.ShowDialog() == DialogResult.OK)
            {
                srvStartFile = selectCustomStartFile.FileName;
                Properties.Settings.Default.srvStartFile = srvStartFile;
                selectToolStripMenuItem.ToolTipText = Path.GetFileName(srvStartFile);
                Properties.Settings.Default.Save();
            }
        }

        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            srvStartFile = Application.StartupPath + @"\BeamMP-Server.exe";
            Properties.Settings.Default.srvStartFile = "";
            selectToolStripMenuItem.ToolTipText = "Default";
            Properties.Settings.Default.Save();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            try
            { beamMPServer.Kill(); }
            catch (Exception ex) { MessageBox.Show("Failed to stop the server!"); appendLog("ERROR: Failed to restart the server" + Environment.NewLine + ex.ToString()); return; }
            while (!beamMPServer.HasExited)
            { System.Threading.Thread.Sleep(50); }
            System.Threading.Thread.Sleep(1000);
            startServer();
            appendLog("Server successfully restarted");
        }

        private bool beamMPProcRunning()
        {
            try
            {
                if (beamMPServer.HasExited)
                { return false; }
                else { return true; }
            }
            catch { return false; }
        }
        private void checkRestartCfgTimer()
        {
            bool readErrorShown = false;
            Task t = Task.Run(() =>
            {
                while (true)
                {
                    string oldCfgFile = "";
                    while (Properties.Settings.Default.checkRestartCfgTimer && beamMPServer != null)
                    {
                        if (beamMPProcRunning())
                        {
                            if (System.IO.File.Exists(Application.StartupPath + cfgFilePath))
                            {
                                try
                                { oldCfgFile = File.ReadAllText(Application.StartupPath + cfgFilePath); }
                                catch (IOException)
                                {
                                    if (!readErrorShown)
                                    {
                                        appendLog("Couldn't read the configuration file. Auto restart disabled");
                                        MessageBox.Show("Couldn't read the configuration file. Make sure its not being used by another process", "Config update check and restart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        readErrorShown = true;
                                    }
                                    System.Threading.Thread.Sleep(100);
                                    continue;
                                }
                                System.Threading.Thread.Sleep(Convert.ToInt32(TimeSpan.FromSeconds(Properties.Settings.Default.checkRestartCfgTimerSeconds).TotalMilliseconds));
                                if (Properties.Settings.Default.checkRestartCfgTimer && beamMPProcRunning())
                                {
                                    try
                                    {
                                        if (oldCfgFile != File.ReadAllText(Application.StartupPath + cfgFilePath))
                                        {
                                            appendLog("A change in the config file has been detected");
                                            InvokeIfRequired(restartBtn, () => { restartBtn.PerformClick(); });
                                            readErrorShown = false;
                                        }
                                    }
                                    catch (IOException)
                                    {
                                        if (!readErrorShown)
                                        {
                                            appendLog("Couldn't read the configuration file. Auto restart disabled");
                                            MessageBox.Show("Couldn't read the configuration file. Make sure its not being used by another process", "Config update check and restart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            readErrorShown = true;
                                        }
                                        System.Threading.Thread.Sleep(100);
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                if (!readErrorShown)
                                {
                                    appendLog("Couldn't find the configuration file. Auto restart disabled");
                                    MessageBox.Show("Couldn't find the configuration file. Make sure its not being used by another process", "Config update check and restart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    readErrorShown = true;
                                }
                                System.Threading.Thread.Sleep(100);
                                continue;
                            }
                        }
                        else { break; }
                    }
                    System.Threading.Thread.Sleep(100);
                }
            });
        }
        private void restartTimer()
        {
            Task t = Task.Run(() =>
            {
                while (true)
                {
                    while (Properties.Settings.Default.restartTimer && beamMPServer != null)
                    {
                        if (beamMPProcRunning())
                        {
                            System.Threading.Thread.Sleep(Convert.ToInt32(TimeSpan.FromHours(Properties.Settings.Default.restartTimerHours).TotalMilliseconds));
                            if (Properties.Settings.Default.restartTimer && beamMPProcRunning())
                            {
                                appendLog("Auto server restart");
                                InvokeIfRequired(restartBtn, () => { restartBtn.PerformClick(); });
                            }
                        }
                        else { break; }
                    }
                    System.Threading.Thread.Sleep(100);
                }
            });
        }
        private void autoRestartTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new restartTimerForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Properties.Settings.Default.restartTimerHours = form.restartTimerHours;
                    Properties.Settings.Default.restartTimer = form.checkBox1.Checked;
                    Properties.Settings.Default.checkRestartCfgTimerSeconds = form.restartCfgTimerSecs;
                    Properties.Settings.Default.checkRestartCfgTimer = form.checkBox2.Checked;
                    Properties.Settings.Default.checkModPluginChanges = form.modPluginChangesChckBox.Checked;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)//unused
        {
            FolderBrowserDialog foldDialog = new FolderBrowserDialog();
            foldDialog.SelectedPath = Application.StartupPath;
            if (foldDialog.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Directory.Exists(foldDialog.SelectedPath))
                {
                    selectResLocBtn.Tag = foldDialog.SelectedPath;
                    toolTip1.SetToolTip(selectResLocBtn, foldDialog.SelectedPath);
                }
                else
                { MessageBox.Show("The selected path could not be found", "Resource folder location", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            { Process.Start(Application.StartupPath + @"\" + resFold + @"\Server"); }
            catch { appendLog(@"ERROR: Failed to open ""Server"" folder "); MessageBox.Show("The plugins folder could not be found! Run the server at least once to prepare the files and folders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(@"To find the currently selected map, go to the ""Client"" folder which is inside the ""Resources"" folder and there you will find the .zip file", "Open Mods folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            { Process.Start(Application.StartupPath + @"\custom_maps"); }
            catch { appendLog(@"ERROR: Failed to open ""custom_maps"" folder "); MessageBox.Show("The custom maps folder could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void modListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modListView.SelectedItems.Count == 0)
            { activateModBtn.Enabled = false; return; }
            activateModBtn.Enabled = true;
            if (modListView.SelectedItems[0].ForeColor == Color.Red)
            { activateModBtn.Text = "Activate"; }
            else if (modListView.SelectedItems[0].ForeColor == SystemColors.WindowText)
            { activateModBtn.Text = "Deactivate"; }
        }
        private void activateModOrPlugin(bool activate, string deactivatedFold, string activatedFold, string type)
        {
            string foldToMove;
            string source;
            if (activate == true)
            {
                foldToMove = activatedFold;
                source = deactivatedFold;
            }
            else
            {
                foldToMove = deactivatedFold;
                source = activatedFold;
            }
            ListViewItem item;
            if (type == "mod")
            {
                item = modListView.SelectedItems[0];
                if (File.Exists(foldToMove + item.Tag.ToString()))
                {
                    if (MessageBox.Show("A duplicate of this " + type + " has been found. You have to delete one of the copies in order to continue. Do you want to delete one of the copies?", "Activate Mod", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            File.Delete(activatedFold + item.Tag.ToString());
                            if (activate == false)
                            { return; }
                        }
                        catch (Exception ex) { appendLog("ERROR: Failed to delete the file!" + Environment.NewLine + ex.ToString()); }
                    }
                    else { return; }
                }
                try
                { File.Move(source + item.Tag.ToString(), foldToMove + item.Tag.ToString()); }
                catch (Exception ex) { appendLog("ERROR: Failed to move the " + type + Environment.NewLine + ex.ToString()); MessageBox.Show("The selected " + type + @" could not be activated/deactivated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (type == "plugin")
            {
                item = pluginlistView.SelectedItems[0];
                if (Directory.Exists(foldToMove + item.Tag.ToString()))
                {
                    if (MessageBox.Show("A duplicate of this " + type + " has been found. You have to delete one of the copies in order to continue. Do you want to delete one of the copies?", "Activate Mod", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.Delete(activatedFold + item.Tag.ToString(), true);
                            if (activate == false)
                            { return; }
                        }
                        catch (Exception ex) { appendLog("ERROR: Failed to delete the folder" + Environment.NewLine + ex.ToString()); }
                    }
                    else { return; }
                }
                try
                { Directory.Move(source + item.Tag.ToString(), foldToMove + item.Tag.ToString()); }
                catch (Exception ex) { appendLog("ERROR: Failed to move the folder" + Environment.NewLine + ex.ToString()); MessageBox.Show("The selected " + type + @" could not be activated/deactivated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void activateModBtn_Click(object sender, EventArgs e)
        {
            string deactivatedModsFold = Application.StartupPath + @"\" + resFold + @"\Client\deactivated_mods\";
            string activatedModsFold = Application.StartupPath + @"\" + resFold + @"\Client\";
            if (activateModBtn.Text == "Activate")
            { activateModOrPlugin(true, deactivatedModsFold, activatedModsFold, "mod"); activateModBtn.Text = "Deactivate"; }
            else if (activateModBtn.Text == "Deactivate")
            { activateModOrPlugin(false, deactivatedModsFold, activatedModsFold, "mod"); activateModBtn.Text = "Activate"; }
            loadMods();
            activateModBtn.Enabled = false;
        }

        private void activatePluginsBtn_Click(object sender, EventArgs e)
        {
            string deactivatedPluginsFold = Application.StartupPath + @"\" + resFold + @"\Server\deactivated_plugins\";
            string activatedPluginsFold = Application.StartupPath + @"\" + resFold + @"\Server\";
            if (activatePluginsBtn.Text == "Activate")
            { activateModOrPlugin(true, deactivatedPluginsFold, activatedPluginsFold, "plugin"); activatePluginsBtn.Text = "Deactivate"; }
            else if (activatePluginsBtn.Text == "Deactivate")
            { activateModOrPlugin(false, deactivatedPluginsFold, activatedPluginsFold, "plugin"); activatePluginsBtn.Text = "Activate"; }
            loadPlugins();
            activatePluginsBtn.Enabled = false;
        }

        private void pluginlistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pluginlistView.SelectedItems.Count == 0)
            { activatePluginsBtn.Enabled = false; return; }
            activatePluginsBtn.Enabled = true;
            if (pluginlistView.SelectedItems[0].ForeColor == Color.Red)
            { activatePluginsBtn.Text = "Activate"; }
            else if (pluginlistView.SelectedItems[0].ForeColor == SystemColors.WindowText)
            { activatePluginsBtn.Text = "Deactivate"; }
        }

        searchFrm searchForm = new searchFrm();
        int[] searchFrmLoc;
        ListView listview;
        ListView backupListview;
        ListView backupMapListview = new ListView();
        ListView backupModListview = new ListView();
        ListView backupPluginListview = new ListView();

        private void showSearchFrm(int[] loc, string title)
        {
            searchFrmLoc = loc;
            searchForm.Show();
            searchForm.Text = title;
            searchForm.Location = new Point(this.Location.X + searchFrmLoc[0], this.Location.Y + searchFrmLoc[1]);
            searchForm.textBox1.TextChanged += new System.EventHandler(this.searchForm_textBox1_TextChanged);
            searchForm.BringToFront();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            showSearchFrm(new int[] { 843, 55 }, "Search - Mods");
            listview = modListView;
            backupListview = backupModListview;
        }
        private void searchPluginsBtn_Click(object sender, EventArgs e)
        {
            showSearchFrm(new int[] { 843, 305 }, "Search - Plugins");
            listview = pluginlistView;
            backupListview = backupPluginListview;

        }

        private void searchMapsBtn_Click(object sender, EventArgs e)
        {
            showSearchFrm(new int[] { 843, 225 }, "Search - Maps");
            listview = mapsListView;
            backupListview = backupMapListview;

        }
        private void searchForm_textBox1_TextChanged(object sender, EventArgs e)
        {
            listview.Items.Clear();
            foreach (ListViewItem item in backupListview.Items)
            { listview.Items.Add((ListViewItem)item.Clone()); ; }
            if (searchForm.textBox1.Text.Trim() == "") return;
            foreach (ListViewItem item in listview.Items)
            {
                if (!item.Text.ToLower().Contains(searchForm.textBox1.Text.ToLower().Trim()))
                { item.Remove(); }
            }
        }
        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            if (searchForm.Visible == true)
            { searchForm.Location = new Point(this.Location.X + searchFrmLoc[0], this.Location.Y + searchFrmLoc[1]); }
            searchForm.BringToFront();
        }

    }
}

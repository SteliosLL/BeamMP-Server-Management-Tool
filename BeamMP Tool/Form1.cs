using NetFwTypeLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Tommy;
using Transitions;


namespace BeamMP_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void showMenuStripAtBtn(ContextMenuStrip menuStrip, Button btn)
        {
            //menuStrip.Visible = true;
            menuStrip.Show(btn, new Point(btn.Width - btn.Width, btn.Height));
        }
        public void InvokeIfRequired(Control control, MethodInvoker action)
        {
            try
            {
                if (control.InvokeRequired)
                { control.Invoke(action); }
                else
                { action(); }
            }
            catch { }

        }
        public Thread StartThread(Action action)
        {
            Thread thread = new Thread(() => { action(); });
            thread.Start();
            return thread;
        }
        public logFrm logForm = new logFrm();
        public static Color colorNormal = Color.FromArgb(49, 71, 104);
        public static string cfgFilePath = @"\ServerConfig.toml";
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

        private void Form1_Load(object sender, EventArgs e)
        {
            setControls();
            loadCfg();
            if (!Directory.Exists(resFold))
            { resFold = "Resources"; }
            makeFolders();
            loadMaps();
            configureMaps();
            loadMods();
            loadPlugins();
            showSrvCtrlPnlFrm();
            if (Properties.Settings.Default.srvStartFile == "")
            { srvCtrlPnlFrm.srvStartFile = "BeamMP-Server.exe"; selectToolStripMenuItem.ToolTipText = "Default"; selectedSrvStartFileLblBtn.Text = "Selected: Default"; }
            else
            { srvCtrlPnlFrm.srvStartFile = Properties.Settings.Default.srvStartFile; selectToolStripMenuItem.ToolTipText = Path.GetFileName(Properties.Settings.Default.srvStartFile); selectedSrvStartFileLblBtn.Text = "Selected: " + Path.GetFileName(Properties.Settings.Default.srvStartFile); }
            //  checkRestartCfgTimer();
            // restartTimer();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            bool dontshowAgain = Properties.Settings.Default.dontshowMsgFIRSTSTARTUPNOTE;
            Properties.Settings.Default.dontshowMsgFIRSTSTARTUPNOTE = dontshowAgain;
            Properties.Settings.Default.Save();
        }
        private void setControls()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right / 2 - Size.Width / 2, workingArea.Bottom / 2 - Size.Height / 2);
            logForm.Show();
            logForm.ShowInTaskbar = true;
            logForm.Location = new Point(this.Location.X + this.Width + 15, logForm.Location.Y);

            int i = 0;
            while (i < 100)
            {
                i += 1;
                maxPlayerCombo.Items.Add(i);
                maxCarsCombo.Items.Add(i);
            }
        }

        //UNUSED
        private string assembleFullMapPath(string mapName)
        {
            Debug.WriteLine(mapName);
            return @"/levels/" + mapName + @"/info.json";
        }

        private void loadMaps()
        {
            mapsListView.Clear();
            backupMapListview.Clear();
            mainMapImgList.Images.Clear();
            foreach (Image img in defMapsImgList.Images)
            { mainMapImgList.Images.Add(img); }
            //load default maps
            mapsListView.Items.Add("Gridmap v2", 1).Tag = @"/levels/gridmap_v2/info.json";
            mapsListView.Items.Add("Gridmap", 2).Tag = @"/levels/gridmap/info.json";
            mapsListView.Items.Add("Automation Test Track", 3).Tag = @"/levels/automation_test_track/info.json";
            mapsListView.Items.Add("East Coast USA", 4).Tag = @"/levels/east_coast_usa/info.json";
            mapsListView.Items.Add("Hirochi Raceway", 5).Tag = @"/levels/hirochi_raceway/info.json";
            mapsListView.Items.Add("Italy", 6).Tag = @"/levels/italy/info.json";
            mapsListView.Items.Add("Industrial", 7).Tag = @"/levels/industrial/info.json";
            mapsListView.Items.Add("Small Island", 8).Tag = @"/levels/small_island/info.json";
            mapsListView.Items.Add("Small Grid", 9).Tag = @"/levels/smallgrid/info.json";
            mapsListView.Items.Add("Utah", 10).Tag = @"/levels/utah/info.json";
            mapsListView.Items.Add("West Coast USA", 11).Tag = @"/levels/west_coast_usa/info.json";
            mapsListView.Items.Add("Driver Training", 12).Tag = @"/levels/driver_training/info.json";
            mapsListView.Items.Add("Derby", 13).Tag = @"/levels/derby/info.json";
            mapsListView.Items.Add("Jungle Rock Island", 14).Tag = @"/levels/jungle_rock_island/info.json";
            mapsListView.Items.Add("Johnson Valley", 15).Tag = @"/levels/johnson_valley/info.json";
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
                try
                {
                    using (ZipArchive zip = ZipFile.Open(f, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry jsonEntry = null;
                        ZipArchiveEntry modInfJsonEntry = null;
                        bool misFound = false;
                        foreach (ZipArchiveEntry entry in zip.Entries)
                        {
                            if (entry.Name == "info.json" && entry.FullName.Contains(@"levels/"))
                            {
                                if (!misFound)
                                {
                                    mapCodeName = "/" + entry.FullName;
                                }
                                jsonEntry = entry;
                            }

                            else if (Path.GetExtension(entry.Name) == ".mis" && entry.FullName.Contains(@"levels/"))
                            {
                                misFound = true;
                                mapCodeName = "/" + entry.FullName;
                            }//DO SOMETHIN HERE

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
                        listMapItem.Tag = mapCodeName + "%*%" + Path.GetFileName(f).Trim();
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
                catch (Exception a) { appendLog("ERROR:  Could not open the map's zip file! " + a.ToString()); }
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
                            //maps list view tag contains the filename of the current map .zip file
                            string tag = mapsListView.Items[item.Index].Tag.ToString();
                            if (tag.Contains(@"%*%"))
                            {
                                currentMapZipBtn.Enabled = true;
                                mapsListView.Tag = tag.Substring(tag.IndexOf("%*%") + 3, tag.Length - tag.IndexOf("%*%") - 3).Trim();
                            }
                            else currentMapZipBtn.Enabled = false;
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
                    listItem.ForeColor = SystemColors.Control;
                    listItem.ImageIndex = imgIndexCount;
                    if (modActivated)
                    { listItem.ToolTipText = "Activated, " + modCodeName; listItem.ForeColor = SystemColors.Control; }
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
            List<string> DirPathsSERVERFold;
            List<string> DirPathsDEACTIVAEDFold;
            try
            {
                DirPathsSERVERFold = Directory.GetDirectories(Application.StartupPath + @"\" + resFold + @"\Server").ToList();
                DirPathsDEACTIVAEDFold = Directory.GetDirectories(Application.StartupPath + @"\" + resFold + @"\Server\deactivated_plugins").ToList();
            }
            catch (Exception) { appendLog(@"The ""deactivated_plugins"" or ""Server"" folder could not be found. No plugins loaded"); return; }
            foreach (string path in DirPathsSERVERFold.ToList())
            {
                if (Directory.GetFiles(path, "*.lua").Length == 0 || new DirectoryInfo(path).Name == "deactivated_plugins")
                {
                    DirPathsSERVERFold.Remove(path);
                }
            }
            DirPaths.AddRange(DirPathsSERVERFold.OfType<string>().ToList());
            DirPaths.AddRange(DirPathsDEACTIVAEDFold.OfType<string>().ToList());
            foreach (string foldPath in DirPaths)
            {
                // string previewImgName = null;
                string pluginTitle = null;
                string pluginCodeName = null;
                bool pluginActivated;
                if (foldPath.Contains(@"\deactivated_plugins"))
                { pluginActivated = false; }
                else { pluginActivated = true; }
                pluginTitle = new DirectoryInfo(foldPath).Name;
                pluginCodeName = new DirectoryInfo(foldPath).Name;
                //add to list
                ListViewItem listItem = new ListViewItem();
                listItem.Tag = pluginCodeName;
                listItem.Name = pluginCodeName.Replace(" ", "_") + "_listItem";
                listItem.Text = pluginTitle;
                listItem.ForeColor = SystemColors.Control;
                listItem.ImageIndex = 0;
                if (pluginActivated)
                { listItem.ToolTipText = "Activated"; listItem.ForeColor = SystemColors.Control; }
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

        //original values
        string authKey = "";
        bool debug = false;
        string name = "";
        string desc = "";
        string cfgMapFULLname = "";
        int maxCars = 0;
        int maxPlayers = 0;
        int port = 0;
        bool pprivate = false;
        bool logChat = false;
        string resFold = "";
        string tags = "";
        //  string httpSrvIp = "";
        //  string httpSrvPort = "";
        // string sslCert = "";
        //  string sslKey = "";
        // bool useSSL = false;
        //bool enableHTTP = false;
        bool hideUpdt = false;
        bool onOffSendErrors = false;
        bool sendErrors = false;
        private void loadCfg()
        {
            if (System.IO.File.Exists(Application.StartupPath + cfgFilePath))
            {
                nameTxtBox.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular);
                nameTxtBox.ForeColor = Color.White;
                saveBtn.Enabled = true;
                cfgNotFound = false;
                using (StreamReader reader = new StreamReader(File.OpenRead(Application.StartupPath + cfgFilePath)))
                {
                    // Parse the table
                    TomlTable table = TOML.Parse(reader);
                    //General
                    try
                    {
                        authKey = table["General"]["AuthKey"];
                        debug = table["General"]["Debug"];
                        desc = table["General"]["Description"];
                        cfgMapFULLname = table["General"]["Map"];
                        maxCars = table["General"]["MaxCars"];
                        maxPlayers = table["General"]["MaxPlayers"];
                        name = table["General"]["Name"];
                        port = table["General"]["Port"];
                        pprivate = table["General"]["Private"];
                        logChat = table["General"]["LogChat"];
                        // selectResLocBtn.Tag = table["General"]["ResourceFolder"];
                        resFold = table["General"]["ResourceFolder"];
                        tags = table["General"]["Tags"];
                        //HTTP
                        // httpSrvIp = table["HTTP"]["HTTPServerIP"];
                        // httpSrvPort = table["HTTP"]["HTTPServerPort"];
                        // sslCert = table["HTTP"]["SSLCertPath"];
                        // sslKey = table["HTTP"]["SSLKeyPath"];
                        // useSSL = table["HTTP"]["UseSSL"];
                        // enableHTTP = table["HTTP"]["HTTPServerEnabled"];
                        //Misc
                        hideUpdt = table["Misc"]["ImScaredOfUpdates"];
                        onOffSendErrors = table["Misc"]["SendErrorsShowMessage"];
                        sendErrors = table["Misc"]["SendErrors"];
                    }
                    catch { msgBox.msgBoxShow(this, @"Some settings were not found in the config file! It may be damaged. Please run your server to repair the config file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    //set UI
                    authTxtBox.Text = authKey;
                    tagsTxtBox.Text = tags;
                    debugChckBox.Checked = debug;
                    descTxtBox.Text = desc;
                    maxCarsCombo.Text = maxCars.ToString();
                    maxPlayerCombo.Text = maxPlayers.ToString();
                    nameTxtBox.Text = name;
                    portTxtBox.Text = port.ToString();
                    privChckBox.Checked = pprivate;
                    logChatChckB.Checked = logChat;
                    // httpSrvIpTxtB.Text = httpSrvIp;
                    // httpSrvPortTxtB.Text = httpSrvPort.ToString();
                    // sslCertPicBox.Tag = sslCert;
                    // sslKeyPicBox.Tag = sslKey;
                    // sslCertSelected();
                    // sslKeySelected();
                    //useSSLChckB.Checked = useSSL;
                    //   enableHTTPSrvChckB.Checked = enableHTTP;
                    hideUpdtMsgChckB.Checked = hideUpdt;
                    onOffSendErrorsChckB.Checked = onOffSendErrors;
                    sendErrorsChckB.Checked = sendErrors;
                }

                nameTxtBox.Tag = name;
                descTxtBox.Tag = desc;
                BeamMPtoRTF_conv(name, nameTxtBox);
                BeamMPtoRTF_conv(desc, descTxtBox);
            }
            else
            {
                this.Focus();
                msgBox.msgBoxShow(this, @"The file ""ServerConfig.toml"" which contains the settings was not found! Please run the server at least once to generate the file and then click the reload button at the top-left to reload the file." + Environment.NewLine + Environment.NewLine + "Also make sure both the Management tool and the BeamMP Server executable are in the SAME folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!cfgNotFound) smoothBlinkBtnForeColor(reloadCfgBtn);
                cfgNotFound = true;
                saveBtn.Enabled = false;
            }
        }
        bool cfgNotFound = false;
        private void smoothBlinkBtnForeColor(Button btn)
        {
            btn.FlatAppearance.BorderSize = 1;
            StartThread(() =>
            {
                while (cfgNotFound && this.Visible)//if the form is not visible stop the loop so that the tool can fully exit
                {
                    InvokeIfRequired(btn, () => Transition.run(btn, "ForeColor", Color.Red, new TransitionType_Linear(300)));
                    Thread.Sleep(600);
                    InvokeIfRequired(btn, () => Transition.run(btn, "ForeColor", Color.LawnGreen, new TransitionType_Linear(300)));
                    Thread.Sleep(600);
                }
                InvokeIfRequired(btn, () => { btn.ForeColor = Color.LawnGreen; btn.FlatAppearance.BorderSize = 0; });
            });

        }
        public void setSelectionFormatting(string style, RichTextBox RTxtBox, string forceStyle = "")
        {
            var selectionStart = RTxtBox.SelectionStart;
            var selectionLength = RTxtBox.SelectionLength;
            var selectionBold = RTxtBox.SelectionFont.Bold;
            var selectionItalic = RTxtBox.SelectionFont.Italic;
            var selectionUnder = RTxtBox.SelectionFont.Underline;
            var selectionStrike = RTxtBox.SelectionFont.Strikeout;

            var sectionStartStyle = RTxtBox.SelectionFont.Style;
            List<int> sectionStartIndexes = new List<int>();

            sectionStartIndexes.Add(selectionStart);
            RTxtBox.SelectionLength = 1;

            // Check the style at each character and remember where it changes.
            for (var offset = 1; offset <= selectionLength - 1; offset += 1)
            {
                var currentIndex = selectionStart + offset;
                RTxtBox.SelectionStart = currentIndex;
                var currentStyle = RTxtBox.SelectionFont.Style;
                if (currentStyle != sectionStartStyle)
                {
                    // A new section of text style starts here.
                    sectionStartStyle = currentStyle;
                    sectionStartIndexes.Add(currentIndex);
                }
            }

            var upperBound = sectionStartIndexes.Count - 1;
            var remainingSelectionLength = selectionLength;

            for (var i = 0; i <= upperBound; i++)
            {
                var sectionStartIndex = sectionStartIndexes[i];
                // Select the next section.
                RTxtBox.SelectionStart = sectionStartIndex;

                if (i == upperBound)
                    RTxtBox.SelectionLength = remainingSelectionLength;
                else
                {
                    var sectionLength = sectionStartIndexes[i + 1] - sectionStartIndex;

                    RTxtBox.SelectionLength = sectionLength;
                    remainingSelectionLength -= RTxtBox.SelectionLength;
                }
                if (style == "bold")
                {
                    if (selectionBold)
                    {
                        RTxtBox.SelectionFont = new Font(RTxtBox.SelectionFont, RTxtBox.SelectionFont.Style & ~FontStyle.Bold);
                    }
                    else
                    {
                        RTxtBox.SelectionFont = new Font(RTxtBox.SelectionFont, RTxtBox.SelectionFont.Style | FontStyle.Bold);
                    }

                }
                if (style == "underline")
                {
                    if (selectionUnder)
                    {
                        RTxtBox.SelectionFont = new Font(RTxtBox.SelectionFont, RTxtBox.SelectionFont.Style & ~FontStyle.Underline);
                    }
                    else
                    {
                        RTxtBox.SelectionFont = new Font(RTxtBox.SelectionFont, RTxtBox.SelectionFont.Style | FontStyle.Underline);
                    }

                }
                if (style == "strike")
                {
                    if (selectionStrike)
                    {
                        RTxtBox.SelectionFont = new Font(RTxtBox.SelectionFont, RTxtBox.SelectionFont.Style & ~FontStyle.Strikeout);
                    }
                    else
                    {
                        RTxtBox.SelectionFont = new Font(RTxtBox.SelectionFont, RTxtBox.SelectionFont.Style | FontStyle.Strikeout);
                    }
                }
                if (style == "italic")
                {
                    if (selectionItalic)
                    {

                        RTxtBox.SelectionFont = new Font(RTxtBox.SelectionFont, RTxtBox.SelectionFont.Style & ~FontStyle.Italic);
                    }
                    else
                    {

                        RTxtBox.SelectionFont = new Font(RTxtBox.SelectionFont, RTxtBox.SelectionFont.Style | FontStyle.Italic);
                    }
                }
            }

            RTxtBox.SelectionStart = selectionStart;
            RTxtBox.SelectionLength = selectionLength;

        }
        public void BeamMPtoRTF_conv(string input, RichTextBox output)
        {
            output.Clear();
            output.Text = input.Trim();
            //find and read each formatting code, then apply the style in RTF accordingly
            List<FontStyle> activeStyles = new List<FontStyle>();
            while (output.Text.Contains('^'))
            {
                int searchStartIndx = output.Text.IndexOf('^');
                string code;
                try
                {
                    code = output.Text.Substring(searchStartIndx, 2);
                }
                catch
                { break; }
                int removeExtra = 0;//unused
                                    // if (output.Text[searchStartIndx + 2] == ' ' & output.Text[searchStartIndx + 3] != '^') removeExtra = 1;//check if there is a whitespace after the code and remove it

                //select formatting word. Then remove it
                output.SelectionStart = searchStartIndx;
                output.SelectionLength = code.Length;
                output.SelectedText = "";
                //select the rest of the text where we want the RTF formatting to be applied
                output.SelectionStart = searchStartIndx;
                output.SelectionLength = output.Text.Length - searchStartIndx;
                switch (code)
                {
                    case "^l":
                        output.SelectionFont = new Font(output.SelectionFont, output.SelectionFont.Style | FontStyle.Bold);
                        break;
                    case "^n":
                        output.SelectionFont = new Font(output.SelectionFont, output.SelectionFont.Style | FontStyle.Underline);
                        break;
                    case "^o":
                        output.SelectionFont = new Font(output.SelectionFont, output.SelectionFont.Style | FontStyle.Italic);
                        break;
                    case "^m":
                        output.SelectionFont = new Font(output.SelectionFont, output.SelectionFont.Style | FontStyle.Strikeout);
                        break;
                    case "^r":
                        output.SelectionFont = new Font(output.SelectionFont, FontStyle.Regular);
                        activeStyles.Clear();
                        break;
                    //colors
                    case "^0":
                        output.SelectionColor = Color.Black;
                        break;
                    case "^1":
                        output.SelectionColor = Color.Blue;
                        break;
                    case "^2":
                        output.SelectionColor = Color.Green;
                        break;
                    case "^3":
                        output.SelectionColor = Color.LightBlue;
                        break;
                    case "^4":
                        output.SelectionColor = Color.Red;
                        break;
                    case "^5":
                        output.SelectionColor = Color.Pink;
                        break;
                    case "^6":
                        output.SelectionColor = Color.Orange;
                        break;
                    case "^7":
                        output.SelectionColor = Color.Gray;
                        break;
                    case "^8":
                        output.SelectionColor = Color.DarkGray;
                        break;
                    case "^9":
                        output.SelectionColor = Color.Plum;
                        break;
                    case "^a":
                        output.SelectionColor = Color.LightGreen;
                        break;
                    case "^b":
                        output.SelectionColor = Color.LightBlue;
                        break;
                    case "^c":
                        output.SelectionColor = Color.DarkOrange;
                        break;
                    case "^d":
                        output.SelectionColor = Color.LightPink;
                        break;
                    case "^e":
                        output.SelectionColor = Color.Yellow;
                        break;
                    case "^f":
                        output.SelectionColor = Color.White;
                        break;
                    case "^p":
                        output.SelectionLength = 1;
                        output.SelectedText = Environment.NewLine + output.Text[searchStartIndx];
                        break;
                }
                // Debug.WriteLine(output.Rtf);
            }

        }
        public bool cmdAsAdmin(string args)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.UseShellExecute = true;
            startInfo.Arguments = @"/C " + args;
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            try
            { process.Start(); return true; }
            catch (Exception ex)
            {
                return false;
            }

        }
        private void sslCertSelected()
        {

            if (System.IO.File.Exists(Application.StartupPath + sslCertPicBox.Tag.ToString().Remove(0, 1)))//remove the . at the start of the path
            {
                sslCertPicBox.BackgroundImage = Properties.Resources.icons8_checkmark_24;
                toolTip1.SetToolTip(sslCertPicBox, sslCertPicBox.Tag.ToString());
                toolTip1.SetToolTip(selectSSLCertBtn, sslCertPicBox.Tag.ToString());

            }
            else
            {
                sslCertPicBox.BackgroundImage = Properties.Resources.x;
                toolTip1.SetToolTip(selectSSLCertBtn, "FILE NOT FOUND IN SPECIFIED PATH: " + sslCertPicBox.Tag.ToString());
                toolTip1.SetToolTip(sslCertPicBox, "FILE NOT FOUND IN SPECIFIED PATH: " + sslCertPicBox.Tag.ToString());
            }
        }
        private void sslKeySelected()
        {
            if (System.IO.File.Exists(Application.StartupPath + sslKeyPicBox.Tag.ToString().Remove(0, 1)))
            {
                toolTip1.SetToolTip(sslKeyPicBox, sslKeyPicBox.Tag.ToString());
                toolTip1.SetToolTip(selectSSLKeyBtn, sslKeyPicBox.Tag.ToString());
                sslKeyPicBox.BackgroundImage = Properties.Resources.icons8_checkmark_24;
            }
            else
            {
                sslKeyPicBox.BackgroundImage = Properties.Resources.x;
                toolTip1.SetToolTip(selectSSLKeyBtn, "FILE NOT FOUND IN SPECIFIED PATH: " + sslKeyPicBox.Tag.ToString());
                toolTip1.SetToolTip(sslKeyPicBox, "FILE NOT FOUND IN SPECIFIED PATH: " + sslKeyPicBox.Tag.ToString());

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
        public static string RemoveFirstLines(string text, int linesCount)
        {
            var lines = Regex.Split(text, "\r\n|\r|\n").Skip(linesCount);
            return string.Join(Environment.NewLine, lines.ToArray());
        }
        private string RTFtoBeamMP_conv(RichTextBox RTF)
        {
            //The most ugly and inefficient code you've probably ever seen v
            string Str = RTF.Rtf.Trim();
            Debug.Write(Str + Environment.NewLine);
            //--Do color things--
            string colorTableStr;
            string[] lines = Str.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            colorTableStr = lines[1];//get 2nd line of string which contains the color table
            List<string> extractedColors = new List<string>();
            int searchPos = 0;
            while (true)//extract colors from color table
            {
                int searchStartIndx = colorTableStr.IndexOf(';', searchPos);
                int searchEndindex = colorTableStr.IndexOf(';', searchStartIndx + 1);
                if (searchEndindex == -1) break;
                searchPos = searchEndindex;
                extractedColors.Add(colorTableStr.Substring(searchStartIndx + 1, searchEndindex - searchStartIndx - 1));
            }

            //--remove useless control words and keep the ones we care--
            List<string> formatStartWords = new List<string> { @"\b", @"\ul", @"\strike", @"\i" };
            List<string> formatEndWords = new List<string> { @"\b0", @"\ulnone", @"\strike0", @"\ul0", @"\i0" };
            List<string> colorWords = new List<string> { };
            if (RTF.Multiline) { formatStartWords.Add(@"\par"); }
            //add color control words to colorWords List so that they are excluded from the removal of the useless control words
            int colIndx = 1;
            foreach (string color in extractedColors)
            {
                colorWords.Add(@"\cf" + colIndx);
                colIndx++;
            }
            Str = RemoveFirstLines(Str, 2);//remove all lines from the string we don't need anymore or never needed at all
            Str = Str.Remove(Str.LastIndexOf(Environment.NewLine));//^
            searchPos = 0;
            while (Str.Substring(searchPos).Contains('\\'))
            {
                int searchStartIndx = Str.IndexOf('\\', searchPos);
                int[] searchEndindex = new[] { 0, 0, 0 };
                searchEndindex[0] = Str.IndexOf('\\', searchStartIndx + 1);
                searchEndindex[1] = Str.IndexOf(' ', searchStartIndx + 1);
                searchEndindex[2] = Str.IndexOf('\n', searchStartIndx + 1);
                int endIndx = 0;
                List<int> mins = new List<int>();
                foreach (int intg in searchEndindex)
                {
                    if (intg > 0) mins.Add(intg);
                }
                if (mins.Count == 0) endIndx = Str.Length;
                else endIndx = mins.Min();
                int count = endIndx - searchStartIndx;
                if (formatEndWords.Any(s => Str.Substring(searchStartIndx, count).Trim() == s.Trim()) || formatStartWords.Any(s => Str.Substring(searchStartIndx, count).Trim() == s.Trim()) || colorWords.Any(s => Str.Substring(searchStartIndx, count).Trim() == s.Trim()))
                {

                    //replace format codes that have different syntax but same effect, with a universal. e.g. \ul0 -> \ulnone
                    if (Str.Substring(searchStartIndx, count) == @"\ul0")
                    {
                        searchPos = endIndx - 4 + 7; //4 is the length of \ul0, 7 is the length of \ulnone
                        Str = Str.Remove(searchStartIndx, count);
                        Str = Str.Insert(searchStartIndx, @"\ulnone");

                    }
                    else searchPos = endIndx;
                }
                else
                {
                    searchPos = endIndx - count; //subtract the length of the word that we removed so that searchPos is right on track for the next cycle
                    Str = Str.Remove(searchStartIndx, count);
                }
            }
            //Debug.Write(Str); //<-------------------------------------------------------------------------------------------------------------------------------
            Str = Str.Trim();
            // Debug.WriteLine(Str + Environment.NewLine);

            //--Find and store all RTF formatting codes--
            searchPos = 0;
            var codes = new List<string>();
            while (Str.Substring(searchPos).Contains('\\'))
            {
                int searchStartIndx = Str.IndexOf('\\', searchPos);
                int[] searchEndindex = new[] { 0, 0, 0 };
                searchEndindex[0] = Str.IndexOf('\\', searchStartIndx + 1);
                searchEndindex[1] = Str.IndexOf(' ', searchStartIndx + 1);
                searchEndindex[2] = Str.IndexOf('\n', searchStartIndx + 1);
                int endIndx = 0;
                List<int> mins = new List<int>();
                foreach (int intg in searchEndindex)
                {
                    if (intg > 0) mins.Add(intg);
                }
                if (mins.Count == 0) endIndx = Str.Length;
                else endIndx = mins.Min();
                searchPos = endIndx;
                codes.Add(Str.Substring(searchStartIndx, endIndx - searchStartIndx).Trim());
            }

            //--Replace RTF formatting codes with BeamMP formatting codes--
            var activeCodes = new List<Tuple<string, string>>();//contains the codes that are still active
            foreach (string code in codes)
            {
                int oldcodeIndex;
                oldcodeIndex = Str.IndexOf(code);
                int remWhitespace = 0;
                try
                {
                    if (Str[oldcodeIndex + code.Length] == ' ' && Str[oldcodeIndex + code.Length + 1] != '\\')
                        remWhitespace = 1;
                    // Debug.WriteLine(Str[oldcodeIndex + code.Length]);
                    // Debug.WriteLine(Str[oldcodeIndex + code.Length + 1]);
                }
                catch (Exception) { }

                Str = Str.Remove(oldcodeIndex, code.Length + remWhitespace);
                if (code == @"\b")
                {
                    activeCodes.Add(Tuple.Create(@"^l", @"\b0")); //            
                    Str = Str.Insert(oldcodeIndex, "^l");
                }
                else if (code == @"\i")
                {
                    activeCodes.Add(Tuple.Create(@"^o", @"\i0"));
                    Str = Str.Insert(oldcodeIndex, "^o");
                }
                else if (code == @"\ul")
                {
                    activeCodes.Add(Tuple.Create(@"^n", @"\ulnone"));
                    Str = Str.Insert(oldcodeIndex, "^n");
                }
                else if (code == @"\strike")
                {
                    activeCodes.Add(Tuple.Create(@"^m", @"\strike0"));
                    Str = Str.Insert(oldcodeIndex, "^m");
                }
                else if (code == @"\par")
                {
                    Str = Str.Insert(oldcodeIndex, "^p");
                }
                else if (activeCodes.Any(m => m.Item2 == code))
                {

                    activeCodes.RemoveAt(activeCodes.FindIndex(m => m.Item2 == code));
                    foreach (Tuple<string, string> activCode in activeCodes)
                    {
                        Str = Str.Insert(oldcodeIndex, activCode.Item1);//re-insert active codes because we will cancel them using "^r"
                    }
                    Str = Str.Insert(oldcodeIndex, "^r");
                }
                else if (colorWords.Contains(code))//replace color codes
                {
                    int colorIndex = Int32.Parse(code.Substring(3, code.Length - 3)) - 1;//minus 1 because \cf1...2...3 starts from 1 while lists start from 0
                    string newCode;
                    switch (extractedColors[colorIndex])
                    {
                        case "\\red0\\green0\\blue0"://black
                            newCode = "^0";
                            break;
                        case "\\red0\\green0\\blue255"://blue
                            newCode = "^1";
                            break;
                        case "\\red255\\green255\\blue255"://white
                            newCode = "^f";
                            break;
                        case "\\red0\\green128\\blue0"://green
                            newCode = "^2";
                            break;
                        case "\\red173\\green216\\blue230"://light blue
                            newCode = "^3";
                            break;
                        case "\\red255\\green0\\blue0"://red
                            newCode = "^4";
                            break;
                        case "\\red255\\green192\\blue203"://pink
                            newCode = "^5";
                            break;
                        case "\\red255\\green165\\blue0"://orange
                            newCode = "^6";
                            break;
                        case "\\red128\\green128\\blue128"://gray
                            newCode = "^7";
                            break;
                        case "\\red169\\green169\\blue169"://dark gray
                            newCode = "^8";
                            break;
                        case "\\red221\\green160\\blue221"://light purple
                            newCode = "^9";
                            break;
                        case "\\red144\\green238\\blue144"://light green
                            newCode = "^a";
                            break;
                        case "\\red255\\green140\\blue0"://dark orange
                            newCode = "^c";
                            break;
                        case "\\red255\\green182\\blue193"://light pink
                            newCode = "^d";
                            break;
                        case "\\red255\\green255\\blue0"://yellow
                            newCode = "^e";
                            break;
                        default:
                            newCode = "^f";//default white
                            break;
                    }
                    Str = Str.Insert(oldcodeIndex, newCode);
                }

            }
            // Debug.WriteLine(Str);
            //--do some cleaning to the final result--
            Str = string.Join("\n", Str.Split('\n').Select(s => s.TrimEnd()));//trim ends of every line
            while (Str.Contains('\n'))
            {
                int newlnIndx = Str.IndexOf('\n');
                Str = Str.Remove(newlnIndx, 1);
            }
            while (Str[Str.Length - 2] == '^')//check for useless formatting codes at end of string
            {
                Str = Str.Remove(Str.Length - 2, 2);
            }
            //--remove unecessary duplicate formatting codes e.g. ^n^r^n -> ^r^n--
            searchPos = 0;
            while (Str.Substring(searchPos).Contains("^r"))
            {
                int resetIndex = Str.IndexOf("^r", searchPos);
                if (Str.Substring(resetIndex - 2, 2) == Str.Substring(resetIndex + 2, 2))
                {
                    Str = Str.Remove(resetIndex - 2, 2);
                    searchPos = resetIndex;
                }
                if (Str.Substring(resetIndex + 4, 2) == "^r")//e.g. ^r^n^r (i think lol i dont remember)
                {
                    Str = Str.Remove(resetIndex, 4);
                    searchPos = resetIndex;
                }
                else searchPos = resetIndex + 4;
            }
            //  Debug.WriteLine(Str);
            //(low effort solution)  check if it contains any formatting other than ^f. If not, remove the ^f and simply leave plain text which is by default white.
            if (Str.Contains("^f"))
            {
                string[] beammMPcodes = new string[] { "^r", "^p", "^n", "^l", "^m", "^o", "^1", "^2", "^3", "^4", "^5", "^6", "^7", "^8", "^9", "^a", "^b", "^c", "^d", "^e" };
                bool rem = true;
                foreach (string s in beammMPcodes)
                {
                    if (Str.Contains(s))
                    { rem = false; break; }
                }
                //remove ^f
                if (rem)
                    Str = Str.Remove(Str.IndexOf("^f"), 2);
            }
            return Str;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (mapsListView.SelectedItems.Count <= 0)
            {
                msgBox.msgBoxShow(this, "Please select a map!", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string mapItemTag = mapsListView.SelectedItems[0].Tag.ToString();
            string mapZipName;
            string mapName;
            if (mapItemTag.Contains(@"%*%"))
            {
                mapName = mapItemTag.Substring(0, mapItemTag.IndexOf("%*%")).Trim();
                mapZipName = mapItemTag.Substring(mapItemTag.IndexOf("%*%") + 3, mapItemTag.Length - mapItemTag.IndexOf("%*%") - 3).Trim();
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
                { msgBox.msgBoxShow(this, "ServerConfig.toml file could not be found! ", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Error); appendLog("ERROR:  Could not find ServerConfig.toml!"); return; }
                node["General"]["AuthKey"] = authTxtBox.Text;
                node["General"]["Debug"] = debugChckBox.Checked;
                makeFolders();
                //save map
                string[] clientFiles;
                try
                { clientFiles = Directory.GetFiles(Application.StartupPath + @"\" + resFold + @"\Client", "*.zip"); }
                catch { appendLog(@"ERROR: Couldn't find ""Clients"" folder"); msgBox.msgBoxShow(this, @"The ""Clients"" folder could not be found"); return; }
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
                node["General"]["Name"] = RTFtoBeamMP_conv(nameTxtBox);
                Regex regex = new Regex(@"d|e");

                node["General"]["Description"] = RTFtoBeamMP_conv(descTxtBox);
                node["General"]["Port"] = int.Parse(portTxtBox.Text);
                node["General"]["Private"] = privChckBox.Checked;
                node["General"]["LogChat"] = logChatChckB.Checked;
                node["General"]["Tags"] = tagsTxtBox.Text;
                //HTTP (UNUSED)
                // node["HTTP"]["HTTPServerIP"] = httpSrvIpTxtB.Text;
                // node["HTTP"]["HTTPServerPort"] = httpSrvPortTxtB.Text;
                // node["HTTP"]["SSLCertPath"] = sslCertPicBox.Tag.ToString();
                // node["HTTP"]["SSLKeyPath"] = sslKeyPicBox.Tag.ToString();
                // node["HTTP"]["UseSSL"] = useSSLChckB.Checked;
                // node["HTTP"]["HTTPServerEnabled"] = enableHTTPSrvChckB.Checked;
                //Misc
                node["Misc"]["ImScaredOfUpdates"] = hideUpdtMsgChckB.Checked;
                node["Misc"]["SendErrorsShowMessage"] = onOffSendErrorsChckB.Checked;
                node["Misc"]["SendErrors"] = sendErrorsChckB.Checked;
                using (var sw = File.CreateText(Application.StartupPath + cfgFilePath))
                { node.WriteTo(sw); }
                appendLog("Saved server settings");
                bool dontshowAgain1 = Properties.Settings.Default.dontshowMsgSave;
                showMsgBoxDontshow(ref dontshowAgain1, "Saved! If your server is running, please restart it so that the changes take effect", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.dontshowMsgSave = dontshowAgain1;
                if (int.Parse(portTxtBox.Text) != port)//check if port number was changed
                {
                    bool dontshowAgain2 = Properties.Settings.Default.dontshowMsgNewPort;
                    showMsgBoxDontshow(ref dontshowAgain2, @"The server port has been modified! Make sure to update the firewall rules form the ""Useful Tools"" button or do it manually. ", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.dontshowMsgNewPort = dontshowAgain2;
                }
                Properties.Settings.Default.Save();


            }
            catch (Exception ex)
            {
                msgBox.msgBoxShow(this, "Could not save the settings!" + Environment.NewLine + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appendLog("ERROR:  Could not save the settings!" + Environment.NewLine + ex.ToString());
                return;
            }
            reloadCfgBtn.PerformClick();
        }

        public void appendLog(string text)
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
            else { appendLog(@"ERROR: Failed to open ""Client"" folder "); msgBox.msgBoxShow(this, "The mod folder could not be found! Run the server at least once to prepare the files and folders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logForm.Show();
            logForm.Focus();
        }

        private void button3_Click_1(object sender, EventArgs e)//unused
        {
            FolderBrowserDialog foldDialog = new FolderBrowserDialog();
            foldDialog.SelectedPath = Application.StartupPath;
            if (foldDialog.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Directory.Exists(foldDialog.SelectedPath))
                {
                    //selectResLocBtn.Tag = foldDialog.SelectedPath;
                    // toolTip1.SetToolTip(selectResLocBtn, foldDialog.SelectedPath);
                }
                else
                { msgBox.msgBoxShow(this, "The selected path could not be found", "Resource folder location", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            { Process.Start(Application.StartupPath + @"\" + resFold + @"\Server"); }
            catch { appendLog(@"ERROR: Failed to open ""Server"" folder "); msgBox.msgBoxShow(this, "The plugins folder could not be found! Run the server at least once to prepare the files and folders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private DialogResult showMsgBoxDontshow(ref bool dontshowAgain, string body, string title, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon MessageBoxIcon = MessageBoxIcon.None, Image img = null)
        {
            if (dontshowAgain) return DialogResult.None;
            DialogResult diagRes;
            msgBox MsgBox = new msgBox();
            CheckBox chkBox = new CheckBox();
            chkBox.AutoSize = true;
            chkBox.Location = new System.Drawing.Point(7, 8);
            chkBox.Text = "Don't show again.";
            chkBox.ForeColor = SystemColors.Control;
            chkBox.UseVisualStyleBackColor = true;
            MsgBox.panel2.Controls.Add(chkBox);
            diagRes = MsgBox.Show(this, body, title, buttons, MessageBoxIcon, img);
            dontshowAgain = chkBox.Checked;

            MsgBox.Dispose();
            return diagRes;

        }
        private void button3_Click_2(object sender, EventArgs e)
        {

            try
            { Process.Start(Application.StartupPath + @"\custom_maps"); }
            catch { appendLog(@"ERROR: Failed to open ""custom_maps"" folder "); msgBox.msgBoxShow(this, "The custom maps folder could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void modListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modListView.SelectedItems.Count == 0)
            { activateModBtn.Enabled = false; return; }
            activateModBtn.Enabled = true;
            if (modListView.SelectedItems[0].ForeColor == Color.Red)
            { activateModBtn.Text = "Activate"; }
            else if (modListView.SelectedItems[0].ForeColor == SystemColors.Control)
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
                    if (msgBox.msgBoxShow(this, "A duplicate of this " + type + " has been found. You have to delete one of the copies in order to continue. Do you want to delete one of the copies?", "Activate Mod", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                catch (Exception ex) { appendLog("ERROR: Failed to move the " + type + Environment.NewLine + ex.ToString()); msgBox.msgBoxShow(this, "The selected " + type + @" could not be activated/deactivated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (type == "plugin")
            {
                item = pluginlistView.SelectedItems[0];
                if (Directory.Exists(foldToMove + item.Tag.ToString()))
                {
                    if (msgBox.msgBoxShow(this, "A duplicate of this " + type + " has been found. You have to delete one of the copies in order to continue. Do you want to delete one of the copies?", "Activate Mod", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                catch (Exception ex) { appendLog("ERROR: Failed to move the folder" + Environment.NewLine + ex.ToString()); msgBox.msgBoxShow(this, "The selected " + type + @" could not be activated/deactivated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
            else if (pluginlistView.SelectedItems[0].ForeColor == SystemColors.Control)
            { activatePluginsBtn.Text = "Deactivate"; }
        }

        //search form stuff
        searchFrm searchForm = new searchFrm();
        int[] searchFrmLoc;
        ListView listview;
        ListView backupListview;
        ListView backupMapListview = new ListView();
        ListView backupModListview = new ListView();
        ListView backupPluginListview = new ListView();

        private void showSearchFrm(int[] loc, string title)
        {
            searchForm.textBox1.Clear();
            searchFrmLoc = loc;
            searchForm.Show();
            searchForm.baseFormUsrCtrl1.formTitleLbl.Text = title;

            searchForm.Text = title;
            searchForm.Location = new Point(this.Location.X + searchFrmLoc[0], this.Location.Y + searchFrmLoc[1]);
            searchForm.textBox1.TextChanged += new System.EventHandler(this.searchForm_textBox1_TextChanged);
            searchForm.BringToFront();
            searchForm.Focus();
            searchForm.textBox1.Focus();
        }
        private void searchMods_Click(object sender, EventArgs e)
        {
            showSearchFrm(new int[] { 998, 55 }, "Search - Mods");
            listview = modListView;
            backupListview = backupModListview;
        }
        private void searchPluginsBtn_Click(object sender, EventArgs e)
        {
            showSearchFrm(new int[] { 998, 305 }, "Search - Plugins");
            listview = pluginlistView;
            backupListview = backupPluginListview;

        }

        private void searchMapsBtn_Click(object sender, EventArgs e)
        {
            showSearchFrm(new int[] { 998, 225 }, "Search - Maps");
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
            configureMaps();
        }
        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            try
            {
                if (searchForm.Visible == true)
                { searchForm.Location = new Point(this.Location.X + searchFrmLoc[0], this.Location.Y + searchFrmLoc[1]); }

                if (srvCtrlPnlFrm.Visible == true)
                { srvCtrlPnlFrm.Location = new Point(this.Location.X - 470, this.Location.Y); }

                searchForm.BringToFront();
                srvCtrlPnlFrm.BringToFront();
            }
            catch { }

        }
        serverControlPnlFrm srvCtrlPnlFrm;
        private void showSrvCtrlPnlFrm()
        {
            srvCtrlPnlFrm = new serverControlPnlFrm(this);
            srvCtrlPnlFrm.Show();
            srvCtrlPnlFrm.Location = new Point(this.Location.X - 470, this.Location.Y);
            searchForm.BringToFront();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/donate/?hosted_button_id=FFFSN8XZHVWRU");
        }


        private void descTxtBox_Leave(object sender, EventArgs e)
        {
            Transition.run((Control)sender, "BackColor", Color.FromArgb(34, 47, 74), new TransitionType_Linear(200));
            customNameBtn2.ColorNormal = Color.FromArgb(34, 47, 74);
            customDescBtn2.ColorNormal = Color.FromArgb(34, 47, 74);
            Transition.run(customNameBtn2, "BackColor", Color.FromArgb(34, 47, 74), new TransitionType_Linear(200));
            Transition.run(customDescBtn2, "BackColor", Color.FromArgb(34, 47, 74), new TransitionType_Linear(200));
        }

        private void descTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            Transition.run((Control)sender, "BackColor", Color.FromArgb(23, 31, 51), new TransitionType_Linear(150));
            customNameBtn2.ColorNormal = Color.FromArgb(23, 31, 51);
            customDescBtn2.ColorNormal = Color.FromArgb(23, 31, 51);
            Transition.run(customNameBtn2, "BackColor", Color.FromArgb(23, 31, 51), new TransitionType_Linear(150));
            Transition.run(customDescBtn2, "BackColor", Color.FromArgb(23, 31, 51), new TransitionType_Linear(150));
        }

        private void customBtn2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void customSmoothBtn1_Click(object sender, EventArgs e)
        {
            maxPlayerCombo.Focus();
            maxPlayerCombo.DroppedDown = true;
        }

        private void maxPlayerCombo_TextChanged(object sender, EventArgs e)
        {
            maxPlayersTxtBox.Text = maxPlayerCombo.Text;
        }

        private void maxCarsCombo_TextChanged(object sender, EventArgs e)
        {
            maxCarsTxtBox.Text = maxCarsCombo.Text;
        }

        private void maxCarsPlayerComboCoverBtn_Click(object sender, EventArgs e)
        {
            maxCarsCombo.Focus();
            maxCarsCombo.DroppedDown = true;
        }

        private void customSmoothBtn1_Click_1(object sender, EventArgs e)
        {
            maxPlayerCombo.Focus();
            maxPlayerCombo.DroppedDown = true;
        }

        private void customSmoothBtn2_Click(object sender, EventArgs e)
        {
            maxCarsCombo.Focus();
            maxCarsCombo.DroppedDown = true;
        }

        private void editConf_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + cfgFilePath);
            }
            catch (Exception a) { appendLog("Error: Could not open config file. " + a.ToString()); msgBox.msgBoxShow(this, "Could not open file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void baseFormUsrCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void portTxtBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            { e.Handled = true; }
        }
        //panel tab switch buttons
        private void customSmoothBtn2_Click_1(object sender, EventArgs e)
        {
            httpTabBtn.BackColor = colorNormal;
            httpTabBtn.ColorNormal = colorNormal;
            httpPnl.BringToFront();
            miscPnl.SendToBack();
            miscTabBtn.BackColor = Color.Transparent;
            miscTabBtn.ColorNormal = Color.Transparent;

        }

        private void customSmoothBtn3_Click(object sender, EventArgs e)
        {
            miscTabBtn.BackColor = colorNormal;
            miscTabBtn.ColorNormal = colorNormal;
            miscPnl.BringToFront();
            httpPnl.SendToBack();
            httpTabBtn.BackColor = Color.Transparent;
            httpTabBtn.ColorNormal = Color.Transparent;

        }

        private void selectSSLCertBtn_Click(object sender, EventArgs e)
        {
            bool showAgain = Properties.Settings.Default.dontshowMsgSSL;
            showMsgBoxDontshow(ref showAgain, "NOTE: The Certificate file should be inside the BeamMP Server folder!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Properties.Settings.Default.dontshowMsgSSL = showAgain;
            Properties.Settings.Default.Save();

            OpenFileDialog dialog = new OpenFileDialog();
            if (System.IO.File.Exists("./.ssl/HttpServer"))
            {
                dialog.InitialDirectory = "./.ssl/HttpServer";
            }
            else
            {
                dialog.InitialDirectory = Application.StartupPath;
            }
            dialog.Filter = ".pem|*.pem";
            dialog.Title = "Select the SSL Certificate file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!dialog.FileName.Contains(Application.StartupPath))
                {
                    msgBox.msgBoxShow(this, "Warning! The certificate file should be inside the BeamMP Server folder! The one you chose is not!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sslCertPicBox.Tag = "." + dialog.FileName.Remove(0, Application.StartupPath.Length);
            }
            sslCertSelected();
        }
        private void selectSSLKeyBtn_Click(object sender, EventArgs e)
        {
            bool showAgain = Properties.Settings.Default.dontshowMsgSSL;
            showMsgBoxDontshow(ref showAgain, "NOTE: The Key file should be inside the BeamMP Server folder!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Properties.Settings.Default.dontshowMsgSSL = showAgain;
            Properties.Settings.Default.Save();

            OpenFileDialog dialog = new OpenFileDialog();
            if (System.IO.File.Exists("./.ssl/HttpServer"))
            {
                dialog.InitialDirectory = "./.ssl/HttpServer";
            }
            else
            {
                dialog.InitialDirectory = Application.StartupPath;
            }
            dialog.Filter = ".pem|*.pem";
            dialog.Title = "Select the SSL Key file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!dialog.FileName.Contains(Application.StartupPath))
                {
                    msgBox.msgBoxShow(this, "Warning! The Key file should be inside the BeamMP Server folder! The one you chose is not!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sslKeyPicBox.Tag = "." + dialog.FileName.Remove(0, Application.StartupPath.Length);
            }
            sslKeySelected();
        }

        private void customSmoothBtn2_Click_2(object sender, EventArgs e)
        {

            string path = @".\Resources\client\" + mapsListView.Tag.ToString();
            if (!File.Exists(path))
            {
                msgBox.msgBoxShow(this, @"Zip file could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appendLog("Maps zip file could not be found");
                return;
            }
            string args = string.Format("/e, /select, \"{0}\"", path);
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer";
            info.Arguments = args;
            Process.Start(info);
        }

        private void enableHTTPSrvChckB_CheckedChanged(object sender, EventArgs e)
        {
            void btns(bool enabled)
            {
                selectSSLCertBtn.Enabled = enabled;
                selectSSLKeyBtn.Enabled = enabled;
                useSSLChckB.Enabled = enabled;
                sslCertPicBox.Enabled = enabled;
                sslKeyPicBox.Enabled = enabled;
                httpSrvIpTxtB.Enabled = enabled;
                httpSrvPortTxtB.Enabled = enabled;
            }
            if (enableHTTPSrvChckB.Checked) btns(true);
            else btns(false);
        }
        public customizeNameFrm customNamefrm = null;

        public void nameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //block some chars
            if (e.KeyChar == '^' || e.KeyChar == '\\')
            {
                e.Handled = true;
                System.Media.SystemSounds.Hand.Play();
                toolTipNoBallon.Show("This character is not allowed!", sender as RichTextBox);
            }
        }

        private void customSmoothBtn3_Click_1(object sender, EventArgs e)
        {

            srvCtrlPnlFrm.Hide();
        }
        private void customSmoothBtn3_Click_2(object sender, EventArgs e)
        {
            srvCtrlPnlFrm.Location = new Point(this.Location.X - 470, this.Location.Y);
            srvCtrlPnlFrm.BringToFront();
            srvCtrlPnlFrm.Show();
        }
        private void customSmoothBtn2_Click_4(object sender, EventArgs e)
        {
            showMenuStripAtBtn(otherMenu, otherBtn);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            if (srvCtrlPnlFrm.beamMPProcRunning())
            {
                e.Cancel = true;
                msgBox.msgBoxShow(this, @"The server is still running! You must stop the server before closing the BeamMP Server Management Tool ", "Exit Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void scrolltoTxtBoxEnd(TextBox txtBox = null, RichTextBox rtxtBox = null)
        {
            if (txtBox != null)
            {
                txtBox.SelectionStart = txtBox.Text.Length;
                txtBox.ScrollToCaret();
            }
            if (rtxtBox != null)
            {
                rtxtBox.SelectionStart = rtxtBox.Text.Length;
                rtxtBox.ScrollToCaret();
            }
        }

        private void toolTipNoBallon_Popup(object sender, PopupEventArgs e)
        {

        }

        private void createRequiredFirewallRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruleName = "BeamMP Server (Made with BeamMP Server Management Tool)";
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            List<INetFwRule> firewallRules = firewallPolicy.Rules.OfType<INetFwRule>().Where(x => x.Name.Contains(ruleName)).ToList();
            string deleteCommand = @"netsh advfirewall firewall delete rule name = """ + ruleName + @"""";
            string finalDeleteCommand = "";
            foreach (INetFwRule rule in firewallRules)
            {

                finalDeleteCommand = deleteCommand + " && ";

            }
            bool success = cmdAsAdmin(finalDeleteCommand + @"netsh advfirewall firewall add rule name=""" + ruleName + @""" dir=in action=allow protocol=TCP localport=" + port + " && " +
             @"netsh advfirewall firewall add rule name=""" + ruleName + @""" dir=in action=allow protocol=UDP localport=" + port + " && " +
             @"netsh advfirewall firewall add rule name=""" + ruleName + @""" dir=out action=allow protocol=TCP localport=" + port + " && " +
             @"netsh advfirewall firewall add rule name=""" + ruleName + @""" dir=out action=allow protocol=UDP localport=" + port);
            if (success)
            {
                msgBox.msgBoxShow(this, @"The firewall rules were successfully created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                appendLog(@"Firewall rules creation success");
            }
            else
            {
                appendLog(@"Firewall rules creation cancelled/failed");
            }
        }


        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectCustomStartFile.InitialDirectory = Application.StartupPath;
            if (selectCustomStartFile.ShowDialog() == DialogResult.OK)
            {
                srvCtrlPnlFrm.srvStartFile = selectCustomStartFile.FileName;
                Properties.Settings.Default.srvStartFile = selectCustomStartFile.FileName;
                selectToolStripMenuItem.ToolTipText = Path.GetFileName(selectCustomStartFile.FileName);
                selectedSrvStartFileLblBtn.Text = "Selected: " + Path.GetFileName(selectCustomStartFile.FileName);
                Properties.Settings.Default.Save();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            srvCtrlPnlFrm.srvStartFile = Application.StartupPath + @"\BeamMP-Server.exe";
            Properties.Settings.Default.srvStartFile = "";
            selectToolStripMenuItem.ToolTipText = "Default";
            selectedSrvStartFileLblBtn.Text = "Selected: Default";
            Properties.Settings.Default.Save();
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            // srvCtrlPnlFrm.Show();
        }


        private void customSmoothBtn2_Click_6(object sender, EventArgs e)
        {//add general func for all errors. Put action and error message and args and let it do everything else like logging<-------------------
            try
            {
                Process.Start(Application.StartupPath);
            }
            catch (Exception a) { appendLog("Error: Could not open server root folder " + a.ToString()); msgBox.msgBoxShow(this, "Could not open the server's root folder!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void nameTxtBox_MouseEnter(object sender, EventArgs e)
        {
            if (!nameTxtBox.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                customNameBtn2.BackColor = nameTxtBox.BackColor;
                customNameBtn2.ColorNormal = nameTxtBox.BackColor;
                customNameBtn2.Visible = true;
            }
        }

        private void nameTxtBox_MouseLeave(object sender, EventArgs e)
        {
            int cursorPosX = generalSettingsPnl.PointToClient(Cursor.Position).X;
            int cursorPosY = generalSettingsPnl.PointToClient(Cursor.Position).Y;
            //subtract or add 4 because the mouseleave event triggers too soon before the cursor has a chance to fully leave the control
            if (cursorPosX + 4 > nameTxtBox.Right || cursorPosX - 4 < nameTxtBox.Left || cursorPosY - 4 < nameTxtBox.Top || cursorPosY + 4 > nameTxtBox.Bottom)
            {
                customNameBtn2.Visible = false;
            }

        }
        private void descTxtBox_MouseLeave(object sender, EventArgs e)
        {
            int cursorPosX = generalSettingsPnl.PointToClient(Cursor.Position).X;
            int cursorPosY = generalSettingsPnl.PointToClient(Cursor.Position).Y;
            //subtract or add 4 because the mouseleave event triggers too soon before the cursor has a chance to fully leave the control
            if (cursorPosX + 4 > descTxtBox.Right || cursorPosX - 4 < descTxtBox.Left || cursorPosY - 4 < descTxtBox.Top || cursorPosY + 4 > descTxtBox.Bottom)
            {
                customDescBtn2.Visible = false;
            }

        }
        private void descTxtBox_MouseEnter(object sender, EventArgs e)
        {
            if (!descTxtBox.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                customDescBtn2.BackColor = descTxtBox.BackColor;
                customDescBtn2.ColorNormal = descTxtBox.BackColor;
                customDescBtn2.Visible = true;
            }
        }

        private void customNameBtn2_Click(object sender, EventArgs e)
        {
            if (customNamefrm == null) { customNamefrm = new customizeNameFrm(this, nameTxtBox, "Customize Server Name"); }
            customNamefrm.ShowDialog();
        }

        private void customDescBtn2_Click(object sender, EventArgs e)
        {
            if (customNamefrm == null) { customNamefrm = new customizeNameFrm(this, descTxtBox, "Customize Server Description"); }
            customNamefrm.ShowDialog();
        }

    }
}

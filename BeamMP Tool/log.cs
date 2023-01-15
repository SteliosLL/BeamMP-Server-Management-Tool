using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Server_Creation_Tool.myClasses
{
    public class log
    {
        public static StringBuilder sb = new StringBuilder();
        public static void Append(string toAppend)
        {
            sb.AppendFormat(DateTime.Now.ToString("hh:mm tt") + ">>> " + toAppend + Environment.NewLine);
        }
        public static void Save()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "BeamMP_Server_MT_Logs";
            if (!System.IO.Directory.Exists(path))
            { System.IO.Directory.CreateDirectory(path); }
            if (sb.ToString().Trim() != "")
            {
                File.AppendAllText(path + "\\" + DateTime.Today.ToString("dd-MM-yyyy") + "-log.txt", sb.ToString());
                sb.Clear();
            }
        }
    }
}

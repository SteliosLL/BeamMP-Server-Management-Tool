using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeamMP_Tool
{
    public partial class baseFormUsrCtrl : UserControl
    {
        //stuff for moving the mainForm around when click-dragging it
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr handle);
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int nCmdShow);
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool IsIconic(IntPtr handle);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public baseFormUsrCtrl()
        {
            InitializeComponent();
        }
        //  funcsClass funcs = new funcsClass();
        private bool minBtn = true;
        private bool ctrlBox = true;
        private Image icon = Properties.Resources.BeamMP_32512_3;
        private string title = "BaseForm";
        private Form parentfrm;
        public bool Minimize_Button
        {
            get { return minBtn; }
            set { minBtn = value; }
        }
        public bool ControlBox
        {
            get { return ctrlBox; }
            set { ctrlBox = value; }
        }
        public Image Icon
        {
            get { return icon; }
            set { icon = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public Form parentForm
        {
            get { return parentfrm; }
            set { parentfrm = value; }
        }

        private void baseFormUsrCtrl_Load(object sender, EventArgs e)
        {
            minimizeFormBtn.Visible = minBtn;
            if (!ctrlBox)
            {
                minimizeFormBtn.Visible = ctrlBox;
                closeFormBtn.Visible = false;
            }
            formIconPicbox.BackgroundImage = icon;
            formTitleLbl.BringToFront();
            if (icon == null)
            {
                formTitleLbl.Location = new Point(formTitleLbl.Location.X - 25, formTitleLbl.Location.Y);
            }
            else { parentForm.Icon = convertPNGtoICO(icon); }
            parentForm.Text = title;
            formTitleLbl.Text = title;
        }
        public Icon convertPNGtoICO(Image img)
        {
            Bitmap bitmap = (Bitmap)img;
            return System.Drawing.Icon.FromHandle(bitmap.GetHicon());
        }
        private void closeFormBtn_Click_1(object sender, EventArgs e)
        {
            parentForm.Close();
        }

        private void minimizeFormBtn_Click_1(object sender, EventArgs e)
        {
            parentForm.WindowState = FormWindowState.Minimized;

        }

        private void mainFormDrag(object sender, MouseEventArgs e)
        {
            //move the window around by clicking on panel1, since we have disabled the traditional windows-style border
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(parentForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

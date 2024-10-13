using QuanLyPhongTro.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        #region gui
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picState_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                picState.Image = Properties.Resources.max;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                picState.Image = Properties.Resources.images;
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        //add form
        private void AddForm(Form f)
        {
            this.grbContent.Controls.Clear(); //xoa control co tren groubox
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grbContent.Controls.Add(f);
            f.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var f = new frmWelcome();
            AddForm(f);
        }
        //trang loại phòng
        private void loaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new fmLoaiPhong();
            AddForm(f);
        }
    }
}

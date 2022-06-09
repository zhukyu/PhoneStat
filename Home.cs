using PhoneStat.Properties;
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

namespace PhoneStat
{
    public partial class Home : Form
    { 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ClearContent()
        {
            //clear content panel
            foreach (Control c in this.ContentPnl.Controls)
            {
                this.ContentPnl.Controls.Remove(c);
            }
        }
        private void SelectButton(object sender, EventArgs e)
        {
            // clear button color
            foreach (Control c in this.Dashboard.Controls)
            {
                if (c.GetType() == typeof(LinkLabel))
                {
                    LinkLabel linkLabel = (LinkLabel)c;
                    linkLabel.LinkVisited = false;
                }
            }
            ClearContent();
            LinkLabel click = (LinkLabel)sender;
            click.LinkVisited = true;
        }
        private void PhoneEditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(Program.isLoggedIn == false)
            {
                LoginHandle();
                if(Program.isLoggedIn == true)
                {
                    SelectButton(PhoneEditLink, new EventArgs());
                    PhoneEdit phoneEdit = new PhoneEdit();
                    ContentPnl.Controls.Add(phoneEdit);
                }
            }
            else
            {
                if (PhoneEditLink.LinkVisited == true)
                    return;
                SelectButton(PhoneEditLink, new EventArgs());
                PhoneEdit phoneEdit = new PhoneEdit();
                ContentPnl.Controls.Add(phoneEdit);
            }
        }

        private void PhoneListLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PhoneListLink.LinkVisited == true)
                return;
            SelectButton(PhoneListLink, new EventArgs());
            PhoneList phoneList = new PhoneList();
            ContentPnl.Controls.Add(phoneList);
        }

        private void ContentPnl_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoginHandle()
        {
            Login login = new Login();
            login.ShowDialog();
            if(Program.isLoggedIn == true)
            {
                LoginLink.Hide();
                LogOutLink.Show();
                UserNameLabel.Show();
            }
        }
        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            LoginHandle();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void LogOutBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.isLoggedIn = false;
            LoginLink.Show();
            LogOutLink.Hide();
            UserNameLabel.Hide();
            if(PhoneEditLink.LinkVisited == true)
            {
                PhoneListLink_LinkClicked(sender, null);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStat
{
    public partial class PhoneItem : UserControl
    {
        Phone phone;
        public PhoneItem()
        {
            InitializeComponent();
        }
        private void guna2Panel1_MouseEnter(object sender, EventArgs e)
        {
            this.phoneImg.Location = new Point(0, 10);
        }

        private void guna2Panel1_MouseLeave(object sender, EventArgs e)
        {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                return;
            else
            {
                this.phoneImg.Location = new Point(0, 22);
            }
        }
        protected override void OnMouseLeave(EventArgs e)
        {

            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                return;
            else
            {
                this.phoneImg.Location = new Point(0, 22);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhoneDetail phoneDetail = new PhoneDetail(phone);
            phoneDetail.ShowDialog();
        }
    }
}

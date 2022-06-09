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
    public partial class PhoneList : UserControl
    {
        public PhoneList()
        {
            InitializeComponent();
        }

        private void FLow_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            PhoneItem product = new PhoneItem();
            PhoneItem product1 = new PhoneItem();
            PhoneItem product2 = new PhoneItem();
            PhoneItem product3 = new PhoneItem();
            PhoneItem product4 = new PhoneItem();
            PhoneItem product5 = new PhoneItem();
            PhoneItem product6 = new PhoneItem();
            flowLayoutPanel1.Controls.Add(product);
            flowLayoutPanel1.Controls.Add(product1);
            flowLayoutPanel1.Controls.Add(product2);
            flowLayoutPanel1.Controls.Add(product3);
            flowLayoutPanel1.Controls.Add(product4);
            flowLayoutPanel1.Controls.Add(product5);
            flowLayoutPanel1.Controls.Add(product6);    
        }
    }
}

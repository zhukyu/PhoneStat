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
        List<Phone> phones;
        public PhoneList()
        {
            InitializeComponent();
            phones = InteractDB.GetData();
        }

        private void FLow_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            foreach (Phone phone in phones)
            {
                PhoneItem phoneItem = new PhoneItem(phone);
                flowLayoutPanel1.Controls.Add(phoneItem);
            }
        }
    }
}

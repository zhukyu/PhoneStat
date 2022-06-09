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
    public partial class PhoneDetail : Form
    {
        Phone phone;
        public PhoneDetail(Phone phone)
        {
            InitializeComponent();
            this.phone = phone;
        }

        private void PhoneDetail_Load(object sender, EventArgs e)
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

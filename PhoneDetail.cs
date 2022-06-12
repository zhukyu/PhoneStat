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
            NameTextBox.Text = phone.name;
            BrandTextBox.Text = phone.brand;
            ChipsetTextBox.Text = phone.chipset;
            RAMTextBox.Text = phone.RAM;
            ROMTextBox.Text = phone.ROM;
            HasSDCardTextBox.Text = phone.hasSDCard;
            BatteryTextBox.Text = phone.battery;
            ResolutionTextBox.Text = phone.resolution;
            DisplaySizeTextBox.Text = phone.displaySize;
            RefreshRateTextBox.Text = phone.refreshRate;
            CameraResolutionTextBox.Text = phone.cameraResolution;
            FrontCameraResolutionTextBox.Text = phone.frontCameraResolution;
            PhoneImage.Image = phone.image;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

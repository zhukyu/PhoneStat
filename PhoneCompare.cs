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
    public partial class PhoneCompare : UserControl
    {
        List<Phone> phones;
        public PhoneCompare()
        {
            InitializeComponent();
            phones = InteractDB.GetData();
        }

        private void PhoneCompare_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            foreach (Phone phone in phones)
            {
                SearchCB1.Items.Add(phone.name);
                SearchCB2.Items.Add(phone.name);
            }
        }

        private void SearchBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                int CbIndex = SearchCB1.SelectedIndex;
                if (CbIndex == -1) // không thấy điện thoại
                {
                    throw new Exception("Không tìm thấy điện thoại");
                }
                Phone phone = phones[CbIndex];
                NameTB1.Text = phone.name;
                BrandTB1.Text = phone.brand;
                ChipsetTB1.Text = phone.chipset;
                RAMTB1.Text = phone.RAM;
                ROMTB1.Text = phone.ROM;
                HasSDCardTB1.Text = phone.hasSDCard;
                BatteryTB1.Text = phone.battery;
                ResolutionTB1.Text = phone.resolution;
                DisplaySizeTB1.Text = phone.displaySize;
                RefreshRateTB1.Text = phone.refreshRate;
                CameraResolutionTB1.Text = phone.cameraResolution;
                FrontCameraResolutionTB1.Text = phone.frontCameraResolution;
                PhoneImage1.Image = phone.image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameTB1.Text = "";
                BrandTB1.Text = "";
                ChipsetTB1.Text = "";
                RAMTB1.Text = "";
                ROMTB1.Text = "";
                HasSDCardTB1.Text = "";
                BatteryTB1.Text = "";
                ResolutionTB1.Text = "";
                DisplaySizeTB1.Text = "";
                RefreshRateTB1.Text = "";
                CameraResolutionTB1.Text = "";
                FrontCameraResolutionTB1.Text = "";
                PhoneImage1.Image = Properties.Resources._65756;
            }
        }

        private void SearchBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                int CbIndex = SearchCB2.SelectedIndex;
                if (CbIndex == -1) // không thấy điện thoại
                {
                    throw new Exception("Không tìm thấy điện thoại");
                }
                Phone phone = phones[CbIndex];
                NameTB2.Text = phone.name;
                BrandTB2.Text = phone.brand;
                ChipsetTB2.Text = phone.chipset;
                RAMTB2.Text = phone.RAM;
                ROMTB2.Text = phone.ROM;
                HasSDCardTB2.Text = phone.hasSDCard;
                BatteryTB2.Text = phone.battery;
                ResolutionTB2.Text = phone.resolution;
                DisplaySizeTB2.Text = phone.displaySize;
                RefreshRateTB2.Text = phone.refreshRate;
                CameraResolutionTB2.Text = phone.cameraResolution;
                FrontCameraResolutionTB2.Text = phone.frontCameraResolution;
                PhoneImage2.Image = phone.image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameTB2.Text = "";
                BrandTB2.Text = "";
                ChipsetTB2.Text = "";
                RAMTB2.Text = "";
                ROMTB2.Text = "";
                HasSDCardTB2.Text = "";
                BatteryTB2.Text = "";
                ResolutionTB2.Text = "";
                DisplaySizeTB2.Text = "";
                RefreshRateTB2.Text = "";
                CameraResolutionTB2.Text = "";
                FrontCameraResolutionTB2.Text = "";
                PhoneImage2.Image = Properties.Resources._65756;
            }
        }
    }
}

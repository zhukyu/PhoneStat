using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStat
{
    public partial class UpdatePhone : Form
    {
        Image? phoneImage = null;
        Phone phone;
        public UpdatePhone(Phone phone)
        {
            InitializeComponent();
            this.phone = phone;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                phoneImage = new Bitmap(openFile.FileName);
                PhoneImage.Image = phoneImage;
            }
        }
        private void DeleteImgBtn_Click(object sender, EventArgs e)
        {
            phoneImage = null;
            PhoneImage.Image = Properties.Resources._65756;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn cập nhật điện thoại này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    if (NameTextBox.Text == "")
                        throw new Exception("Tên điện thoại không được để trống!");
                    Phone phoneTmp = new Phone(
                        phone.ID, NameTextBox.Text, BrandTextBox.Text, ChipsetTextBox.Text, RAMTextBox.Text, ROMTextBox.Text, HasSDCardTextBox.Text, BatteryTextBox.Text,
                        ResolutionTextBox.Text, DisplaySizeTextBox.Text, RefreshRateTextBox.Text, CameraResolutionTextBox.Text, FrontCameraResolutionTextBox.Text, phoneImage
                    );
                    int ret = InteractDB.UpdateData(phoneTmp);
                    if (ret > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Không thể cập nhật!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdatePhone_Load(object sender, EventArgs e)
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
    }
}

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
    public partial class AddPhone : Form
    {
        string convertedByteStr = "";
        string filePath = "";
        public AddPhone()
        {
            InitializeComponent();
        }
        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
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
                filePath = openFile.FileName;
                convertedByteStr = Convert.ToBase64String(converImgToByte());
                PhoneImage.Image = ByteToImg(convertedByteStr);
            }
        }
        private void DeleteImgBtn_Click(object sender, EventArgs e)
        {
            filePath = "";
            convertedByteStr = "";
            PhoneImage.Image = Properties.Resources._65756;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

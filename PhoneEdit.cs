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
    public partial class PhoneEdit : UserControl
    {
        List<Phone> phones;
        public PhoneEdit()
        {
            InitializeComponent();
            phones = InteractDB.GetData();
        }

        private void PhoneEdit_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            foreach (Phone phone in phones)
            {
                PhoneDGV.Rows.Add(
                    phone.ID.ToString(),
                    phone.name,
                    phone.brand,
                    phone.chipset,
                    phone.RAM,
                    phone.ROM,
                    phone.hasSDCard,
                    phone.battery,
                    phone.resolution,
                    phone.displaySize,
                    phone.refreshRate,
                    phone.cameraResolution,
                    phone.frontCameraResolution,
                    phone.image
                );
            }
        }
        private void ReloadDGV()
        {
            phones = InteractDB.GetData();
            PhoneDGV.Rows.Clear();
            PhoneEdit_Load(new Object(), new EventArgs());

        }
        private void AddLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddPhone addPhone = new AddPhone();
            addPhone.ShowDialog();
        }

        private void EditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Phone phone = phones[PhoneDGV.CurrentCell.RowIndex];
            UpdatePhone updatePhone = new UpdatePhone(phone);
            updatePhone.ShowDialog();
            ReloadDGV(); 
        }

        private void DeleteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa điện thoại này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    int ID = phones[PhoneDGV.CurrentCell.RowIndex].ID;
                    int ret = InteractDB.DeleteData(ID);
                    if (ret > 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("Không thể xóa!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ReloadDGV();
            }
        }

        private void PhoneDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

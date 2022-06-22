using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhoneStat
{
    public partial class PhoneList : UserControl
    {
        bool isFiltered = false;
        List<Phone> phones;

        public PhoneList()
        {
            InitializeComponent();
            phones = InteractDB.GetData();
        }

        public PhoneList(string search)
        {
            InitializeComponent();
            phones = InteractDB.SearchPhone(search);
        }
        private void ComboBoxInit()
        {
            // combobox values
            HashSet<string> brands = new HashSet<string>();
            string[] resolutions = { "HD", "HD+", "FullHD", "FullHD+", "QHD"};
            HashSet<string> refreshRates = new HashSet<string>();
            string[] RAMs = { "2GB", "3GB", "4GB", "6GB", "8GB", "12GB"};
            string[] ROMs = { "8GB", "16GB", "32GB", "64GB", "128GB", "256GB", "512GB" };
            foreach (Phone phone in phones)
            {
                brands.Add(phone.brand);
                refreshRates.Add(phone.refreshRate);
            }
            //Brand
            BrandCB.Items.Add("Hãng");
            foreach (string brand in brands)
            {
                BrandCB.Items.Add(brand);
            }
            BrandCB.SelectedIndex = 0;
            //Resolution
            ResolutionCB.Items.Add("Độ phân giải");
            ResolutionCB.Items.AddRange(resolutions);
            ResolutionCB.SelectedIndex = 0;
            //RefreshRate
            RefreshRateCB.Items.Add("Tần số quét");
            foreach (string refreshRate in refreshRates)
            {
                RefreshRateCB.Items.Add(refreshRate);
            }
            RefreshRateCB.SelectedIndex = 0;
            //RAM
            RAMCB.Items.Add("Dung lượng RAM");
            RAMCB.Items.AddRange(RAMs);
            RAMCB.SelectedIndex = 0;
            //ROM
            ROMCB.Items.Add("Bộ nhớ trong");
            ROMCB.Items.AddRange(ROMs);
            ROMCB.SelectedIndex = 0;
        }
        private void PhoneList_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            
            foreach (Phone phone in phones)
            {
                PhoneItem phoneItem = new PhoneItem(phone);
                PhoneListPanel.Controls.Add(phoneItem);
            }
            ComboBoxInit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FilterHandle() 
        {
            // truyền filter vào model
            Phone temp = new Phone();
            if (BrandCB.SelectedIndex > 0)
            {
                temp.brand = BrandCB.Text;
            }
            if (ResolutionCB.SelectedIndex > 0)
            {
                temp.resolution = "(" + ResolutionCB.Text + ")";
            }
            if (RefreshRateCB.SelectedIndex > 0)
            {
                temp.refreshRate = RefreshRateCB.Text;
            }
            if (RAMCB.SelectedIndex > 0)
            {
                temp.RAM = RAMCB.Text;
            }
            if (ROMCB.SelectedIndex > 0)
            {
                temp.ROM = ROMCB.Text;
            }
            // clear PhoneListPanel
            PhoneListPanel.Controls.Clear();
            // filter phone list từ db
            phones.Clear();
            phones = InteractDB.Filter(temp);

            // thêm phone items
            foreach (Phone phone in phones)
            {
                PhoneItem phoneItem = new PhoneItem(phone);

                PhoneListPanel.Controls.Add(phoneItem);
            }
        }
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            if(BrandCB.SelectedIndex == 0 && ResolutionCB.SelectedIndex == 0 && RefreshRateCB.SelectedIndex == 0 
                && RAMCB.SelectedIndex == 0 && ROMCB.SelectedIndex == 0)
            {
                if(isFiltered == false)
                {
                    return;
                }
                else
                {
                    FilterHandle();
                    isFiltered = false;
                    return;
                }
            }
            FilterHandle();
            isFiltered = true;

            
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BrandCB.SelectedIndex = 0;
            ResolutionCB.SelectedIndex = 0;
            RefreshRateCB.SelectedIndex = 0;
            RAMCB.SelectedIndex = 0;
            ROMCB.SelectedIndex = 0;
        }
    }
}

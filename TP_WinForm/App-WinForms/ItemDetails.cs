using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace App_WinForms
{
    public partial class ItemDetails : Form
    {
        private List<string> imagesUrls = new List<string>();
        int UrlIndex = 0;
        public ItemDetails()
        {
            InitializeComponent();
        }
        public ItemDetails(Item item, ref List<Domain.Image> imagesList)
        {
            InitializeComponent();
            this.textBoxID.Text = item.Id.ToString();
            this.textBoxCode.Text = item.Code;
            this.textBoxName.Text = item.Name;
            this.textBoxDescription.Text = item.Description;
            this.textBoxBrand.Text = item.Brand.ToString();
            this.textBoxCategory.Text = item.Category.ToString();
            this.textBoxPrice.Text = item.Price.ToString();
            
            foreach (Domain.Image image in imagesList)
            {
                if(image.IdItem == item.Id)
                {
                    imagesUrls.Add(image.Url);
                }
            }
            if (imagesUrls.Count > 0) {
                this.pictureBoxImages.Load(imagesUrls[UrlIndex]);
            }
            //
        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonNextImage_Click(object sender, EventArgs e)
        {
            UrlIndex++;
            if(imagesUrls.Count == UrlIndex) {
                UrlIndex = 0;
            }
            this.pictureBoxImages.Load(imagesUrls[UrlIndex]);
        }
    }
}

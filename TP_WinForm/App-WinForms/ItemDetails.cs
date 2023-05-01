using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;

namespace App_WinForms
{
    public partial class ItemDetails : Form
    {
        private List<string> imagesUrls = new List<string>();
        int UrlIndex = 0;
        Item aux = new Item();
        public ItemDetails()
        {
            InitializeComponent();
        }
        public ItemDetails(Item item)
        {
            InitializeComponent();
            this.textBoxID.Text = item.Id.ToString();
            this.textBoxCode.Text = item.Code;
            this.textBoxName.Text = item.Name;
            this.textBoxDescription.Text = item.Description;
            this.textBoxBrand.Text = item.Brand.ToString();
            this.textBoxCategory.Text = item.Category.ToString();
            this.textBoxPrice.Text = item.Price.ToString();
            
            foreach (Domain.Image image in item.Images)
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

        private void buttonPreviousImage_Click(object sender, EventArgs e)
        {
            UrlIndex--;
            if (UrlIndex < 0)
            {
                UrlIndex = imagesUrls.Count - 1;
            }
            this.pictureBoxImages.Load(imagesUrls[UrlIndex]);
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonApplyItem_Click(object sender, EventArgs e)
        {
            // No se como mostrar el Id automaticamente
            aux.Id = ItemBusiness.List().Count +1;
            aux.Code = textBoxCode.Text;
            aux.Name = textBoxName.Text;
            aux.Description = textBoxDescription.Text;
            Money price = new Money(decimal.Parse(textBoxPrice.Text));
            aux.Price = price;
            aux.Brand = new Brand();
            aux.Category = new Category();
            aux.Brand.Description = textBoxBrand.Text;
            aux.Category.Description = textBoxCategory.Text;
            Domain.Image img = new Domain.Image();
            aux.Images = new List<Domain.Image>();
            aux.Images.Add(img); 
            // itemlist.Add(aux); No se como hacer para agregar el item, necesito que conozca a itemlist
        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {
           
            ItemBusiness.Add(aux);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business;
using Domain;

namespace App_WinForms
{
    public partial class ItemDetails : Form
    {
        private List<string> imagesUrls = new List<string>();
        int UrlIndex = 0;
        public delegate void UpdateItemList();
        public UpdateItemList updateItemList;
        public ItemDetails()
        {
            InitializeComponent();
            updateItemList += TPWinforms.UpdateItemList;
        }
        public ItemDetails(Item item) : this()
        {
            this.textBoxID.Text = item.Id.ToString();
            this.textBoxCode.Text = item.Code;
            this.textBoxName.Text = item.Name;
            this.textBoxDescription.Text = item.Description;
            this.textBoxBrand.Text = item.Brand.ToString();
            this.textBoxCategory.Text = item.Category.ToString();
            this.textBoxPrice.Text = item.Price.ToString();
            
            foreach (Image image in item.Images)
            {
                if(image.IdItem == item.Id)
                {
                    imagesUrls.Add(image.Url);
                }
            }
            if (imagesUrls.Count > 0) {
                this.pictureBoxImages.Load(imagesUrls[UrlIndex]);
            }
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
            Item aux = new Item();
            aux.Id = ItemBusiness.List().Count + 1;
            aux.Code = textBoxCode.Text;
            aux.Name = textBoxName.Text;
            aux.Description = textBoxDescription.Text;
            Money price = decimal.Parse(textBoxPrice.Text);
            aux.Price = price;
            aux.Brand = new Brand() 
            {
                Description = textBoxBrand.Text
            };
            aux.Category = new Category
            {
                Description = textBoxCategory.Text
            };
            aux.Images = new List<Image>
            {
                new Image()
            };

            ItemBusiness.Add(aux);
            updateItemList.Invoke();
        }
    }
}

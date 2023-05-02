﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Proxies;
using System.Windows.Forms;
using Business;
using Domain;

namespace App_WinForms
{
    public partial class ItemDetails : Form
    {
        private List<Image> images;
        private List<Category> categories;
        private List<Brand> brands;
        int UrlIndex = 0;
        public delegate void UpdateItemList();
        public UpdateItemList updateItemList;
        



        public ItemDetails(List<Category> categories, List<Brand> brands, Item item = null)
        {
            InitializeComponent();
            if (item != null)
            {
                this.textBoxID.Text = item.Id.ToString();
                this.textBoxCode.Text = item.Code;
                this.textBoxName.Text = item.Name;
                this.textBoxDescription.Text = item.Description;
                this.textBoxPrice.Text = item.Price.ToString();
                images = item.Images;
               
                if (images.Count > 0)
                {
                    LoadImage(images[UrlIndex].Url);
                }
            }
            this.categories = categories;
            this.brands = brands;
            foreach (var category in this.categories)
            {
                cbCategories.Items.Add(category.Description);
            }
            if (item != null)
            {
                cbCategories.SelectedIndex = cbCategories.FindStringExact(item.Category.ToString());
            }
                foreach (var brand in this.brands)
                {
                    cbBrands.Items.Add(brand.Description);
                }
            if (item != null)
            {
                cbBrands.SelectedIndex = cbBrands.FindStringExact(item.Brand.ToString());
                updateItemList += TPWinforms.UpdateItemList;
            }
        }
        private void LoadImage(string url)
        {
            try
            {
                this.pictureBoxImages.Load(url);
            }
            catch
            {
                this.pictureBoxImages.Load("..\\..\\Resources\\ErrorImage.png");
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
            if(images.Count == UrlIndex) {
                UrlIndex = 0;
            }
            LoadImage(images[UrlIndex].Url);
        }

        private void buttonPreviousImage_Click(object sender, EventArgs e)
        {
            UrlIndex--;
            if (UrlIndex < 0)
            {
                UrlIndex = images.Count - 1;
            }
            LoadImage(images[UrlIndex].Url);
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonApplyItem_Click(object sender, EventArgs e)
        {
            // No se como mostrar el Id automaticamente
            Item aux = new Item();
            aux.Id = ItemBusiness.GetMaxID() + 1;
            aux.Code = textBoxCode.Text;
            aux.Name = textBoxName.Text;
            aux.Description = textBoxDescription.Text;
            //TODO: Ver como solucionar esto con la clase money y que se cargue bien en la base de datos
            //Money price = decimal.Parse(textBoxPrice.Text);
            //aux.Price = price;
            aux.Brand = brands[cbBrands.SelectedIndex];
            aux.Category = categories[cbCategories.SelectedIndex];
            aux.Images = images;
            if(ItemBusiness.Add(aux) == 1) {
                textBoxID.Text = aux.Id.ToString();
            }
            
            updateItemList.Invoke();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}

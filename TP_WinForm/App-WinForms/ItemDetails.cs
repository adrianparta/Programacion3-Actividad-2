using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Configuration;
using System.Reflection;
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
        private Item item;
        int UrlIndex = 0;
        public delegate void UpdateItemList();
        public UpdateItemList updateItemList;
        private const string NotAssigned = "Sin Asignar";

        public ItemDetails(List<Category> categories, List<Brand> brands, Item item = null)
        {
            InitializeComponent();
            this.item = item;
            if (item != null)
            {
                this.buttonApplyItem.Visible = true;
                this.textBoxID.Text = item.Id.ToString();
                this.textBoxCode.Text = item.Code;
                this.textBoxName.Text = item.Name;
                this.textBoxDescription.Text = item.Description;
                this.textBoxPrice.Text = item.Price.ToString();
                images = item.Images;

                if (images.Count > 0)
                {
                    string imageUrl = images[UrlIndex].Url;
                    LoadImage(imageUrl);
                    textBoxImageUrl.Text = imageUrl;
                }
            }
            else
            {
                images = new List<Image>();
                this.buttonAddItem.Visible = true;
                this.textBoxID.Text = (ItemBusiness.GetMaxID() + 1).ToString();
            }
            this.categories = categories;
            this.brands = brands;
            cbCategories.Items.Add(NotAssigned);
            cbBrands.Items.Add(NotAssigned);
            foreach (var category in this.categories)
            {
                cbCategories.Items.Add(category);
            }
            if (item != null)
            {
                int findCategory = cbCategories.FindStringExact(item.Category.ToString());
                if (findCategory > 0)
                {
                    cbCategories.SelectedIndex = findCategory;
                }
                else
                {
                    cbCategories.SelectedIndex = 0;
                }
            }
            foreach (var brand in this.brands)
            {
                cbBrands.Items.Add(brand);
            }
            if (item != null)
            {
                int findBrand = cbBrands.FindStringExact(item.Brand.ToString());
                if(findBrand > 0)
                {
                    cbBrands.SelectedIndex = findBrand;
                }
                else
                {
                    cbBrands.SelectedIndex = 0;
                }
            }
            updateItemList += TPWinforms.UpdateItemList;
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

        private void buttonNextImage_Click(object sender, EventArgs e)
        {
            UrlIndex++;
            if (images.Count == UrlIndex)
            {
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

        private void buttonApplyItem_Click(object sender, EventArgs e)
        {
            Money newPrice = textBoxPrice.Text;
            if(newPrice > 0)
            {
                Item aux = new Item
                {
                    Id = Convert.ToInt32(textBoxID.Text),
                    Code = textBoxCode.Text,
                    Name = textBoxName.Text,
                    Description = textBoxDescription.Text,
                    Price = textBoxPrice.Text,
                    Brand = cbBrands.SelectedItem is Brand ? (Brand)cbBrands.SelectedItem : new Brand() { Id = -1 },
                    Category = cbCategories.SelectedItem is Category ? (Category)cbCategories.SelectedItem : new Category() { Id = -1 },
                    Images = images
                };
                if (ItemBusiness.Update(item, aux) == 1)
                {
                    MessageBox.Show("Se ha actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se han aplicado actualizaciones");
                }
            }
            else
            {
                MessageBox.Show("No ingresó un precio válido");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.buttonAddItem.Visible = false;
            this.buttonApplyItem.Visible = false;
            this.Close();
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            // Evita que se ingresen letras en el text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                if(!(((TextBox)sender).Text.Contains(",") && e.KeyChar == ','))
                {
                    e.Handled = true;
                }
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            Item aux = new Item
            {
                Id = Convert.ToInt32(textBoxID.Text),
                Code = textBoxCode.Text,
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
                Price = string.IsNullOrWhiteSpace(textBoxPrice.Text) ? "0" : textBoxPrice.Text,
                Brand = cbBrands.SelectedItem is Brand ? (Brand)cbBrands.SelectedItem : new Brand() { Id = -1 },
                Category = cbCategories.SelectedItem is Category ? (Category)cbCategories.SelectedItem : new Category() { Id = -1 },
                Images = images
            };
            if (ItemBusiness.Add(aux) == 1)
            {
                MessageBox.Show("Se ha agregado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el item");
            }
        }

        private void ItemDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateItemList.Invoke();
        }
    }
}

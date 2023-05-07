using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Configuration;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Proxies;
using System.Windows.Forms;
using Business;
using Domain;
using static System.Windows.Forms.AxHost;

namespace App_WinForms
{
    public partial class ItemDetails : Form
    {
        private List<Image> images;
        private List<Category> categories;
        private List<Brand> brands;
        private Item item;
        private bool modifyUrl;
        private int UrlIndex = 0;
        public delegate void UpdateItemList();
        public UpdateItemList updateItemList;
        private const string NotAssigned = "Sin Asignar";

        public ItemDetails(List<Category> categories, List<Brand> brands, Item item = null)
        {
            InitializeComponent();
            this.item = item;
            this.categories = categories;
            this.brands = brands;
            cbCategories.Items.Add(NotAssigned);
            cbBrands.Items.Add(NotAssigned);
            buttonApplyUrl.Enabled = false;
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
                    LoadImage();
                }
                else
                {
                    NextPreviousButtonState(false);
                    buttonEditUrl.Enabled=false;
                    buttonPreviousImage.Enabled= false;
                }
            }
            else
            {
                images = new List<Image>();
                cbCategories.SelectedIndex = 0;
                cbBrands.SelectedIndex = 0;
                this.buttonAddItem.Visible = true;
                this.textBoxID.Visible = false;
                this.labelID.Visible = false;
            }
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
        private void LoadImage()
        {
            try
            {
                textBoxImageUrl.Text = images[UrlIndex].Url;
                
                this.pictureBoxImages.Load(images[UrlIndex].Url);
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
            LoadImage();
        }

        private void buttonPreviousImage_Click(object sender, EventArgs e)
        {
            UrlIndex--;
            if (UrlIndex < 0)
            {
                UrlIndex = images.Count - 1;
            }
            LoadImage();
        }

        private void buttonApplyItem_Click(object sender, EventArgs e)
        {
            Money newPrice = textBoxPrice.Text;
            if(newPrice > 0)
            {
                Item aux = new Item
                {
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
            if(AtLeastOneField())
            {
                Item aux = new Item
                {
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
            else
            {
                MessageBox.Show("Ingrese al menos un campo para tener referencia sobre que agrega");
            }
        }
        private bool AtLeastOneField()
        {
            string verify = "";
            verify += textBoxCode.Text;
            verify += textBoxName.Text;
            verify += textBoxDescription.Text;
            verify += textBoxPrice.Text;
            verify += cbBrands.SelectedItem is Brand ? cbBrands.SelectedItem.ToString() : "";
            verify += cbCategories.SelectedItem is Category ? cbCategories.SelectedItem.ToString() : "";
            verify += images.Count == 0 ? "" : images.Count.ToString();

            return !string.IsNullOrWhiteSpace(verify);
        }
        private void ItemDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateItemList.Invoke();
        }

        private void buttonAddUrl_Click(object sender, EventArgs e)
        {
            NextPreviousButtonState(false);
            ImageButtonsState(false);
            modifyUrl = false;
            textBoxImageUrl.Text = string.Empty;
        }
        private void buttonEditUrl_Click(object sender, EventArgs e)
        {
            NextPreviousButtonState(false);
            ImageButtonsState(false);
            modifyUrl = true;
        }

        private void buttonApplyUrl_Click(object sender, EventArgs e)
        {
            ImageButtonsState(true);
            NextPreviousButtonState(true);
            if (modifyUrl)
            {
                if (textBoxImageUrl.Text == images[UrlIndex].Url)
                {
                    return;
                }
                if (textBoxImageUrl.Text == "")
                {
                    MessageBox.Show("No se puede dejar el campo vacío, si desea eliminar la imagen, haga click en el botón correspondiente");
                    textBoxImageUrl.Text = images[UrlIndex].Url;
                    return;
                }
                if (MessageBox.Show($"¿Seguro desea modificar esta url?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    textBoxImageUrl.Text = images[UrlIndex].Url;
                    textBoxImageUrl.ReadOnly = true;
                    //buttonApplyUrl.Enabled = false;
                    return;
                }
                images[UrlIndex].Url = textBoxImageUrl.Text;
                //buttonEditUrl.Enabled = true;

            }
            else if (textBoxImageUrl.Text != "")
            {
                Image image = new Image();
                image.Url = textBoxImageUrl.Text;
                images.Add(image);
                UrlIndex = images.Count - 1;
                NextPreviousButtonState(true);
                //buttonDeleteUrl.Enabled = true;
            }
            LoadImage();
        }

        private void buttonDeleteUrl_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"¿Seguro desea eliminar esta imagen?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                images.RemoveAt(UrlIndex);
            }
            if (images.Count > 0)
            {
                LoadImage();
                return;
            }

            textBoxImageUrl.Text = string.Empty;
            pictureBoxImages.Image = null;
            NextPreviousButtonState(false);
            buttonDeleteUrl.Enabled = false;
            buttonEditUrl.Enabled = false;
        }
        private void NextPreviousButtonState(bool state)
        {
            buttonNextImage.Enabled = state;
            buttonPreviousImage.Enabled = state;
        }
        private void ImageButtonsState(bool state)
        {
            buttonApplyUrl.Enabled = !state;
            textBoxImageUrl.ReadOnly = state;
            buttonEditUrl.Enabled = state;
            buttonDeleteUrl.Enabled = state;
            buttonAddUrl.Enabled = state;
        }
    }
}

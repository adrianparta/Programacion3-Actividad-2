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




        public ItemDetails(List<Category> categories, List<Brand> brands, Item item = null)
        {
            InitializeComponent();
            this.item = item;
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
                this.buttonAddItem.Visible = true;
                this.textBoxID.Text = (ItemBusiness.GetMaxID() + 1).ToString();
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

            // TODO: 
            Item aux = new Item();
                aux.Id = Convert.ToInt32(textBoxID.Text);
                aux.Code = textBoxCode.Text;
                aux.Name = textBoxName.Text;
                aux.Description = textBoxDescription.Text;
                aux.Price = textBoxPrice.Text;
                aux.Brand = brands[cbBrands.SelectedIndex];
                aux.Category = categories[cbCategories.SelectedIndex];
                aux.Images = images;
           
            if (ItemBusiness.Update(item, aux) == 1)
            {
                MessageBox.Show("Se ha actualizado correctamente");
            }
            else
            {
                MessageBox.Show("No se han aplicado actualizaciones");
            }
            updateItemList.Invoke();
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
            Item aux = new Item();
            aux.Id = Convert.ToInt32(textBoxID.Text);
            aux.Code = textBoxCode.Text;
            aux.Name = textBoxName.Text;
            aux.Description = textBoxDescription.Text;
            aux.Price = textBoxPrice.Text;
            aux.Brand = brands[cbBrands.SelectedIndex];
            aux.Category = categories[cbCategories.SelectedIndex];
            aux.Images = images;

            if (ItemBusiness.Add(aux) == 1)
            {
                MessageBox.Show("Se ha actualizado correctamente");
            }
            else
            {
                MessageBox.Show("No se han aplicado actualizaciones");
            }
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

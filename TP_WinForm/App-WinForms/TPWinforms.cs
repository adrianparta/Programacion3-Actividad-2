using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain;
using Business;
using System.Linq;
using static App_WinForms.ItemDetails;

namespace App_WinForms
{
    public partial class TPWinforms : Form
    {
        private static List<Item> itemList;
        private static List<Category> categoryList;
        private static List<Brand> brandList;
        private const string WITHOUTFILTER = "Todas";
        private const string NotAssigned = "Sin Asignar";

        public TPWinforms()
        {
            InitializeComponent();
        }

        private void TPWinforms_Load(object sender, EventArgs e)
        {
            categoryList = CategoryBusiness.List();
            brandList = BrandBusiness.List();
            UpdateItemList();
            UpdateCategoryList();
            UpdateBrandList();
        }

        private void buttonViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                ItemDetails itemDetails = new ItemDetails(categoryList, brandList, (Item)dgvItems.SelectedRows[0].DataBoundItem);
                itemDetails.Text = "Detalles del artículo";
                itemDetails.ShowDialog();

            }
            else
            {
                MessageBox.Show("No hay items en la lista");
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            ItemDetails itemDetails = new ItemDetails(categoryList, brandList);
            itemDetails.Text = "Añadir nuevo artículo";
            itemDetails.ShowDialog();
        }

        private void buttonBrandWindow_Click(object sender, EventArgs e)
        {
            BrandList brandListForm = new BrandList(brandList);
            brandListForm.ShowDialog();
        }

        private void buttonCategoryWindow_Click(object sender, EventArgs e)
        {
            CategoryList categoryListForm = new CategoryList(categoryList);
            categoryListForm.ShowDialog();
        }

        private void FilterEvent(object sender, EventArgs e)
        {
            var categoryFilter = cbCategory.SelectedItem;
            var brandFilter = cbBrand.SelectedItem;
            List<Item> itemFilteredList = itemList;
            if (categoryFilter != null)
            {
                if (categoryFilter.ToString() != WITHOUTFILTER)
                {
                    itemFilteredList = itemFilteredList.Where(x => categoryFilter.ToString() == x.Category.ToString()).ToList();
                }
            }
            if (brandFilter != null)
            {
                if (brandFilter.ToString() != WITHOUTFILTER)
                {
                    itemFilteredList = itemFilteredList.Where(x => brandFilter.ToString() == x.Brand.ToString()).ToList();
                }
            }
            if (txtNombre.TextLength > 0)
            {
                itemFilteredList = itemFilteredList.Where(x => x.Name.ToLower().Contains(txtNombre.Text.ToLower())).ToList();
            }
            if (txtCode.TextLength > 0)
            {
                itemFilteredList = itemFilteredList.Where(x => x.Code.ToLower().Contains(txtCode.Text.ToLower())).ToList();
            }
            if (txtDescription.TextLength > 0)
            {
                itemFilteredList = itemFilteredList.Where(x => x.Description.ToLower().Contains(txtDescription.Text.ToLower())).ToList();
            }
            if (numPriceMin.Value > 0)
            {
                itemFilteredList = itemFilteredList.Where(x => x.Price >= numPriceMin.Value).ToList();
            }
            if (numPriceMax.Value > 0)
            {
                itemFilteredList = itemFilteredList.Where(x => x.Price <= numPriceMax.Value).ToList();
            }

            dgvItems.DataSource = itemFilteredList;
        }

        private void numPriceMax_KeyUp(object sender, KeyEventArgs e)
        {
            FilterEvent(sender, e);
        }
        public static void UpdateItemList()
        {
            itemList = ItemBusiness.List();
        }
        public static void UpdateCategoryList()
        {
            categoryList = CategoryBusiness.List();
        }
        public static void UpdateBrandList()
        {
            brandList = BrandBusiness.List();
        }
        private void TPWinforms_Activated(object sender, EventArgs e)
        {
            dgvItems.DataSource = itemList;
            cbCategory.Items.Clear();
            cbBrand.Items.Clear();
            cbCategory.Items.Add(WITHOUTFILTER);
            cbBrand.Items.Add(WITHOUTFILTER);
            categoryList.ForEach(x => cbCategory.Items.Add(x));
            brandList.ForEach(x => cbBrand.Items.Add(x));
            cbCategory.Items.Add(NotAssigned);
            cbBrand.Items.Add(NotAssigned);
            cbCategory.SelectedItem = cbCategory.Items[0];
            cbBrand.SelectedItem = cbBrand.Items[0];
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                Item item = (Item)dgvItems.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"Seguro desea eliminar {item.Name}", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (ItemBusiness.Remove(item) > 0)
                    {
                        itemList.Remove(item);
                        dgvItems.DataSource = null;
                        dgvItems.DataSource = itemList;
                        MessageBox.Show("Item eliminado con exito");
                    }
                    else
                    {
                        MessageBox.Show("El item no pudo ser eliminado");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay items en la lista");
            }
        }

        private void numPriceMin_KeyUp(object sender, KeyEventArgs e)
        {
            FilterEvent(sender, e);
        }
    }
}
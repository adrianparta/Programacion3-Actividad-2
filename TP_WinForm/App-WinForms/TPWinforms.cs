using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain;
using Business;
using System.Linq;

namespace App_WinForms
{
    public partial class TPWinforms : Form
    {
        private List<Item> itemList;
        private List<Image> imageList;
        private List<Category> categoryList;
        private List<Brand> brandList;
        private const string WITHOUTFILTER = "Todas";
        private const string NotAssigned = "Sin Asignar";

        public TPWinforms()
        {
            InitializeComponent();
        }

        private void TPWinforms_Load(object sender, EventArgs e)
        {
            itemList = ItemBusiness.List();
            imageList = ImageBusiness.List();
            categoryList = CategoryBusiness.List();
            brandList = BrandBusiness.List();
            dgvItems.DataSource = itemList;
            cbCategory.Items.Add(WITHOUTFILTER);
            cbBrand.Items.Add(WITHOUTFILTER);
            categoryList.ForEach(x => cbCategory.Items.Add(x));
            brandList.ForEach(x => cbBrand.Items.Add(x));
            cbCategory.Items.Add(NotAssigned);
            cbBrand.Items.Add(NotAssigned);
            cbCategory.SelectedItem = cbCategory.Items[0];
            cbBrand.SelectedItem = cbBrand.Items[0];
        }

        private void buttonViewDetails_Click(object sender, EventArgs e)
        {
            ItemDetails itemDetails= new ItemDetails(itemList[dgvItems.SelectedCells[0].RowIndex], ref imageList);
            itemDetails.ShowDialog();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            ItemDetails itemDetails = new ItemDetails();
            itemDetails.ShowDialog();
        }

        private void buttonBrandWindow_Click(object sender, EventArgs e)
        {
            BrandList brandList = new BrandList();
            brandList.ShowDialog();
        }

        private void buttonCategoryWindow_Click(object sender, EventArgs e)
        {
            CategoryList categoryList = new CategoryList();
            categoryList.ShowDialog();
        }

        private void FilterEvent(object sender, EventArgs e)
        {
            var categoryFilter = cbCategory.SelectedItem;
            var brandFilter = cbBrand.SelectedItem;
            List<Item> itemFilteredList = itemList;
            if (categoryFilter != null)
            {
                if(categoryFilter.ToString() != WITHOUTFILTER)
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
                itemFilteredList = itemFilteredList.Where(x => x.Name.Contains(txtNombre.Text)).ToList();
            }
            if (txtCode.TextLength > 0)
            {
                itemFilteredList = itemFilteredList.Where(x => x.Code.Contains(txtCode.Text)).ToList();
            }
            if (txtDescription.TextLength > 0)
            {
                itemFilteredList = itemFilteredList.Where(x => x.Description.Contains(txtDescription.Text)).ToList();
            }
            if (numPriceMin.Value > 0)
            {
                itemFilteredList = itemFilteredList.Where(x => x.Price > numPriceMin.Value).ToList();
            }
            if (numPriceMax.Value > 0)
            {
                itemFilteredList = itemFilteredList.Where(x => x.Price < numPriceMax.Value).ToList();
            }

            dgvItems.DataSource = itemFilteredList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain;
using Business;

namespace App_WinForms
{
    public partial class TPWinforms : Form
    {
        private List<Item> itemList;
        private List<Image> imageList;
        public TPWinforms()
        {
            InitializeComponent();
        }

        private void TPWinforms_Load(object sender, EventArgs e)
        {
            ItemBusiness itemBusiness = new ItemBusiness();
            itemList = itemBusiness.List();
            ImageBusiness imageBusiness = new ImageBusiness();
            imageList= imageBusiness.List();
            dataGridViewItems.DataSource = itemList;
        }

        private void buttonViewDetails_Click(object sender, EventArgs e)
        {
            ItemDetails itemDetails= new ItemDetails(itemList[dataGridViewItems.SelectedCells[0].RowIndex], ref imageList);
            itemDetails.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
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
    }
}

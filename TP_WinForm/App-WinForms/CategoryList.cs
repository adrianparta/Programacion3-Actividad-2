using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static App_WinForms.BrandList;

namespace App_WinForms
{
    public partial class CategoryList : Form
    {
        public delegate void UpdateCategoryList();
        public UpdateCategoryList updateCategoryList;
        public CategoryList()
        {
            InitializeComponent();
        }
        private void CategoryList_Load(object sender, EventArgs e)
        {
            dataGridViewCategories.DataSource = CategoryBusiness.List();
            updateCategoryList += TPWinforms.UpdateCategoryList;
            dataGridViewCategories.Rows[0].Selected = true;
            ModifyTxt(0);
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void CategoryList_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateCategoryList.Invoke();
        }

        private void dataGridViewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyTxt(e.RowIndex);
        }
        private void ModifyTxt(int rowIndex)
        {
            if (rowIndex > 0)
            {
                Category categorySelected = (Category)dataGridViewCategories.Rows[rowIndex].DataBoundItem;
                txtCategoryId.Text = categorySelected.Id.ToString();
                txtCaregoryDescription.Text = categorySelected.Description;
            }
        }
    }
}

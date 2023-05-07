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
        public delegate void UpdateItemList();
        public UpdateItemList updateItemList;
        private Category categorySelected;
        private List<Category> lstCategory;
        public CategoryList()
        {
            InitializeComponent();
        }
        public CategoryList(List<Category> lstCategory) : this()
        {
            this.lstCategory = lstCategory;
        }
        private void CategoryList_Load(object sender, EventArgs e)
        {
            dataGridViewCategories.DataSource = lstCategory;
            updateCategoryList += TPWinforms.UpdateCategoryList;
            updateItemList += TPWinforms.UpdateItemList;
            UpdateDataGridViewCategory();
            if(lstCategory.Count > 0)
            {
                dataGridViewCategories.Rows[0].Selected = true;
                ModifyTxt(0);
            }
        }
        private void CategoryList_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateCategoryList.Invoke();
            updateItemList.Invoke();
        }

        private void dataGridViewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyTxt(e.RowIndex);
        }
        private void ModifyTxt(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                categorySelected = (Category)dataGridViewCategories.Rows[rowIndex].DataBoundItem;
                if(categorySelected != null)
                {
                    txtCategoryId.Text = categorySelected.Id.ToString();
                    txtCaregoryDescription.Text = categorySelected.Description;
                }
            }
        }
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCaregoryNew.Text))
            {
                Category categoryNew = new Category() { Description = txtCaregoryNew.Text };
                int idNew = CategoryBusiness.Add(categoryNew);
                if (idNew > 0)
                {
                    categoryNew.Id = idNew;
                    lstCategory.Add(categoryNew);
                    UpdateDataGridViewCategory();
                    MessageBox.Show("Categoría agregada con exito!");
                }
                else
                {
                    MessageBox.Show("Categoria no pudo ser agregada");
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar una descripcion antes de agregar");
            }
        }

        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            if(categorySelected != null)
            {
                if(!string.IsNullOrEmpty (txtCaregoryDescription.Text))
                {
                    if(categorySelected.Description != txtCaregoryDescription.Text)
                    {
                        if(CategoryBusiness.Update(new Category() 
                        { 
                            Id = categorySelected.Id, 
                            Description = txtCaregoryDescription.Text
                        }) > 0)
                        {
                            int index = lstCategory.FindIndex(x => x.Id == categorySelected.Id);
                            lstCategory[index].Description = txtCaregoryDescription.Text;
                            UpdateDataGridViewCategory();
                            MessageBox.Show("Categoria actualizada con exito");
                        }
                        else
                        {
                            MessageBox.Show("Categoria no pudo ser actualizada");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay nada que actualizar!");
                    }
                }
                else
                {
                    MessageBox.Show("Debes ingresar una descripcion antes de actualizar");
                }
            }
            else
            {
                MessageBox.Show("No hay categoría seleccionada");
            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if(categorySelected != null)
            {
                if (MessageBox.Show($"Seguro desea eliminar la categoría {categorySelected}", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if(CategoryBusiness.Remove(categorySelected) > 0)
                    {
                        int index = lstCategory.FindIndex(x => x.Id == categorySelected.Id);
                        lstCategory.RemoveAt(index);
                        UpdateDataGridViewCategory();
                        MessageBox.Show("Categoria borrada con exito");
                    }
                    else
                    {
                        MessageBox.Show("Categoria no pudo ser eliminada");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay categoría seleccionada");
            }
        }

        private void UpdateDataGridViewCategory()
        {
            dataGridViewCategories.DataSource = null;
            if(lstCategory.Count == 0)
            {
                dataGridViewCategories.DataSource = new List<Category>() { new Category() {Id = 0, Description = "No hay categorias creadas" } };
                txtCaregoryDescription.Enabled = false;
                buttonDeleteCategory.Enabled = false;
                buttonUpdateCategory.Enabled = false;
            }
            else
            {
                dataGridViewCategories.DataSource = lstCategory;
                txtCaregoryDescription.Enabled = true;
                buttonDeleteCategory.Enabled = true;
                buttonUpdateCategory.Enabled = true;
            }
            dataGridViewCategories.Rows[0].Selected = true;
            ModifyTxt(0);
        }
    }
}

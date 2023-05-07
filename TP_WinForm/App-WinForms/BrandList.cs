using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;
using static App_WinForms.BrandList;
using static App_WinForms.ItemDetails;

namespace App_WinForms
{
    public partial class BrandList : Form
    {
        public delegate void UpdateBrandList();
        public UpdateBrandList updateBrandList;
        public delegate void UpdateItemList();
        public UpdateItemList updateItemList;
        private Brand brandSelected;
        private List<Brand> lstBrand;
        public BrandList()
        {
            InitializeComponent();
        }
        public BrandList(List<Brand> lstBrand) : this()
        {
            this.lstBrand = lstBrand;
        }

        private void BrandList_Load(object sender, EventArgs e)
        {
            dataGridViewBrands.DataSource = lstBrand;
            updateBrandList += TPWinforms.UpdateBrandList;
            updateItemList += TPWinforms.UpdateItemList;
            UpdateDataGridViewBrand();
            if (lstBrand.Count > 0)
            {
                dataGridViewBrands.Rows[0].Selected = true;
                ModifyTxt(0);
            }
        }

        private void BrandList_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateBrandList.Invoke();
            updateItemList.Invoke();
        }

        private void dataGridViewBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyTxt(e.RowIndex);
        }
        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtBrandNew.Text))
            {
                Brand BrandNew = new Brand() { Description = txtBrandNew.Text };
                int idNew = BrandBusiness.Add(BrandNew);
                if (idNew > 0)
                {
                    BrandNew.Id = idNew;
                    lstBrand.Add(BrandNew);
                    UpdateDataGridViewBrand();
                    MessageBox.Show("Marca agregada con exito!");
                }
                else
                {
                    MessageBox.Show("Marca no pudo ser agregada");
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar una descripcion antes de agregar");
            }
        }

        private void buttonDeleteBrand_Click(object sender, EventArgs e)
        {
            if (brandSelected != null)
            {
                if (MessageBox.Show($"Seguro desea eliminar la marca {brandSelected}", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (BrandBusiness.Remove(brandSelected) > 0)
                    {
                        int index = lstBrand.FindIndex(x => x.Id == brandSelected.Id);
                        lstBrand.RemoveAt(index);
                        UpdateDataGridViewBrand();
                        MessageBox.Show("Marca borrada con exito");
                    }
                    else
                    {
                        MessageBox.Show("Marca no pudo ser eliminada");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay marca seleccionada");
            }
        }

        private void buttonUpdateBrand_Click(object sender, EventArgs e)
        {
            if (brandSelected != null)
            {
                if(!string.IsNullOrEmpty(txtBrandDescription.Text))
                {
                    if (brandSelected.Description != txtBrandDescription.Text)
                    {
                        if (BrandBusiness.Update(new Brand()
                        {
                            Id = brandSelected.Id,
                            Description = txtBrandDescription.Text
                        }) > 0)
                        {
                            int index = lstBrand.FindIndex(x => x.Id == brandSelected.Id);
                            lstBrand[index].Description = txtBrandDescription.Text;
                            UpdateDataGridViewBrand();
                            MessageBox.Show("Marca actualizada con exito");
                        }
                        else
                        {
                            MessageBox.Show("Marca no pudo ser actualizada");
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
                MessageBox.Show("No hay marca seleccionada");
            }
        }
        private void ModifyTxt(int rowIndex)
        {
            if(rowIndex >= 0)
            {
                brandSelected = (Brand)dataGridViewBrands.Rows[rowIndex].DataBoundItem;
                if (brandSelected != null)
                {
                    txtBrandId.Text = brandSelected.Id.ToString();
                    txtBrandDescription.Text = brandSelected.Description;
                }
            }
        }
        private void UpdateDataGridViewBrand()
        {
            dataGridViewBrands.DataSource = null;
            if (lstBrand.Count == 0)
            {
                dataGridViewBrands.DataSource = new List<Brand>() { new Brand() { Id = 0, Description = "No hay Marcas creadas" } };
                txtBrandDescription.Enabled = false;
                buttonDeleteBrand.Enabled = false;
                buttonUpdateBrand.Enabled = false;
            }
            else
            {
                dataGridViewBrands.DataSource = lstBrand;
                txtBrandDescription.Enabled = true;
                buttonDeleteBrand.Enabled = true;
                buttonUpdateBrand.Enabled = true;
            }
            dataGridViewBrands.Rows[0].Selected = true;
            ModifyTxt(0);
        }
    }
}

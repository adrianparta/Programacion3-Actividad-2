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
using static App_WinForms.ItemDetails;

namespace App_WinForms
{
    public partial class BrandList : Form
    {
        public delegate void UpdateBrandList();
        public UpdateBrandList updateBrandList;
        public BrandList()
        {
            InitializeComponent();
        }

        private void BrandList_Load(object sender, EventArgs e)
        {
            dataGridViewBrands.DataSource = BrandBusiness.List();
            updateBrandList += TPWinforms.UpdateBrandList;
            dataGridViewBrands.Rows[0].Selected = true;
            ModifyTxt(0);
        }

        private void BrandList_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateBrandList.Invoke();
        }

        private void dataGridViewBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyTxt(e.RowIndex);
        }
        private void ModifyTxt(int rowIndex)
        {
            if(rowIndex > 0)
            {
                Brand brandSelected = (Brand)dataGridViewBrands.Rows[rowIndex].DataBoundItem;
                txtBrandId.Text = brandSelected.Id.ToString();
                txtBrandDescription.Text = brandSelected.Description;
            }
        }
    }
}

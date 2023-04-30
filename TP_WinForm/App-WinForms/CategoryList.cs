using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_WinForms
{
    public partial class CategoryList : Form
    {
        private CategoryBusiness categoryBusiness;
        public CategoryList()
        {
            InitializeComponent();
            categoryBusiness = new CategoryBusiness();
            dataGridViewCategories.DataSource = categoryBusiness.List();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace App_WinForms
{
    public partial class ItemDetails : Form
    {
        public ItemDetails()
        {
            InitializeComponent();
        }
        public ItemDetails(Item item)
        {
            InitializeComponent();
            this.textBoxID.Text = item.Id.ToString();
            this.textBoxCode.Text = item.Code;
            this.textBoxName.Text = item.Name;
            this.textBoxDescription.Text = item.Description;
            this.textBoxBrand.Text = item.Brand.ToString();
            this.textBoxCategory.Text = item.Category.ToString();
            this.textBoxPrice.Text = item.Price.ToString();
            //this.pictureBoxImages = pictureBoxImages;
        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}

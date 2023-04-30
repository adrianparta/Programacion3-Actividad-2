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

namespace App_WinForms
{
    public partial class BrandList : Form
    {
        public BrandList()
        {
            InitializeComponent();
            dataGridViewBrands.DataSource = BrandBusiness.List();
        }
    }
}

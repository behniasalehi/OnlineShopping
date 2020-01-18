using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.Product.ProductViewModel();
            Ref_form1 = new Form1();
        }
        public ViewModel.Product.ProductViewModel Ref_ProductViewModel { get; set; }
        public Form1 Ref_form1 { get; set; }

        private void Product_Load(object sender, EventArgs e)
        {
            CategoryList.DataSource = Ref_ProductViewModel.SelectCategoryName();
            dgvProduct.DataSource = Ref_ProductViewModel.FillGrid();
        }

        
    }

       
}

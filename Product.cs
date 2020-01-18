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
        public Model.Helper.SPHelper.Product.InsertProduct Ref_InsertProduct { get; set; }
        public List<Model.Helper.SPHelper.Product.InsertProduct> Products { get; set; }
        public Form1 Ref_form1 { get; set; }

        private void Product_Load(object sender, EventArgs e)
        {
            CategoryList.DataSource = Ref_ProductViewModel.SelectCategoryName();
            dgvProduct.DataSource = Ref_ProductViewModel.FillGrid();
        }

        private void BtnBrowseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        #region [- ImageToByteArray -]
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Ref_InsertProduct.Category_Ref = CategoryList.SelectedValue.ToString();
            Ref_InsertProduct.ProductName = txtProductName.Text;
            Ref_InsertProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            Ref_InsertProduct.Quantiy = (int)Counter.Value;
            Ref_InsertProduct.Discount = Convert.ToDecimal(txtDiscount.Text);
            Ref_InsertProduct.ProductImage = ImageToByteArray(pictureBox1.Image);
        }
    }

       
}

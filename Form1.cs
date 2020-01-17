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
    public partial class Form1 : Form
    {
        #region [- ctor -]
        public Form1()
        {
            InitializeComponent();
            ReF_CategoryViewModel = new ViewModel.Category.CategoryViewModel();
            Ref_Category = new Model.Helper.SPHelper.Category.InsertCategory();
            Categories = new List<Model.Helper.SPHelper.Category.InsertCategory>();
        }
        #endregion
       

        public ViewModel.Category.CategoryViewModel ReF_CategoryViewModel { get; set; }
        public Model.Helper.SPHelper.Category.InsertCategory Ref_Category { get; set; }
        public List<Model.Helper.SPHelper.Category.InsertCategory> Categories { get; set; }

        #region [- BtnRefresh_Click -]
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvCategory.DataSource = ReF_CategoryViewModel.FillGrid();
        }
        #endregion

        #region [- BtnSave_Click -]
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Ref_Category.CategoryName = txtCategoryName.Text;
            Ref_Category.Descriptions = txtDescriptions.Text;
            Categories.Add(Ref_Category);
            ReF_CategoryViewModel.Save(Categories);
        } 
        #endregion
    }
}

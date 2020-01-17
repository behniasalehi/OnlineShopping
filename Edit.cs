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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            Ref_CategoryViewModel = new ViewModel.Category.CategoryViewModel();
            Ref_CategoryUpdate = new Model.Helper.SPHelper.Category.UpdateCategory();
            UpdateCategories = new List<Model.Helper.SPHelper.Category.UpdateCategory>();

        }
        #region [- props -]
        public ViewModel.Category.CategoryViewModel Ref_CategoryViewModel { get; set; }
        public Model.Helper.SPHelper.Category.UpdateCategory Ref_CategoryUpdate { get; set; }
        public List<Model.Helper.SPHelper.Category.UpdateCategory> UpdateCategories { get; set; } 
        #endregion
        #region [- BtnSubmitEdit_Click -]
        private void BtnSubmitEdit_Click(object sender, EventArgs e)
        {
            Ref_CategoryUpdate.Id = Convert.ToInt32(txtEditId.Text);
            Ref_CategoryUpdate.CategoryName = txtCategoryNameEdit.Text;
            Ref_CategoryUpdate.Descriptions = txtDescriptionsEdit.Text;
            UpdateCategories.Add(Ref_CategoryUpdate);
            Ref_CategoryViewModel.Edit(UpdateCategories);
            MessageBox.Show("done");
        } 
        #endregion
    }
}

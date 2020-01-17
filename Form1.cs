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
            Ref_Category_Delete = new Model.Helper.SPHelper.Category.DeleteCategory();
            DeleteCategories = new List<Model.Helper.SPHelper.Category.DeleteCategory>();
        }
        #endregion


        #region [- props -]
        public ViewModel.Category.CategoryViewModel ReF_CategoryViewModel { get; set; }
        public Model.Helper.SPHelper.Category.InsertCategory Ref_Category { get; set; }
        public List<Model.Helper.SPHelper.Category.InsertCategory> Categories { get; set; }
        public Edit Ref_Edit { get; set; }
        public Model.Helper.SPHelper.Category.DeleteCategory Ref_Category_Delete { get; set; }
        public List<Model.Helper.SPHelper.Category.DeleteCategory> DeleteCategories { get; set; }
        #endregion

        #region [- BtnRefresh_Click -]
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvCategory.DataSource = ReF_CategoryViewModel.FillGrid();
            btnEdit.Enabled = true;
            btndelete.Enabled = true;
        }
        #endregion

        #region [- BtnSave_Click -]
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Ref_Category.CategoryName = txtCategoryName.Text;
            Ref_Category.Descriptions = txtDescriptions.Text;
            Categories.Add(Ref_Category);
            ReF_CategoryViewModel.Save(Categories);
            Categories.Clear();
        }
        #endregion

        #region [- BtnEdit_Click -]
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategory.Rows.Count != 0)
            {
                Ref_Edit = new Edit();
                Ref_Edit.txtEditId.Text = Convert.ToString(dgvCategory[0, dgvCategory.CurrentRow.Index].Value);
                Ref_Edit.txtCategoryNameEdit.Text = Convert.ToString(dgvCategory[1, dgvCategory.CurrentRow.Index].Value);
                Ref_Edit.txtDescriptionsEdit.Text = Convert.ToString(dgvCategory[2, dgvCategory.CurrentRow.Index].Value);
                Ref_Edit.Show();
            }
        }
        #endregion

        #region [- Btndelete_Click -]
        private void Btndelete_Click(object sender, EventArgs e)
        {
            Ref_Category_Delete.Id = Convert.ToInt32(dgvCategory[0, dgvCategory.CurrentRow.Index].Value);
            DialogResult res = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                DeleteCategories.Add(Ref_Category_Delete);
                ReF_CategoryViewModel.Delete(DeleteCategories);
                MessageBox.Show("deleted");
                dgvCategory.DataSource = ReF_CategoryViewModel.FillGrid();
                DeleteCategories.Clear();
            }
            
        } 
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.ViewModel.Product
{
  public  class ProductViewModel
    {
        #region [- ctor -]
        public ProductViewModel()
        {
            Ref_ProductCrud = new Model.DomainModel.POCO.ProductCrud();
        }
        #endregion
        public Model.DomainModel.POCO.ProductCrud Ref_ProductCrud { get; set; }
        #region [- SelectCategoryName() -]
        public dynamic SelectCategoryName()
        {
            return Ref_ProductCrud.Select();
        } 
        #endregion
    }
}

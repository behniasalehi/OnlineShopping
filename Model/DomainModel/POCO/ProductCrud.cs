using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.DomainModel.POCO
{
   public class ProductCrud
    {
        #region [- ctor -]
        public ProductCrud()
        {

        }
        #endregion
        public List<Helper.SPHelper.Product.SelectCategoryName> Select()
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                List<Helper.SPHelper.Product.SelectCategoryName> list_Category = new List<Helper.SPHelper.Product.SelectCategoryName>();
                try
                {
                    list_Category = context.Database.SqlQuery<Helper.SPHelper.Product.SelectCategoryName>
                        (Model.Helper.SPHelper.Product.ProductSpHelper.Usp_Product_SelectCategoryName).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
                return list_Category;
            }
        }
    }
}

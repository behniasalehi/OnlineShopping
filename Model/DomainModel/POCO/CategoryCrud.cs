using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.DomainModel.POCO
{
    public class CategoryCrud
    {
        #region [- ctor -]
        public CategoryCrud()
        {

        }
        #endregion
        #region [- Select() -]
        public List<Helper.SPHelper.Category.SelectCategory> Select()
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                List<Helper.SPHelper.Category.SelectCategory> list_Category = new List<Helper.SPHelper.Category.SelectCategory>();
                try
                {
                    list_Category = context.Database.SqlQuery<Helper.SPHelper.Category.SelectCategory>
                        (Model.Helper.SPHelper.Category.CategorySpHelper.Usp_Category_Select).ToList();
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

        

      
        #endregion
        #region [- SaveBySp(List<Model.Helper.SPHelper.Category.InsertCategory> listInsertCategory) ]
        public void SaveBySp(List<Model.Helper.SPHelper.Category.InsertCategory> listInsertCategory)
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Model.Helper.SPHelper.Category.CategorySpHelper.Usp_Category_Insert,
                  Model.Helper.SPHelper.Category.CategorySpHelper.SetInsertParameters(listInsertCategory));
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
            }
        } 
        #endregion

    }
}

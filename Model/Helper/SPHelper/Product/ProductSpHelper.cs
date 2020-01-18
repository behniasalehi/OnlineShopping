using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.Helper.SPHelper.Product
{
   public static class ProductSpHelper
    {
        public const string Usp_Product_SelectCategoryName = "Exec dbo.usp_Select_CategoryName";
        public const string Usp_Product_Select = "Exec dbo.usp_Select_Product";
        public const string Usp_Product_Insert = "dbo.usp_Insert_Product @ProductInfo";
        //public const string Usp_Product_SelectCategoryId = "dbo.usp_Select_CategoryId @ProductId";

        #region [-   SetInsertParameters(List<InsertProduct> listInsertProduct) -]
        public static object[] SetInsertParameters(List<InsertProduct> listInsertProduct)
        {
            #region [- SqlParameter -]
            SqlParameter productListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_Insert_Product",
                Value = listInsertProduct.ToDataTable()
            };
            #endregion
            #region [- parameters  -]
            object[] parameters =
               {
                productListParameter
            };
            #endregion
            return parameters;
        }
        #endregion

        //#region [-    SetIdParameters(List<SelectCategoryId> listCategoryId) -]
        //public static object[] SetIdParameters(List<SelectCategoryId> listCategoryId)
        //{
        //    #region [- SqlParameter -]
        //    SqlParameter productIdParameter = new SqlParameter()
        //    {
        //        ParameterName = "@ProductId",
        //        SqlDbType = System.Data.SqlDbType.Structured,
        //        TypeName = "dbo.udt_Select_CategoryId",
        //        Value = listCategoryId.ToDataTable()
        //    };
        //    #endregion
        //    #region [- parameters  -]
        //    object[] parameters =
        //       {
        //        productIdParameter
        //    };
        //    #endregion
        //    return parameters;
        //}
        //#endregion
    }
}

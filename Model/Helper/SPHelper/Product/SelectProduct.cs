﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.Helper.SPHelper.Product
{
   public class SelectProduct
    {
        #region [- ctor -]
        public SelectProduct()
        {

        }
        #endregion
        public int ProductId { get; set; }
        public int Category_Ref { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantiy { get; set; }
        public decimal Discount { get; set; }
        public string ProductName { get; set; }
        public byte[] ProductImage { get; set; }
    }
}
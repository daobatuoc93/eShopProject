using System;
using System.Collections.Generic;
using System.Text;

namespace APPShopProject.DATA.Entity
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }//F:\eShopLearn\eShopProject\APPShopProject.DATA\Entity\ProductInCategory.cs
}

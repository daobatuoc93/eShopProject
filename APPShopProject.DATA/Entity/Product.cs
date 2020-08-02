using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace APPShopProject.DATA.Entity
{
 //   [Table("Products")] 
    public class Product
    {
       
        public int ProductId { get; set; }
        public decimal  Price { get; set; }
        public decimal  OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime Datecreate { get; set; }
//        [Required]
        public string SeoAlias { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
    }
}

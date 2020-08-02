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
       
        public int Id { get; set; }
        public decimal  Price { get; set; }
        public decimal  OriginalPrice { get; set; }
        public int stock { get; set; }
        public int View { get; set; }
        public DateTime Datecreate { get; set; }
//        [Required]
        public string SeoAlias { get; set; }
    }
}

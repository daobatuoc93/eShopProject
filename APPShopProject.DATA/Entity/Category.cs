﻿using APPShopProject.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Text;
namespace APPShopProject.DATA.Entity
{
    public class Category
    {
        public int CategoryId { set; get;  }
        public int SortOrder { set; get; }
        public int IsShowOnHome { set; get; }
        public int? ParentID { set; get; }
        public Status Status { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}

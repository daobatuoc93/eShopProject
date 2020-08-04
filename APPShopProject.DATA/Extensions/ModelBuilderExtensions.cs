using APPShopProject.DATA.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace APPShopProject.DATA.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig
                {
                    Key = "Home title",
                    Value = "This is Home Title! of AddShop"
                },
                new AppConfig
                {
                    Key = "Home Key",
                    Value = "This is Home Key! of AddShop"
                },
                new AppConfig
                {
                    Key = "Home Description",
                    Value = "This is Description Home! of AddShop"
                }
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Name = "Tiếng Việt", IsDefault = true, Id = "Vi-Vn" },
                new Language() { Name = "English", IsDefault = false, Id = "En-Us" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentID = null,
                    SortOrder = 1,
                    Status = Enums.Status.Active,

                },
                new Category
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentID = null,
                    SortOrder = 2,
                    Status = Enums.Status.Active,
                    
                }
                );
            modelBuilder.Entity<CategoryTranslation>().HasData
                (
                  new CategoryTranslation() { 
                      Id = 1, CategoryId = 1, 
                      Name = "Áo nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang women" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en-US", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                 );
                
            
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Datecreate = DateTime.Now,
                    Price = 200000,
                    OriginalPrice = 95000,
                    Stock = 0,
                    ViewCount = 0,                    
                }) ;
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                   { 
                    ProductId = 1,
                    CategoryId = 1
                   }
                );
            modelBuilder.Entity<ProductTranslation>().HasData
                (
                        new ProductTranslation()
                        {
                            Id =1,
                            ProductId = 1,
                            Name = "Áo sơ mi nam",
                            LanguageId = "Vi-vn",
                            SeoAlias= "ao-nam",
                            SeoDescription = "Sản phẩm áo thời trang nam",
                            SeoTitle  = "",
                            Details = "Áo sơ mi nam màu trấng size M"
                        },
                        new ProductTranslation()
                        {
                            Id = 2,
                            ProductId = 1,
                            Name = "Man T-Shirt",
                            LanguageId = "En-Us",
                            SeoAlias="t-shirt",
                            SeoDescription = "T-Shirt product for man",
                            SeoTitle="",
                            Details = "White T-Shirt for man size M"
                        }
                        //new producttranslation()
                        //{
                        //    id = 3,
                        //    name = "áo sơ mi nữ",
                        //    languageid = "vi-vn",
                        //    seoalias= "ao-nu",
                        //    seodescription = "sản phẩm áo thời trang nu",
                        //    seotitle  = "",
                        //    details = "áo sơ mi nu màu trấng size m"
                        //},
                        //new producttranslation()
                        //{
                        //    id = 4,
                        //    name = "women t-shirt",
                        //    languageid = "en-us",
                        //    seoalias="women t-shirt",
                        //    seodescription = "t-shirt product for woman",
                        //    seotitle="",
                        //    details = "white t-shirt for woman size m"
                        //}
                   
                );

        }
    }
}

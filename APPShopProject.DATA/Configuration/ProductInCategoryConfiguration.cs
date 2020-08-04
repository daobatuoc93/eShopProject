using APPShopProject.DATA.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace APPShopProject.DATA.Configuration
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.HasOne(t => t.Product)
                   .WithMany(t => t.ProductInCategories)
                   .HasForeignKey(t => t.ProductId);
            builder.HasOne(t => t.Category)
                   .WithMany(t => t.ProductInCategories)
                   .HasForeignKey(t => t.CategoryId);
        }
    }
}

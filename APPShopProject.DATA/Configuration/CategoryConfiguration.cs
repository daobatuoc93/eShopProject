using APPShopProject.DATA.Entity;
using APPShopProject.DATA.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace APPShopProject.DATA.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category Table");
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}

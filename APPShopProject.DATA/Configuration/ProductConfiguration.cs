﻿using APPShopProject.DATA.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace APPShopProject.DATA.Configuration
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Table of products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Price).IsRequired();//default == true
            builder.Property(v => v.Stock)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(x => x.OriginalPrice).IsRequired();
            builder.Property(s => s.ViewCount)
                .IsRequired()
                .HasDefaultValue(0);
        }
    } 
}

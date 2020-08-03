using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace APPShopProject.DATA.EF
{
    public class APPShopProjectDbContextFactory : IDesignTimeDbContextFactory<APPShopProjectDbContext>
    {
        public APPShopProjectDbContext CreateDbContext(string[] args)
        {
            
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("APPShopProjectDb");

            var optionsBuilder = new DbContextOptionsBuilder<APPShopProjectDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new APPShopProjectDbContext(optionsBuilder.Options);
        }
    }
}

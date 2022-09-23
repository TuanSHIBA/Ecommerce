using Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x=>x.ProductID);
            builder.HasData(new Category() { CateID = 1, CateName = "Rau Củ", Description = "Rau Củ", Levels = 0, Published = true,Parent=null },new Category() { CateID = 2, CateName = "Trái Cây", Description = "Trái Cây", Levels = 0, Published = true ,Parent=null});
        }
    }
}

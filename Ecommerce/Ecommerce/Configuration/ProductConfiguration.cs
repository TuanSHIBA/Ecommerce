using Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(f => f.ProductID);
            builder.Property(f => f.ProductID).ValueGeneratedOnAdd();
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CateId);
            builder.HasData(new Product()
            {
                ProductID = 1,
                ProductName = "Khoai Lang",
                UnitsInStock = 10,
                Active = true,
                Price = 30000,
                CateId = 1
            },
                new Product()
                {
                    ProductID = 2,
                    ProductName = "Rau Muống",
                    UnitsInStock = 10,
                    Active = true,
                    Price = 30000,
                    CateId = 1,
                },
                    new Product() { ProductID = 3, ProductName = "Chanh Dây", UnitsInStock = 10, Active = true, Price = 30000, CateId = 1, },
                    new Product() { ProductID = 4, ProductName = "Bí Đỏ", UnitsInStock = 10, Active = true, Price = 30000, CateId = 1, },
                    new Product() { ProductID = 5, ProductName = "Cà Rốt", UnitsInStock = 10, Active = true, Price = 30000, CateId = 1, },
                    new Product() { ProductID = 6, ProductName = "Cà Chua", UnitsInStock = 10, Active = true, Price = 30000, CateId = 1, },
                    new Product() { ProductID = 7, ProductName = "Dưa Leo", UnitsInStock = 10, Active = true, Price = 30000, CateId = 1, },
                    new Product() { ProductID = 8, ProductName = "Bắp Mỹ", UnitsInStock = 10, Active = true, Price = 30000, CateId = 1, },
                    new Product() { ProductID = 9, ProductName = "Hành Lá", UnitsInStock = 10, Active = true, Price = 30000, CateId = 1, },
                    new Product() { ProductID = 10, ProductName = "Su Su", UnitsInStock = 10, Active = true, Price = 30000, CateId = 1, });
            ;
        }
    }
}

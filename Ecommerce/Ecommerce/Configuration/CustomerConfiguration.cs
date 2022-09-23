using Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasMany(x => x.Orders).WithOne(x => x.Customer).HasForeignKey(x=>x.OrderID);
            builder.HasData(new Customer() {CustomerID =1, FullName = "Khách Hàng 1", Email = "Kh1@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() {CustomerID=2, FullName = "Khách Hàng 2", Email = "Kh2@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() {CustomerID=3, FullName = "Khách Hàng 3", Email = "Kh3@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 4, FullName = "Khách Hàng 4", Email = "Kh4@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 5, FullName = "Khách Hàng 5", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 6, FullName = "Khách Hàng 6", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 7, FullName = "Khách Hàng 7", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 8, FullName = "Khách Hàng 8", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 9, FullName = "Khách Hàng 9", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 10, FullName = "Khách Hàng 10", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID =11, FullName = "Khách Hàng 11", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 12, FullName = "Khách Hàng 12", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 13, FullName = "Khách Hàng 13", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 14, FullName = "Khách Hàng 14", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 15, FullName = "Khách Hàng 15", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 16, FullName = "Khách Hàng 16", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 17, FullName = "Khách Hàng 17", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" },
                new Customer() { CustomerID = 18, FullName = "Khách Hàng 18", Email = "Kh5@email.com", Phone = "000000000", Address = "Đồng Nai", PassWord = "123" }
        );
        }
    }
}

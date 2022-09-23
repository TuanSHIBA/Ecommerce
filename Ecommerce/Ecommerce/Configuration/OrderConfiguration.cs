using Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasMany(key => key.OrderDetails).WithOne(key => key.Order).HasForeignKey(key => key.OrderDetailID);
           // builder.HasOne(key => key.TransactSatatus).WithMany(key => key.Orders).HasForeignKey(x => x.OrderID);
        }
    }
}

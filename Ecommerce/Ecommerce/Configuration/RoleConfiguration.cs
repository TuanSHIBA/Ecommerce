using Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.RoleID);
            builder.Property(f => f.RoleID).ValueGeneratedOnAdd();
            builder.HasMany(x => x.Accounts).WithOne(x => x.Role).HasForeignKey(x => x.AcccountID);
            builder.HasData(new Role(){  RoleID=1 ,RoleName = "Admin", Description = "Administrator" },
                            new Role(){ RoleID =2, RoleName="Staff", Description="Nhân Viên"});
        }
    }
}

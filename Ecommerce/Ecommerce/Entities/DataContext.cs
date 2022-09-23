using Ecommerce.Configuration;
using Microsoft.EntityFrameworkCore;
using Ecommerce.ViewModel;

namespace Ecommerce.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base(options)
        {
        }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer(@"Data Source=DNI-CNTT-PC888;Initial Catalog=Ecommerce ;Trusted_Connection=True");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail>  OrderDetails { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Role>  Roles { get; set; }
        public DbSet<TransactSatatus> TransactSatatus { get; set; }
     
    }
}

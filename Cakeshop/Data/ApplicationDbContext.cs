using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Cakeshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Cakeshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cake>Cakes { get; set; }
        public DbSet<ShoppingCartItem>ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetial> OrdersDetials { get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Cake>()
                .Property(c => c.Price)
                .HasColumnType("decimal(18,2)");
            builder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasColumnType("decimal(18,2)");
            builder.Entity<OrderDetial>()
                .Property(od => od.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}

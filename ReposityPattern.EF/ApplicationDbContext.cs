using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core;

namespace RepositoryPattern.EF
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CaretItem> CaretItems { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PublishingCompany> PublishingCompanies { get; set; }
        public DbSet<ShoppingSession> ShoppingSessions { get; set; }
        public DbSet<Wharehouse> Wharehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new AuthorConfig().Configure(builder.Entity<Author>());
            new BookConfig().Configure(builder.Entity<Book>());
            new PulishingCompanyConfig().Configure(builder.Entity<PublishingCompany>());
            new WharehouseConfig().Configure(builder.Entity<Wharehouse>());
            new CaretItemConfig().Configure(builder.Entity<CaretItem>());
            new DiscountConfig().Configure(builder.Entity<Discount>());
            new OrderDetailConfig().Configure(builder.Entity<OrderDetail>());
            new OrderItemConfig().Configure(builder.Entity<OrderItem>());
            new PaymentConfig().Configure(builder.Entity<Payment>());
            new ShoppingSessionConfig().Configure(builder.Entity<ShoppingSession>());
            builder.MapRelationships();


            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}

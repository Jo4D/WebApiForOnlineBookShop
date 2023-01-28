using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core;

namespace RepositoryPattern.EF
{
    public static class RelationShipMapper
    {
        public static void MapRelationships(this ModelBuilder builder)
        {
            builder.Entity<Book>()
                  .HasOne(a => a.Author)
                  .WithMany(b => b.Books)
                  .HasForeignKey(a => a.AuthorId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Book>()
                .HasOne(p => p.PublishingCompany)
                .WithMany(b => b.Books)
                .HasForeignKey(p => p.PublishingCompanyId).OnDelete(DeleteBehavior.ClientSetNull);
                
                ;

            builder.Entity<Book>()
                .HasOne(w => w.Wharehouse)
                .WithMany(b => b.Books)
                .HasForeignKey(w => w.WharehouseId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Book>()
                .HasOne(d => d.Discount)
                .WithMany(b => b.Books)
                .HasForeignKey(d => d.DiscountId).OnDelete(DeleteBehavior.ClientSetNull);


            builder.Entity<ApplicationUser>()
                .HasOne(s => s.ShoppingSession)
                .WithOne(u => u.User)
                .HasForeignKey<ShoppingSession>(s => s.UserId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<CaretItem>()
                .HasOne(c => c.ShoppingSession)
                .WithMany(c => c.CaretItems)
                .HasForeignKey(c => c.ShoppingSessionId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<CaretItem>()
            .HasOne(b => b.Book)
            .WithOne(c => c.CaretItem)
                .HasForeignKey<CaretItem>(b => b.BookId).OnDelete(DeleteBehavior.ClientSetNull);


            builder.Entity<Book>()
              .HasOne(o => o.OrderItem)
              .WithOne(b => b.Book)
              .HasForeignKey<OrderItem>(b => b.BookId).OnDelete(DeleteBehavior.ClientSetNull);


            builder.Entity<OrderDetail>()
                .HasOne(u => u.User)
            .WithOne(o => o.OrderDetail)
                .HasForeignKey<OrderDetail>(u => u.UserId).OnDelete(DeleteBehavior.ClientSetNull);



            builder.Entity<OrderItem>()
                .HasOne(o => o.OrderDetail)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(o => o.OrderDetailId).OnDelete(DeleteBehavior.ClientSetNull);


            builder.Entity<OrderDetail>()
                .HasOne(p => p.Payment)
            .WithOne(o => o.OrderDetail)
                .HasForeignKey<OrderDetail>(o => new { o.PaymentId, o.OrderCode }).OnDelete(DeleteBehavior.ClientSetNull);


        }
    }
}


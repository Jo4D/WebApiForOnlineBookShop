using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class OrderItemConfig:IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable(nameof(OrderItem));
            builder.HasKey(i => i.OrderItemId);
            builder.Property(i => i.OrderItemId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(c => c.CreatedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.ModifiedAt);
            builder.Property(b => b.BookId);
            builder.Property(o => o.OrderItemId);

        }
    }
}

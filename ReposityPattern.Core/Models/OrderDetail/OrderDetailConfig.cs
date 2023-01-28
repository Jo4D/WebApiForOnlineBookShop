using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class OrderDetailConfig:IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable(nameof(OrderDetail));
            builder.HasKey(i => i.OrderDetailId);
            builder.Property(i => i.OrderDetailId).IsRequired().ValueGeneratedNever();
            builder.Property(t => t.TotalPrice).IsRequired();
            builder.Property(c => c.CreatedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.ModifiedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
            builder.Property(p => p.PaymentId);
            builder.Property(u => u.UserId);
            builder.Property(o => o.OrderCode);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class PaymentConfig:IEntityTypeConfiguration<Payment>
    {

        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable(nameof(Payment));
            builder.HasKey(p => new { p.PaymentId, p.Ordercode });
            builder.Property(a => a.Amount).IsRequired();
            builder.Property(p => p.Provider).IsRequired();
            builder.Property(s => s.Status).IsRequired();
            builder.Property(c => c.CreatedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.ModifiedAt);



        }
    }
}

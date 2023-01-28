using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class CaretItemConfig:IEntityTypeConfiguration<CaretItem>
    {
        public void Configure(EntityTypeBuilder<CaretItem> builder)
        {
            builder.ToTable(nameof(CaretItem));
            builder.HasKey(i => i.CaretItemId);
            builder.Property(i => i.CaretItemId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(c => c.CreatedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.ModifiedAt);
            builder.Property(q => q.Quantity).IsRequired().HasDefaultValue(1);
            builder.Property(i => i.BookId).IsRequired();
            builder.Property(s => s.ShoppingSessionId);
        }
    }
}

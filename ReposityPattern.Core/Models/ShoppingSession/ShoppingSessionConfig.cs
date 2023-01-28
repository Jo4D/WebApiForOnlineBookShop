using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class ShoppingSessionConfig:IEntityTypeConfiguration<ShoppingSession>
    {
        public void Configure(EntityTypeBuilder<ShoppingSession> builder)
        {
            builder.ToTable(nameof(ShoppingSession));
            builder.HasKey(i => i.ShoppingSessionId);
            builder.Property(i => i.ShoppingSessionId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(c => c.CreatedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.ModifiedAt);
            builder.Property(t => t.TotalPrice).IsRequired();
        }
    }
}

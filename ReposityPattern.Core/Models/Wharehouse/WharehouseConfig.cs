using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class WharehouseConfig:IEntityTypeConfiguration<Wharehouse>
    {
        public void Configure(EntityTypeBuilder<Wharehouse> builder)
        {
            builder.ToTable(nameof(Wharehouse));
            builder.HasKey(i => i.WharehouseId);
            builder.Property(i => i.WharehouseId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired().HasMaxLength(15);
            builder.Property(a => a.Address).IsRequired().HasMaxLength(100);

        }
    }
}

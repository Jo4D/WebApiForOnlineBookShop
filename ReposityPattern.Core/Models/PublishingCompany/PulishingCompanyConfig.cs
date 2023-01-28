using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class PulishingCompanyConfig:IEntityTypeConfiguration<PublishingCompany>
    {
        public void Configure(EntityTypeBuilder<PublishingCompany> builder)
        {
            builder.ToTable(nameof(PublishingCompany));
            builder.HasKey(i => i.PublishingCompanyId);
            builder.Property(i => i.PublishingCompanyId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Address).IsRequired().HasMaxLength(100);
        }
    }
}

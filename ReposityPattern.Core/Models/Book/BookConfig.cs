using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class BookConfig: IEntityTypeConfiguration<Book>
    {
        
            public void Configure(EntityTypeBuilder<Book> builder)
            {
                builder.ToTable(nameof(Book));
                builder.HasKey(i => i.BookId);
                builder.Property(i => i.BookId).ValueGeneratedOnAdd();
                builder.Property(c => c.Category).IsRequired().HasMaxLength(15);
                builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
                builder.Property(d => d.Description).IsRequired().HasMaxLength(200);
                builder.Property(r => r.Rate).IsRequired();
                builder.Property(c => c.CreatedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
                builder.Property(m => m.ModifiedAt);
                builder.Property(p => p.Price).IsRequired();
                builder.Property(i => i.Image).IsRequired();
                builder.Property(ai => ai.AuthorId);
                builder.Property(pci => pci.PublishingCompanyId);
                builder.Property(whi => whi.WharehouseId);
                builder.Property(d => d.DiscountId).IsRequired().HasDefaultValue(0);


            }
        }
    }


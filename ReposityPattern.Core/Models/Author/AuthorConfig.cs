using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryPattern.Core
{
    public class AuthorConfig:IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable(nameof(Author));
            builder.HasKey(i => i.AuthorId);
            builder.Property(i => i.AuthorId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name);
            builder.Property(pi => pi.PublishingCompanyId);




        }
    }
}

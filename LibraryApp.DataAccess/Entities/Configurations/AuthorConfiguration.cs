using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApp.DataAccess.Entities.Configurations{

    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {

        public void Configure(EntityTypeBuilder<Author> builder) {
            builder.ToTable("authors");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();
        }
    }
}
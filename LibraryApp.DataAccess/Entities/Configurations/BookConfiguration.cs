using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApp.DataAccess.Entities.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{

    public void Configure(EntityTypeBuilder<Book> builder) {
        builder.ToTable("books");
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Author)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.AuthorId);

        builder.HasOne(x => x.User)
            .WithMany(x => x.GivenBooks)
            .HasForeignKey(x => x.UserId);

        builder.HasOne(x => x.Partition)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.PartitionId);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.Status)
            .HasColumnName("status")
            .IsRequired();
            
        builder.Property(x => x.IsExpired)
            .HasColumnName("is_expired")
            .HasDefaultValue(false)
            .IsRequired();
            
        builder.Property(x => x.GivenDate)
            .HasColumnName("given_date")
            .HasDefaultValue(DateTime.Now)
            .IsRequired();

        builder.Property(x => x.UserId)
            .HasColumnName("user_id")
            .HasDefaultValue(1)
            .IsRequired();
    }
}
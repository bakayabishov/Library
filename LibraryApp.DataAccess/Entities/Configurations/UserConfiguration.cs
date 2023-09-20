using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApp.DataAccess.Entities.Configurations;

public class UserConfiguration: IEntityTypeConfiguration<User>
{

    public void Configure(EntityTypeBuilder<User> builder) {
        builder.ToTable("users");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(255)
            .IsRequired();
        
        builder.Property(x => x.Password)
            .HasColumnName("password")
            .HasMaxLength(255)
            .IsRequired();
        
        builder.Property(x => x.Role)
            .HasColumnName("role")
            .HasColumnType("nvarchar")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.IsManager)
            .HasColumnName("is_manager")
            .IsRequired();
    }
}
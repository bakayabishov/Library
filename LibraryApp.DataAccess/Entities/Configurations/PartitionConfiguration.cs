using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApp.DataAccess.Entities.Configurations;

public class PartitionConfiguration : IEntityTypeConfiguration<Partition>
{

    public void Configure(EntityTypeBuilder<Partition> builder) {
        builder.ToTable("partitions");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .IsRequired();
    }
}
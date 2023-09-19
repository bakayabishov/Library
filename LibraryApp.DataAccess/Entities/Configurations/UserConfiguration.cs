using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApp.DataAccess.Entities.Configurations;

public class UserConfiguration: IEntityTypeConfiguration<User>
{

    public void Configure(EntityTypeBuilder<User> builder) {
        builder.ToTable("users");
        builder.HasKey(x => x.Id);
        
        
    }
}
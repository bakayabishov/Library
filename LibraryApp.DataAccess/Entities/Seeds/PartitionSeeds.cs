using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess.Entities.Seeds;

public class PartitionSeeds : ISeeds {
    public ModelBuilder Seed(ModelBuilder builder) {
        builder.Entity<Partition>()
            .HasData(new Partition {
                Id = 1,
                Name = "Фантастика"
            },
            new Partition {
                Id = 2,
                Name = "Детективы"
            },
            new Partition {
                Id = 3,
                Name = "Детские"
                },
            new Partition {
                Id = 4,
                Name = "Учебный материал"
            });
        return builder;
    }
}
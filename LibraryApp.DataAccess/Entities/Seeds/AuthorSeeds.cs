using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess.Entities.Seeds;

public class AuthorSeeds : ISeeds {
    public ModelBuilder Seed(ModelBuilder builder) {
        builder.Entity<Author>()
            .HasData(new Author {
                    Id = 1,
                    Name = "Джуан Роулинг"
                },
                new Author {
                    Id = 2,
                    Name = "Агата Кристи"
                },
                new Author {
                    Id = 3,
                    Name = "Толстой А.Н."
                },
                new Author {
                    Id = 4,
                    Name = "Пётр Ершов"
                },
                new Author {
                    Id = 6,
                    Name = "Роберт Мартин"
                },
                new Author {
                    Id = 7,
                    Name = "Васильев А."
                },
                new Author {
                    Id = 8,
                    Name = "Геворкян П.С."
                },
                new Author {
                    Id = 9,
                    Name = "Аллен Дауни"
                },
                new Author {
                    Id = 10,
                    Name = "Заур Трегулов"
                });
        return builder;
    }
}
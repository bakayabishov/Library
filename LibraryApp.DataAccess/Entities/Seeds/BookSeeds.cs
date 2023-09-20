using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess.Entities.Seeds;

public class BookSeeds : ISeeds {
    public ModelBuilder Seed(ModelBuilder builder) {
        builder.Entity<Book>()
            .HasData(new Book {
                    Id = 1,
                    Name = "Гарри Поттер и философский камень",
                    AuthorId = 1,
                    PartitionId = 1
                },
                new Book {
                    Id = 2,
                    Name = "Гарри Поттер и тайная комната",
                    AuthorId = 1,
                    PartitionId = 1
                },
                new Book {
                    Id = 3,
                    Name = "Гарри Поттер и принц полукровка",
                    AuthorId = 1,
                    PartitionId = 1
                },
                new Book {
                    Id = 4,
                    Name = "Гарри Поттер и орден феникса",
                    AuthorId = 1,
                    PartitionId = 1
                },
                new Book {
                    Id = 5,
                    Name = "Гарри Поттер и дары смерти",
                    AuthorId = 1,
                    PartitionId = 1
                },
                new Book {
                    Id = 6,
                    Name = "Убийство в восточном экспрессе",
                    AuthorId = 2,
                    PartitionId = 2
                },
                new Book {
                    Id = 7,
                    Name = "Убийство на Ниле",
                    AuthorId = 2,
                    PartitionId = 2
                },
                new Book {
                    Id = 8,
                    Name = "Призрак Венеции",
                    AuthorId = 2,
                    PartitionId = 2
                },
                new Book {
                    Id = 9,
                    Name = "Колобок",
                    AuthorId = 3,
                    PartitionId = 3
                },
                new Book {
                    Id = 10,
                    Name = "Конек горбунок",
                    AuthorId = 4,
                    PartitionId = 3
                },
                new Book {
                    Id = 11,
                    Name = "Гуси-Лебеди",
                    AuthorId = 3,
                    PartitionId = 3
                },
                new Book {
                    Id = 12,
                    Name = "Чистая архитектура",
                    AuthorId = 6,
                    PartitionId = 4
                },
                new Book {
                    Id = 13,
                    Name = "Самоучитель по c#",
                    AuthorId = 7,
                    PartitionId = 4
                },
                new Book {
                    Id = 14,
                    Name = "Высшая матиматика",
                    AuthorId = 8,
                    PartitionId = 4
                },
                new Book {
                    Id = 15,
                    Name = "Основы Python",
                    AuthorId = 9,
                    PartitionId = 4
                },
                new Book {
                    Id = 16,
                    Name = "SQL для начинающих с нуля до сертификата Oracle",
                    AuthorId = 10,
                    PartitionId = 4
                });
        return builder;
    }
}
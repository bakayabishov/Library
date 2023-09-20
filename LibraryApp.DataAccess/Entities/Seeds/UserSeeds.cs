using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess.Entities.Seeds;

public class UserSeeds : ISeeds {
    public ModelBuilder Seed(ModelBuilder builder) {
        builder.Entity<User>()
            .HasData(new User {
                    Id = 1,
                    Name = "Администратор",
                    Password = "Admin",
                    Role = Role.Administrator,
                },
                new User {
                    Id = 2,
                    Name = "Менеджер",
                    Password = "Manager",
                    Role = Role.Manager,
                },
                new User {
                    Id = 3,
                    Name = "Читатель",
                    Password = "Reader",
                    Role = Role.User,
                },
                new User {
                    Id = 4,
                    Name = "Администратор2",
                    Password = "Admin",
                    Role = Role.Administrator,
                },
                new User {
                    Id = 5,
                    Name = "Менеджер2",
                    Password = "Manager",
                    Role = Role.Manager,
                },
                new User {
                    Id = 6,
                    Name = "Читатель2",
                    Password = "Reader",
                    Role = Role.User,
                });
        
        return builder;
    }
}
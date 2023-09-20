using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess.Entities.Seeds;

public interface ISeeds {
    ModelBuilder Seed(ModelBuilder builder);
}
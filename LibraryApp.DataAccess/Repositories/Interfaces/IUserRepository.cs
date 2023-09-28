using LibraryApp.DataAccess.Entities;

namespace LibraryApp.DataAccess.Repositories.Interfaces;

public interface IUserRepository : IBaseRepository<User, int>
{
    Task<User?> GetByIdAsync(int id);
}
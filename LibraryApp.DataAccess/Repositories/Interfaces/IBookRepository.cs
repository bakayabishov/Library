using LibraryApp.DataAccess.Entities;

namespace LibraryApp.DataAccess.Repositories.Interfaces;

public interface IBookRepository : IBaseRepository<Book, int>
{
    Task<bool> IsAlreadyExistAsync(string name);
}
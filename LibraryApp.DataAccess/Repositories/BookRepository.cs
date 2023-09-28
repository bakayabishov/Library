using LibraryApp.DataAccess.Entities;
using LibraryApp.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess.Repositories;

public class BookRepository : BaseRepository<Book, int>, IBookRepository
{
    public BookRepository(DataContext context) : base(context) { }
    public async Task<bool> IsAlreadyExistAsync(string name) {
        var query = All.Where(x => x.Name == name);
        return await query.AnyAsync(); 
    }
}
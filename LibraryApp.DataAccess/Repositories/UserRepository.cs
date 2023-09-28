using LibraryApp.DataAccess.Entities;
using LibraryApp.DataAccess.Exceptions;
using LibraryApp.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess.Repositories;

public class UserRepository : BaseRepository<User, int>, IUserRepository
{
    public UserRepository(DataContext context) : base(context) { }
    
    public async Task<User?> GetByIdAsync(int id) {
        var user =  await All.Where(x => x.Id == id).FirstOrDefaultAsync();
        if (user == null)
        {
            throw new EntityNotFoundException("Пользователь не найден", id.ToString());
        }
        
        return user;        
    }
}
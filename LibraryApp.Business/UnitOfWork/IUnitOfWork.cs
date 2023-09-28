using LibraryApp.DataAccess.Repositories.Interfaces;

namespace LibraryApp.Business.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    Task SaveChangesAsync();
    IBookRepository Books { get; }
    IAuthorRepository Authors { get; }
    IUserRepository Users { get; }
    IPartitionRepository Partitions { get; }
}
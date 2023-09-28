using LibraryApp.DataAccess;
using LibraryApp.DataAccess.Repositories.Interfaces;

namespace LibraryApp.Business.UnitOfWork;

public sealed class UnitOfWork : IUnitOfWork
{
    #region Property
    private readonly DataContext _context;
    private bool _disposed;
    #endregion

    #region Constructor
    public UnitOfWork(DataContext context, IBookRepository books) {
        this._context = context;
        Books = books;
    }
    #endregion

    #region Method
    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();

    public IBookRepository Books { get; }
    public IAuthorRepository Authors { get; }
    public IUserRepository Users { get; }
    public IPartitionRepository Partitions { get; }

    private void Clean(bool disposing)
    {
        if (!this._disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        this._disposed = true;
    }

    public void Dispose()
    {
        Clean(true);
        GC.SuppressFinalize(this);
    }
    #endregion
}
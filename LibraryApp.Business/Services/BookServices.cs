using AutoMapper;
using LibraryApp.Business.Interfaces;
using LibraryApp.Business.Models;
using LibraryApp.Business.UnitOfWork;
using LibraryApp.DataAccess.Entities;
using LibraryApp.DataAccess.Exceptions;

namespace LibraryApp.Business.Services;

public class BookServices : IBookServices {
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public BookServices(IMapper mapper, IUnitOfWork uow) {
        _mapper = mapper;
        _uow = uow;
    }
    public async Task<string> AddAsync(BookDto book) {
        if (await _uow.Books.IsAlreadyExistAsync(book.Name))
        {
            throw new EntityNotFoundException("Книга с таким названием уже есть в системе", book.Name);

        }
        var user = _uow.Users.GetByIdAsync(book.UserId);

        var entity = _mapper.Map<Book>(book);
        entity.UserId = user.Id;
        await _uow.Books.AddAsync(entity);
        await _uow.SaveChangesAsync();
        return entity.Name;
    }  
}
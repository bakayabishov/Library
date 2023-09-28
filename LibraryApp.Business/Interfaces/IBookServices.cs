using LibraryApp.Business.Models;

namespace LibraryApp.Business.Interfaces;

public interface IBookServices {
    Task<string> AddAsync(BookDto book);

}
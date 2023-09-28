using LibraryApp.Business.Interfaces;
using LibraryApp.Business.Models;
using LibraryApp.DataAccess.Entities;
using MarketApp.API.Controllers.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.API.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]


public class BookControllers : ControllerBase
{
    private readonly IBookServices _bookServices;

    public BookControllers(IBookServices bookServices) {
        _bookServices = bookServices;
    }
    
    [HttpPost]
    [Route("AddBook")]
    [Authorized(Role.Administrator)]
    public async Task<IActionResult> CreateAsync(BookDto book) {

        await _bookServices.AddAsync(book);
        return Ok(ApiResponse.Success("Магазин успешно создан"));
    }
}
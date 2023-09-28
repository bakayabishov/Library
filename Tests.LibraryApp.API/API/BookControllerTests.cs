using LibraryApp.API.Controllers;
using LibraryApp.Business.Interfaces;
using Moq;
using NUnit.Framework;

namespace Tests.LibraryApp.API.API;

public class BookControllerTests : TestBase
{
    private BookControllers _bookControllers;
    private Mock<IBookServices> _bookServices;
    private BookFaker _bookFaker;
    
    public override void Setup() {
        _bookServices = new();
        _bookControllers = new(_bookServices.Object);

        _bookFaker = new();
    }

    public override void TearDown() { }

    [Test]
    public async Task AddBookAsync_Should_ReturnOkResponse_When_BookCreated() {
        
    }
}
using Bogus;
using LibraryApp.Business.Models;

namespace Tests.LibraryApp.Business.Fakers;

public class BookDtoFaker
{
    public Faker<BookDto> NewBook()
    {
        return new Faker<BookDto>()
            .UseSeed(9376)
            .RuleFor(x => x.Name, x => x.Random.Word())
            .RuleFor(x => x.AuthorId, x => x.Random.String())
            .RuleFor(x => x.Role, x => x.PickRandom<Role>());
    }
}
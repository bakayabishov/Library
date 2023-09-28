using LibraryApp.DataAccess.Entities;

namespace LibraryApp.Business.Models;

public class BookDto
{
    public string Name { get; set; }
    public int AuthorId { get; set; }
    public int PartitionId { get; set; }
    public int UserId { get; set; }
    public BookStatus Status { get; set; }
    public DateTime GivenDateTime { get; set; }
    public bool IsExpired { get; set; }
}
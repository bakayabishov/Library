using LibraryApp.DataAccess.Entities.Configurations;

namespace LibraryApp.DataAccess.Entities;

/// <summary>
///     Configuration file for this entity <see cref="BookConfiguration" />
/// </summary>

public class Book : IEntityBase<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Author Author { get; set; }
    public int AuthorId { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public Partition Partition { get; set; }
    public int PartitionId {get; set; }
    public BookStatus Status { get; set; }
    public DateTime GivenDate { get; set; }
   public bool IsExpired { get; set; }

    public int GetId() {
        return Id;
    }
}
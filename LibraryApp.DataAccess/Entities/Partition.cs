using LibraryApp.DataAccess.Entities.Configurations;

namespace LibraryApp.DataAccess.Entities;

/// <summary>
///     Configuration file for this entity <see cref="PartitionConfiguration" />
/// </summary>

public class Partition : IEntityBase<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }

    public int GetId() {
        return Id;
    }
}
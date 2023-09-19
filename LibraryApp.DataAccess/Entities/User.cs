using LibraryApp.DataAccess.Entities.Configurations;

namespace LibraryApp.DataAccess.Entities;

/// <summary>
///     Configuration file for this entity <see cref="UserConfiguration" />
/// </summary>

public class User : IEntityBase<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Role Role { get; set; }
    public bool IsManager { get; set; }
    


    public int GetId() {
        return Id;
    }
}
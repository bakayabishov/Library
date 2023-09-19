namespace LibraryApp.DataAccess.Entities; 

public abstract class EntityBase<TKey> : IEntityBase<TKey> {
    public abstract TKey GetId();
}
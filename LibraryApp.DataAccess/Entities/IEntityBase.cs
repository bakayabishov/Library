namespace LibraryApp.DataAccess.Entities;

public interface IEntityBase<TKey> {
    TKey GetId();
}
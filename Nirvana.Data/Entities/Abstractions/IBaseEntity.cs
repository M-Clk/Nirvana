namespace Nirvana.Data.Entities.Abstractions
{
    public interface IBaseEntity
    {
        int Id { get; set; }
    }
    public interface IBaseEntity<T>
    {
        T Id { get; set; }
    }
}

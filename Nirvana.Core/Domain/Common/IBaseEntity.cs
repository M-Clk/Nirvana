namespace Nirvana.Core.Domain.Common
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

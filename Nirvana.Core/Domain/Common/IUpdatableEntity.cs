namespace Nirvana.Core.Domain.Common
{
    public interface IUpdatableEntity
    {
        DateTime? UpdatedDate { get; set; }
    }
}

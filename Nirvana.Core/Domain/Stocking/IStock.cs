using Nirvana.Core.Domain.Common;

namespace Nirvana.Core.Domain.Stocking
{
    public interface IStock : IBaseEntity, IAddableEntitiy, IUpdatableEntity
    {
        int ProductId { get; set; }
        IQuantity Quantity { get; set; }
    }
}

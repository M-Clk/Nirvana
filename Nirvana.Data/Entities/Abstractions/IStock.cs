namespace Nirvana.Data.Entities.Abstractions
{
    public interface IStock : IBaseEntity, IAddableEntitiy, IUpdatableEntity
    {
        int ProductId { get; set; }
        IQuantity Quantity { get; set; }
    }
}

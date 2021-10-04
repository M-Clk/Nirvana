namespace Nirvana.Data.Entities.Abstractions
{
    public interface IQuantity : IBaseEntity
    {
        double Amount { get; set; }
        IUnit Unit { get; set; }
    }
}

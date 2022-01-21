using Nirvana.Core.Domain.Common;

namespace Nirvana.Core.Domain.Stocking
{
    public interface IQuantity : IBaseEntity
    {
        double Amount { get; set; }
        IUnit Unit { get; set; }
    }
}

using Nirvana.Core.Domain.Common;

namespace Nirvana.Core.Domain.Finance
{
    public interface IPrice : IAddableEntitiy
    {
        int ProductId { get; set; }
        double SaleValue { get; set; }
        double CostValue { get; set; }
        IEnumerable<ITax> Taxes { get; set; }
        IEnumerable<IDiscount> Discounts { get; set; }
    }
}

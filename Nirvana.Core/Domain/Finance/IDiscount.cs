using Nirvana.Core.Domain.Catalog;
using Nirvana.Core.Domain.Common;

namespace Nirvana.Core.Domain.Finance
{
    public interface IDiscount : IBaseEntity, IAddableEntitiy
    {
        string Name { get; set; }
        DateTime ExpiredDate { get; set; }
        double Value { get; set; }
        bool IsPercentage { get; set; }
        IEnumerable<IProduct> Products { get; set; }
    }
}

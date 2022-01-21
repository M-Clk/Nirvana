using Nirvana.Core.Domain.Catalog;
using Nirvana.Core.Domain.Common;

namespace Nirvana.Core.Domain.Finance
{
    public interface ITax : IBaseEntity
    {
        string Name { get; set; }
        int Percentage { get; set; }
        IEnumerable<IProduct> Products { get; set; }
    }
}

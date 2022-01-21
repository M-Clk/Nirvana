using Nirvana.Core.Domain.Common;
using Nirvana.Core.Domain.Finance;
using Nirvana.Core.Domain.Stocking;

namespace Nirvana.Core.Domain.Catalog
{
    public interface IProduct : IBaseEntity, IAddableEntitiy, IUpdatableEntity, ISoftErasableEntity
    {
        string Name { get; set; }
        string Ean13 { get; set; }
        IPrice Price { get; set; }
        IEnumerable<IStock> Stocks { get; set; }
    }
}

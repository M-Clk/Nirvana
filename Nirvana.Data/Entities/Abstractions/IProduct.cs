using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Data.Entities.Abstractions
{
    public interface IProduct: IBaseEntity, IAddableEntitiy, IUpdatableEntity, ISoftErasableEntity
    {
        string Name { get; set; }
        string Ean13 { get; set; }
        IPrice Price { get; set; }
        IEnumerable<IStock> Stocks { get; set; }
    }
}

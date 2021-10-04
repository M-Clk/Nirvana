using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Data.Entities.Abstractions
{
    public interface IPrice: IAddableEntitiy
    {
        int ProductId { get; set; }
        double SaleValue { get; set; }
        double CostValue { get; set; }
        IEnumerable<ITax> Taxes { get; set; }
        IEnumerable<IDiscount> Discounts { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Nirvana.Data.Entities.Abstractions
{
    public interface IDiscount : IBaseEntity
    {
        double Name { get; set; }
        DateTime ExpiredDate { get; set; }
        double Value { get; set; }
        bool IsPercentage { get; set; }
        IEnumerable<IProduct> Products { get; set; }
    }
}

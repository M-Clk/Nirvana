using Nirvana.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace Nirvana.Data.Entities
{
    public class Price : IPrice
    {
        public int ProductId { get; set; }
        public DateTime AddedDate { get; set; }
        public double Value { get; set; }
        public double SaleValue { get; set; }
        public double CostValue { get; set; }
        public IEnumerable<ITax> Taxes { get; set; }
        public IEnumerable<IDiscount> Discounts { get; set; }
    }
}

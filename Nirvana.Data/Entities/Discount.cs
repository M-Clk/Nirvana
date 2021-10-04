using Nirvana.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Data.Entities
{
    public class Discount : IDiscount
    {
        public int Id { get; set; }
        public double Name { get; set; }
        public DateTime ExpiredDate { get; set; }
        public double Value { get; set; }
        public bool IsPercentage { get; set; }
        public IEnumerable<IProduct> Products { get; set; }
    }
}

using Nirvana.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Data.Entities
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Name { get; set; }
        public IPrice Price { get; set; }
        public IEnumerable<IStock> Stocks { get; set; }
    }//TODO stocks klasoru altinda bu entit/abstractionlar toplanabilir
}

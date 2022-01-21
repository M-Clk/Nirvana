using Nirvana.Core.Domain.Finance;
using Nirvana.Core.Domain.Stocking;

namespace Nirvana.Core.Domain.Catalog
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Name { get; set; }
        public string Ean13 { get; set; }
        public IPrice Price { get; set; }
        public IEnumerable<IStock> Stocks { get; set; }
    }
}

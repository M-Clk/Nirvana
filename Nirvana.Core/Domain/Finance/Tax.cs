using Nirvana.Core.Domain.Catalog;

namespace Nirvana.Core.Domain.Finance
{
    public class Tax : ITax
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
        public IEnumerable<IProduct> Products { get; set; }
    }
}

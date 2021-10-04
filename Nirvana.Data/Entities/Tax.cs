using Nirvana.Data.Entities.Abstractions;
using System.Collections.Generic;

namespace Nirvana.Data.Entities
{
    public class Tax : ITax
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
        public IEnumerable<IProduct> Products { get; set; }
    }
}

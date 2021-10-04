using Nirvana.Data.Entities.Abstractions;

namespace Nirvana.Data.Entities
{
    public class Quantity : IQuantity
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public IUnit Unit { get; set; }
    }
}

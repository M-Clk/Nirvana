namespace Nirvana.Core.Domain.Stocking
{
    public class Stock : IStock
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public IQuantity Quantity { get; set; }
    }
}

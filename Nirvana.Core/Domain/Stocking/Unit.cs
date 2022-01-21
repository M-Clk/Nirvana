namespace Nirvana.Core.Domain.Stocking
{
    public class Unit : IUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double IncreaseAmount { get; set; }
    }
}

using Nirvana.Core.Domain.Common;

namespace Nirvana.Core.Domain.Stocking
{
    public interface IUnit : IBaseEntity
    {
        string Name { get; set; }
        double IncreaseAmount { get; set; }
    }
}

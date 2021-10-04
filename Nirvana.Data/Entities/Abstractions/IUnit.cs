using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Data.Entities.Abstractions
{
    public interface IUnit:IBaseEntity
    {
        string Name { get; set; }
        double IncreaseAmount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Data.Entities.Abstractions
{
    public interface IUpdatableEntity
    {
        DateTime? UpdatedDate { get; set; }
    }
}

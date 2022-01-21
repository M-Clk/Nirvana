using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Core.Domain.Common
{
    public interface IAddableEntitiy
    {
        DateTime AddedDate { get; set; }
    }
}

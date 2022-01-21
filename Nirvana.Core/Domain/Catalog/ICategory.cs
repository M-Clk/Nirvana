using Nirvana.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Core.Domain.Catalog
{
    public interface ICategory : IBaseEntity, IAddableEntitiy, IUpdatableEntity
    {
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public ICategory ParentCategory { get; set; }
    }
}

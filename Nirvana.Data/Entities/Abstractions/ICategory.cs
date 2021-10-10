using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Data.Entities.Abstractions
{
    public interface ICategory : IBaseEntity, IAddableEntitiy, IUpdatableEntity
    {
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public ICategory ParentCategory { get; set; }
    }
}

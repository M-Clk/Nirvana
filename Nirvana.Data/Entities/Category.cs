using Nirvana.Data.Entities.Abstractions;
using System;

namespace Nirvana.Data.Entities
{
    public class Category : ICategory
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public ICategory ParentCategory { get; set; }
    }
}

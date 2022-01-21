
namespace Nirvana.Core.Domain.Catalog
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

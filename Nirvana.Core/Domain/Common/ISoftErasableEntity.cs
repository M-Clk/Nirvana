namespace Nirvana.Core.Domain.Common
{
    public interface ISoftErasableEntity
    {
        DateTime? DeletedDate { get; set; }
        public bool IsDeleted => DeletedDate != null;
    }
}
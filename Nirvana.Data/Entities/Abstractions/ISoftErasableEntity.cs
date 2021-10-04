using System;

namespace Nirvana.Data.Entities.Abstractions
{
    public interface ISoftErasableEntity
    {
        DateTime? DeletedDate { get; set; }
        public bool IsDeleted => DeletedDate != null;
    }
}
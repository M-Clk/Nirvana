using Nirvana.Core;
using Nirvana.Core.Caching;
using Nirvana.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Nirvana.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : IBaseEntity
    {
        TEntity GetById(int? id, Func<IStaticCacheManager, CacheKey> getCacheKey = null, bool includeDeleted = true);

        IList<TEntity> GetByIds(IList<int> ids, Func<IStaticCacheManager, CacheKey> getCacheKey = null, bool includeDeleted = true);

        IList<TEntity> GetAll(Func<IQueryable<TEntity>, IQueryable<TEntity>> func = null,
            Func<IStaticCacheManager, CacheKey> getCacheKey = null, bool includeDeleted = true);

        IPagedList<TEntity> GetAllPaged(Func<IQueryable<TEntity>, IQueryable<TEntity>> func = null,
            int pageIndex = 0, int pageSize = int.MaxValue, bool getOnlyTotalCount = false, bool includeDeleted = true);

        void Insert(TEntity entity, bool publishEvent = true);

        void Insert(IList<TEntity> entities, bool publishEvent = true);

        void Update(TEntity entity, bool publishEvent = true);

        void Update(IList<TEntity> entities, bool publishEvent = true);

        void Delete(TEntity entity, bool publishEvent = true);

        void Delete(IList<TEntity> entities, bool publishEvent = true);

        int Delete(Expression<Func<TEntity, bool>> predicate);

        TEntity LoadOriginalCopy(TEntity entity);

        void Truncate(bool resetIdentity = false);
        IQueryable<TEntity> Table { get; }
    }
}

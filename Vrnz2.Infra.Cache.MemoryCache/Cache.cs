using Microsoft.Extensions.Caching.Memory;
using System;
using Vrnz2.Infra.Cache.Interfaces;

namespace Vrnz2.Infra.Cache.MemoryCache
{
    public class Cache
        : ICache
    {
        #region Variables

        private IMemoryCache _cache;

        #endregion

        #region Constructors

        public Cache(IMemoryCache cache) 
            => _cache = cache;

        #endregion

        #region Methods

        public TEntity Set<TKey, TEntity>(TKey key, TEntity entity)
            => _cache.Set(key, entity);

        public TEntity Set<TKey, TEntity>(TKey key, TEntity entity, TimeSpan expiration) 
            => _cache.Set(key, entity, expiration);

        public TEntity Get<TKey, TEntity>(TKey key)
            => _cache.Get<TEntity>(key);

        public void Remove<TKey>(TKey key)
            => _cache.Remove(key);

        #endregion
    }
}
using System;

namespace Vrnz2.Infra.Cache.Interfaces
{
    public interface ICache
    {
        TEntity Set<TKey, TEntity>(TKey key, TEntity entity);
        TEntity Set<TKey, TEntity>(TKey key, TEntity entity, TimeSpan expiration);

        TEntity Get<TKey, TEntity>(TKey key);

        void Remove<TKey>(TKey key);
    }
}

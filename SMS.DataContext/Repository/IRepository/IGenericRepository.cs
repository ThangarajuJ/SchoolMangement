using SMS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.DataContext
{
    public interface IGenericRepository
    {
        long Add<TEntity>(TEntity entity) where TEntity : DBBaseObjects;
        IEnumerable<TEntity> All<TEntity>() where TEntity:DBBaseObjects;
        TEntity Find<TEntity>(long id) where TEntity : DBBaseObjects;
        bool Update<TEntity>(TEntity entity) where TEntity : DBBaseObjects;
        bool Delete<TEntity>(long id) where TEntity : DBBaseObjects;
    }
}

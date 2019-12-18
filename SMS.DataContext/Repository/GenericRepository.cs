using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SMS.DTO;
using Dapper;
using Dapper.Contrib.Extensions;

namespace SMS.DataContext
{
    public class GenericRepository : RepositoryBase, IGenericRepository
    {
        public GenericRepository(IDbTransaction transaction) : base(transaction)
        {

        }
        public long Add<TEntity>(TEntity entity) where TEntity : DBBaseObjects
        {
            return Connection.Insert<TEntity>(entity, transaction: Transaction);
        }
        public IEnumerable<TEntity> All<TEntity>() where TEntity : DBBaseObjects
        {
            return Connection.GetAll<TEntity>(transaction: Transaction).AsEnumerable<TEntity>();//.Where(q => q.IsDeleted == false);
        }
        public TEntity Find<TEntity>(long id) where TEntity : DBBaseObjects
        {
            return Connection.Get<TEntity>(id, transaction: Transaction);
        }
        public bool Update<TEntity>(TEntity entity) where TEntity : DBBaseObjects
        {
            return Connection.Update<TEntity>(entity, transaction: Transaction);
        }
        public bool Delete<TEntity>(long id) where TEntity : DBBaseObjects
        {
            bool IsDeleted = false;
            TEntity entity = Find<TEntity>(id);
            if (entity != null)
            {
                //entity.IsActive = false;
                IsDeleted = Update<TEntity>(entity);
            }
            return IsDeleted;
        }
    }
}

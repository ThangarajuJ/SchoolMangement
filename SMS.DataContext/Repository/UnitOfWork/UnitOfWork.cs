using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SMS.DTO;

namespace SMS.DataContext
{
    public class UnitOfWork:IUnitOfWork
    {
        #region PrivateFields
        private IDbConnection Connection;
        private IDbTransaction Transaction;

        private IGenericRepository genericRepository;
        private bool disposed;
        #endregion

        #region Constrctors
        public UnitOfWork()
        {
            Connection = new SqlConnection(ConfigHelper.GetDefaultConnectionString());
            Connection.Open();
            Transaction = Connection.BeginTransaction();
        }
        #endregion

        #region Properties
        public IGenericRepository GenericRepository
        {
            get { return genericRepository ??( genericRepository = new GenericRepository(Transaction)); } 
        }
        #endregion

        #region Public Methods
        public void Commit()
        {
            try
            {
                Transaction.Commit();
            }
            catch
            {
                Transaction.Rollback();
                throw;
            }
            finally
            {
                Transaction.Dispose();
                Transaction = Connection.BeginTransaction();
                resetRespositories();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

        #region Private Methods
        private void resetRespositories()
        {
            genericRepository = null;
        }

        private void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    if(Transaction!=null)
                    {
                        Transaction.Dispose();
                        Transaction = null;
                    }
                    if(Connection!=null)
                    {
                        Connection.Dispose();
                        Connection = null;
                    }
                }
                disposed = true;
            }
        }
        #endregion

        #region Destrucutor
        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}

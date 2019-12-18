using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SMS.DataContext
{
    public abstract class RepositoryBase
    {
        #region Protected Members
        protected IDbTransaction Transaction { get; private set; }

        protected IDbConnection Connection { get { return Transaction.Connection; } }
        #endregion

        #region Constrcutors
        protected RepositoryBase(IDbTransaction dbTransaction)
        {
            Transaction = dbTransaction;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataContext
{
    public interface IUnitOfWork :IDisposable
    {
       IGenericRepository GenericRepository { get; }

        #region Public Methods
        void Commit();
        #endregion
    }
}

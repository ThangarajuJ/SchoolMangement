using SMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DataContext;

namespace SMS.BusinessContext.Sample
{
    public static class SampleContext
    {
        public static List<SampleModel> GetAll()
        {
            List<SampleModel> sampleModel=null;
            using (UnitOfWork uow = new UnitOfWork())
            {
                sampleModel = uow.GenericRepository.All<SampleModel>().ToList();
            }
            return sampleModel;
        }
    }
}

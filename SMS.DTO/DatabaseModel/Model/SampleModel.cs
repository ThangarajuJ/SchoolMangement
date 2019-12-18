using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DTO
{
    [Table("[dbo].[tbl_Details]")]
    public class SampleModel:DBBaseObjects
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SMS.DTO
{
    public static class ConfigHelper
    {
        public static string GetDefaultConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SampleDBCon"].ToString();
        }
    }
}

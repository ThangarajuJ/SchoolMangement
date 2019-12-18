using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace SMS.DTO
{
    [Table("[dbo].[USER_REGISTRATION]")]
    public class UserRegistration : DBBaseObjects
    {
        [Key]
        public int UR_ID { get; set; }
        public string UR_USERNAME { get; set; }
        public string UR_EMAIL { get; set; }
        public string UR_PASSWORD { get; set; }
        public string UR_PHONE { get; set; }
        public DateTime? UR_REC_DATE { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DTO
{
    public class UserRegistrationCreatePayload : DBBaseObjects
    {
        public int UR_ID { get; set; }
        public string UR_USERNAME { get; set; }
        public string UR_EMAIL { get; set; }
        public string UR_PASSWORD { get; set; }
        public string UR_PHONE { get; set; }
        public DateTime? UR_REC_DATE { get; set; }
        public string UR_LANG { get; set; }
    }
    public class UserDetail
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

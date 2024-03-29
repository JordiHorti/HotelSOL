using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSOL.Models
{
    public class User
    {
        public virtual int user_id { get; set; }
        public virtual int customer_id { get; set; }
        public virtual string userName { get; set; }
        public virtual string userEmail { get; set; }
        public virtual string userPassword { get; set; }
        public virtual int user_role { get; set; }
    }
}
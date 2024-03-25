using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSOL.Models
{
    public class Customer
    {
        public virtual string CustomerName {get; set;}
        public virtual  int customer_id { get;  set; }
        public virtual string CustomerPhone { get; set; }
        public virtual string CustomerEmail { get; set; }
    }
}

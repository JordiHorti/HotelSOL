using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSOL.Models
{
    public class Customer
    {
        public virtual string customerName {get; set;}
        public virtual  int customer_id { get;  set; }
        public virtual string customerPhone { get; set; }
        public virtual string customerEmail { get; set; }
    }
}

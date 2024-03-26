using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSOL.Models
{
    public class Service
    {
        public virtual int services_id { get; set; }
        public virtual string service {  get; set; }
        public virtual decimal servicePrice { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSOL.Models
{
    internal class Booking
    {
        public virtual int bookings_id { get; set; }
        public virtual int customer_id { get; set; }
        public virtual int services_id { get; set; }
        public virtual string customerName { get; set; }
        public virtual string customerEmail {  get; set; }
        public virtual int roomNumber { get; set; }
        public virtual string service {  get; set; }
        public virtual DateTime checkIn { get; set; }
        public virtual DateTime checkOn { get; set; }
        public virtual int days {  get; set; }
        public virtual decimal totalPrice { get; set; }
    }
}

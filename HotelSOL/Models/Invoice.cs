using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSOL.Models
{
    public class Invoice
    {
        public virtual int invoices_id { get; set; }
        public virtual int bookings_id { get; set; }
        public virtual int customer_id { get; set; }
        public virtual string customerName { get; set; }
        public virtual string customerEmail { get; set; }
        public virtual string customerPhone { get; set; }
        public virtual int roomNumber { get; set; }
        public virtual string roomType { get; set; }
        public virtual int roomCapacity { get; set; }
        public virtual int roomPrice { get; set; }
        public virtual required string service { get; set; }
        public virtual int servicePrice { get; set; }
        public virtual DateTime checkIn { get; set; }
        public virtual DateTime checkOut { get; set; }
        public virtual int days { get; set; }
        public virtual decimal totalPrice { get; set; }

    }
}

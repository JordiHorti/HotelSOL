using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSOL.Models
{
    public class Room
    {
        public virtual int room_id { get; set; }
        public virtual int roomNumber { get; set; }
        public virtual string type { get; set; }
        public virtual int roomCapacity { get; set; }
        public virtual string roomSeason { get; set; }
        public virtual decimal price { get; set; }
        public virtual string roomDescription { get; set; }
        public virtual bool booked { get; set; }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
    public class Address
    {
        public int ID { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public Street Street { get; set; }
        public string HouseNumber { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}

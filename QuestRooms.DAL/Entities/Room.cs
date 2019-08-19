using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
    public class Room
    {
        public int ID { get; set; }

        public Address AddressID { get; set; }
    }
}

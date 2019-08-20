using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
    public class Company
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}

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
        public Country CountryID { get; set; }
        public City CityID { get; set; }
        public Street StreetID { get; set; }

        public string HouseNumber { get; set; }
    }
}

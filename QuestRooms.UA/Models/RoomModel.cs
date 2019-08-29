using QuestRooms.BLL.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestRooms.UA.Models
{
    public class RoomModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan PassingTime { get; set; }
        public int MinPlayer { get; set; }
        public int MaxPlayer { get; set; }
        public int MinAge { get; set; }
        public virtual AddressDto Address { get; set; }
        public string PhoneNumber { get; set; }
        public virtual CompanyDto Company { get; set; }
        public string Email { get; set; }
        public int Rating { get; set; }
        public int LevelFear { get; set; }
        public int LevelDifficulty { get; set; }
        public string Logo { get; set; }
    }
}
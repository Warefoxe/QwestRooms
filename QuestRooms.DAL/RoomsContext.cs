namespace QuestRooms.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RoomsContext : DbContext
    {
        
        public RoomsContext()
            : base("name=RoomsContext")
        {
        }

       
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
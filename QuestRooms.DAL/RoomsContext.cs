namespace QuestRooms.DAL
{
    using QuestRooms.DAL.Configuration;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RoomsContext : DbContext
    {
        
        public RoomsContext()
            : base("name=RoomsContext")
        {
            this.Database.Log = (x =>
            {
                Console.WriteLine(x);
            });

            Database.SetInitializer(new DbInitilizer());
        }

        
       
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
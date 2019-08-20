namespace QuestRooms.DAL
{
    using QuestRooms.DAL.Configuration;
    using QuestRooms.DAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RoomsContext : DbContext
    {
        
        public RoomsContext()
            : base("name=RoomsContext")
        {
            //this.Database.Log = (x =>
            //{
            //    Console.WriteLine(x);
            //});

            //Database.SetInitializer(new DbInitilizer());
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Street> Streets { get; set; }



    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
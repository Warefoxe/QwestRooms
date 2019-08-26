namespace QuestRooms.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HouseNumber = c.String(),
                        CityID_ID = c.Int(),
                        CountryID_ID = c.Int(),
                        StreetID_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityID_ID)
                .ForeignKey("dbo.Countries", t => t.CountryID_ID)
                .ForeignKey("dbo.Streets", t => t.StreetID_ID)
                .Index(t => t.CityID_ID)
                .Index(t => t.CountryID_ID)
                .Index(t => t.StreetID_ID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        PassingTime = c.Time(nullable: false, precision: 7),
                        MinPlayer = c.Int(nullable: false),
                        MaxPlayer = c.Int(nullable: false),
                        MinAge = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Rating = c.Int(nullable: false),
                        LevelFear = c.Int(nullable: false),
                        LevelDifficulty = c.Int(nullable: false),
                        Logo = c.String(),
                        Address_ID = c.Int(),
                        Company_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.Address_ID)
                .ForeignKey("dbo.Companies", t => t.Company_ID)
                .Index(t => t.Address_ID)
                .Index(t => t.Company_ID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Room_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.Room_ID)
                .Index(t => t.Room_ID);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "StreetID_ID", "dbo.Streets");
            DropForeignKey("dbo.Images", "Room_ID", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "Company_ID", "dbo.Companies");
            DropForeignKey("dbo.Rooms", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "CountryID_ID", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "CityID_ID", "dbo.Cities");
            DropIndex("dbo.Images", new[] { "Room_ID" });
            DropIndex("dbo.Rooms", new[] { "Company_ID" });
            DropIndex("dbo.Rooms", new[] { "Address_ID" });
            DropIndex("dbo.Addresses", new[] { "StreetID_ID" });
            DropIndex("dbo.Addresses", new[] { "CountryID_ID" });
            DropIndex("dbo.Addresses", new[] { "CityID_ID" });
            DropTable("dbo.Streets");
            DropTable("dbo.Images");
            DropTable("dbo.Companies");
            DropTable("dbo.Rooms");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}

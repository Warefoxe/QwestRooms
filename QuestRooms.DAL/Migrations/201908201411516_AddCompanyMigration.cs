namespace QuestRooms.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        City_ID = c.Int(),
                        Country_ID = c.Int(),
                        Street_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.City_ID)
                .ForeignKey("dbo.Countries", t => t.Country_ID)
                .ForeignKey("dbo.Streets", t => t.Street_ID)
                .Index(t => t.City_ID)
                .Index(t => t.Country_ID)
                .Index(t => t.Street_ID);
            
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
                        TimeOfCompliting = c.Time(nullable: false, precision: 7),
                        MinCountOfPlayers = c.Int(nullable: false),
                        MaxCountOfPlayers = c.Int(nullable: false),
                        MinAgeOfPlayers = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Rating = c.Double(nullable: false),
                        LvlOfFear = c.Int(nullable: false),
                        LvlOfDifficulty = c.Int(nullable: false),
                        Logo = c.String(),
                        Address_ID = c.Int(),
                        Images_ID = c.Int(),
                        Company_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.Address_ID)
                .ForeignKey("dbo.Images", t => t.Images_ID)
                .ForeignKey("dbo.Companies", t => t.Company_ID)
                .Index(t => t.Address_ID)
                .Index(t => t.Images_ID)
                .Index(t => t.Company_ID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "Company_ID", "dbo.Companies");
            DropForeignKey("dbo.Addresses", "Street_ID", "dbo.Streets");
            DropForeignKey("dbo.Rooms", "Images_ID", "dbo.Images");
            DropForeignKey("dbo.Rooms", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "City_ID", "dbo.Cities");
            DropIndex("dbo.Rooms", new[] { "Company_ID" });
            DropIndex("dbo.Rooms", new[] { "Images_ID" });
            DropIndex("dbo.Rooms", new[] { "Address_ID" });
            DropIndex("dbo.Addresses", new[] { "Street_ID" });
            DropIndex("dbo.Addresses", new[] { "Country_ID" });
            DropIndex("dbo.Addresses", new[] { "City_ID" });
            DropTable("dbo.Companies");
            DropTable("dbo.Streets");
            DropTable("dbo.Images");
            DropTable("dbo.Rooms");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}

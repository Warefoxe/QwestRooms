namespace QuestRooms.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Addresses", name: "CityID_ID", newName: "City_ID");
            RenameColumn(table: "dbo.Addresses", name: "CountryID_ID", newName: "Country_ID");
            RenameColumn(table: "dbo.Addresses", name: "StreetID_ID", newName: "Street_ID");
            RenameIndex(table: "dbo.Addresses", name: "IX_CityID_ID", newName: "IX_City_ID");
            RenameIndex(table: "dbo.Addresses", name: "IX_CountryID_ID", newName: "IX_Country_ID");
            RenameIndex(table: "dbo.Addresses", name: "IX_StreetID_ID", newName: "IX_Street_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Addresses", name: "IX_Street_ID", newName: "IX_StreetID_ID");
            RenameIndex(table: "dbo.Addresses", name: "IX_Country_ID", newName: "IX_CountryID_ID");
            RenameIndex(table: "dbo.Addresses", name: "IX_City_ID", newName: "IX_CityID_ID");
            RenameColumn(table: "dbo.Addresses", name: "Street_ID", newName: "StreetID_ID");
            RenameColumn(table: "dbo.Addresses", name: "Country_ID", newName: "CountryID_ID");
            RenameColumn(table: "dbo.Addresses", name: "City_ID", newName: "CityID_ID");
        }
    }
}

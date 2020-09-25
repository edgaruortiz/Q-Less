namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStationsAndPriceMatrices : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PriceMatrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntryStationid = c.Int(nullable: false),
                        ExitStationid = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StationName = c.String(nullable: false, maxLength: 50),
                        line = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Stations");
            DropTable("dbo.PriceMatrices");
        }
    }
}

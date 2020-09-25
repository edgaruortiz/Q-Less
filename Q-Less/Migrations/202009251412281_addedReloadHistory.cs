namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedReloadHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransportCardReloadHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransportCardUniqueId = c.Int(nullable: false),
                        CashValue = c.Double(nullable: false),
                        CardValue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TransportCardReloadHistories");
        }
    }
}

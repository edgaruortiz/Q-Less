namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTransportCard : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransportCards",
                c => new
                {
                    TransportCardId = c.Int(nullable: false, identity: true),
                    TransportCardUniqueId = c.Int(nullable: false),
                    DatePurchased = c.DateTime(nullable: false),
                    CardTypeId = c.Int(nullable: false),
                    CardValue = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.TransportCardId);
            CreateIndex("dbo.TransportCards", "CardTypeId");
            AddForeignKey("dbo.TransportCards", "CardTypeId", "dbo.CardTypes", "Id", cascadeDelete: true);


        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransportCards", "CardTypeId", "dbo.CardTypes");
            DropIndex("dbo.TransportCards", new[] { "CardTypeId" });
            DropTable("dbo.TransportCards");
        }
    }
}

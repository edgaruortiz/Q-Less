namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTransaction : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TransportCards");
            CreateTable(
                "dbo.Transactions",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Amount = c.Double(nullable: false),
                    EntryPoint = c.String(maxLength: 100),
                    ExitPoint = c.String(maxLength: 100),
                    DateStamp = c.DateTime(nullable: false),
                    TransportCardId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
            DropColumn("dbo.TransportCards", "TransportCardId");
            AddColumn("dbo.TransportCards", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TransportCards", "Id");
            CreateIndex("dbo.Transactions", "TransportCardId");
            AddForeignKey("dbo.Transactions", "TransportCardId", "dbo.TransportCards", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            AddColumn("dbo.TransportCards", "TransportCardId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Transactions", "TransportCardId", "dbo.TransportCards");
            DropIndex("dbo.Transactions", new[] { "TransportCardId" });
            DropPrimaryKey("dbo.TransportCards");
            DropColumn("dbo.TransportCards", "Id");
            DropTable("dbo.Transactions");
            AddPrimaryKey("dbo.TransportCards", "TransportCardId");
        }
    }
}

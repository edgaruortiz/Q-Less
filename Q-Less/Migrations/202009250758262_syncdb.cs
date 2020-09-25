namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class syncdb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "TransportCardId", "dbo.TransportCards");
            DropForeignKey("dbo.TransportCards", "TransportCardId", "dbo.TransportCards");
            DropIndex("dbo.Transactions", new[] { "TransportCardId" });
            DropColumn("dbo.Transactions", "TransportCardId");
            AddColumn("dbo.Transactions", "TransportCardId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "TransportCard_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "TransportCardId");
            CreateIndex("dbo.Transactions", "TransportCard_Id");
            AddForeignKey("dbo.Transactions", "TransportCard_Id", "dbo.TransportCards", "Id", cascadeDelete: true);
        }
    }
}

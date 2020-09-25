namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedatatypeoftransactable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "TransportCardId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "TransportCardId", c => c.Byte(nullable: false));
        }
    }
}

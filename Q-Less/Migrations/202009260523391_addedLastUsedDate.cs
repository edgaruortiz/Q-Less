namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedLastUsedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransportCards", "LastUsed", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TransportCards", "LastUsed");
        }
    }
}

namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateStamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransportCardReloadHistories", "DateStamp", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TransportCardReloadHistories", "DateStamp");
        }
    }
}

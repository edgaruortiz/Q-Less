namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedIdentifcationField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransportCards", "Identification", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TransportCards", "Identification");
        }
    }
}

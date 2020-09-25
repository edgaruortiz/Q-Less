namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDefaultCardTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CardTypes", "Discount", c => c.Int(nullable: true));
            Sql("INSERT INTO dbo.CardTypes (Description,Discount) VALUES('Regular', 0)");
            Sql("INSERT INTO dbo.CardTypes (Description,Discount) VALUES('Discounted', 20)");
        }
        
        public override void Down()
        {
            DropColumn("dbo.CardTypes", "Discount");
        }
    }
}

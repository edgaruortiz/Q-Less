namespace Q_Less.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCardType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CardTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CardTypes");
        }
    }
}

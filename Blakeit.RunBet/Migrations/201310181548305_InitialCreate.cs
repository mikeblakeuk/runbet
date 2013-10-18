namespace Blakeit.RunBet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guesses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Hours = c.Int(nullable: false),
                        Minutes = c.Int(nullable: false),
                        Seconds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Guesses");
        }
    }
}

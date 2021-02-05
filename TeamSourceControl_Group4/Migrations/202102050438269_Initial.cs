namespace TeamSourceControl_Group4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VideoGames",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Rating = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.GameId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VideoGames");
        }
    }
}

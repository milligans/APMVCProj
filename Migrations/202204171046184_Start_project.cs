namespace AllplantsSelector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start_project : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dish",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Calories = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Comment = c.String(),
                        Purchased = c.DateTime(nullable: false),
                        imgPath = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Family = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dish", "UserId", "dbo.User");
            DropIndex("dbo.Dish", new[] { "UserId" });
            DropTable("dbo.User");
            DropTable("dbo.Dish");
        }
    }
}

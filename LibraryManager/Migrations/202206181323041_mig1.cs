namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        Price = c.Double(nullable: false),
                        Currency = c.String(),
                        Pages = c.Int(nullable: false),
                        isBooked = c.String(),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.BorrowingHistory",
                c => new
                    {
                        BookID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        DateOfBorrowing = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.BookID, t.UserID })
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.BookID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.BorrowingHistory", "UserID", "dbo.Users");
            DropForeignKey("dbo.BorrowingHistory", "BookID", "dbo.Books");
            DropIndex("dbo.BorrowingHistory", new[] { "UserID" });
            DropIndex("dbo.BorrowingHistory", new[] { "BookID" });
            DropIndex("dbo.Books", new[] { "CategoryID" });
            DropTable("dbo.Categories");
            DropTable("dbo.Users");
            DropTable("dbo.BorrowingHistory");
            DropTable("dbo.Books");
        }
    }
}

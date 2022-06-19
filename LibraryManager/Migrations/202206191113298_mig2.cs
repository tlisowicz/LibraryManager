namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurrentlyBorrowed",
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
            
            AddColumn("dbo.BorrowingHistory", "DateOfReturn", c => c.DateTime(nullable: false));
            DropColumn("dbo.Books", "isBooked");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "isBooked", c => c.String());
            DropForeignKey("dbo.CurrentlyBorrowed", "UserID", "dbo.Users");
            DropForeignKey("dbo.CurrentlyBorrowed", "BookID", "dbo.Books");
            DropIndex("dbo.CurrentlyBorrowed", new[] { "UserID" });
            DropIndex("dbo.CurrentlyBorrowed", new[] { "BookID" });
            DropColumn("dbo.BorrowingHistory", "DateOfReturn");
            DropTable("dbo.CurrentlyBorrowed");
        }
    }
}

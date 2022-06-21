namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.BorrowingHistory");
            AddPrimaryKey("dbo.BorrowingHistory", new[] { "BookID", "UserID", "DateOfReturn" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.BorrowingHistory");
            AddPrimaryKey("dbo.BorrowingHistory", new[] { "BookID", "UserID" });
        }
    }
}

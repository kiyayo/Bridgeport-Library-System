namespace Bridgeport_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBorrowHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BorrowHistories",
                c => new
                    {
                        BorrowHistoryId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        BorrowDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.BorrowHistoryId)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BorrowHistories", "MemberId", "dbo.Members");
            DropForeignKey("dbo.BorrowHistories", "BookId", "dbo.Books");
            DropIndex("dbo.BorrowHistories", new[] { "MemberId" });
            DropIndex("dbo.BorrowHistories", new[] { "BookId" });
            DropTable("dbo.BorrowHistories");
        }
    }
}

namespace Bridgeport_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addmembermodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        TelephoneNumber = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Gender = c.String(),
                        TRN = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}

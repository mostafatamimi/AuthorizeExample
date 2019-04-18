namespace AuthorizeExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorID = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.DoctorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Doctors");
        }
    }
}

namespace AuthorizeExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        BloodType = c.String(),
                    })
                .PrimaryKey(t => t.PatientID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
        }
    }
}

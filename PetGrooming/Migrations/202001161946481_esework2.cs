namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class esework2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groomers",
                c => new
                    {
                        GroomerID = c.Int(nullable: false, identity: true),
                        GroomerFirstName = c.String(),
                        GroomerLastName = c.String(),
                        GroomerPhone = c.Int(nullable: false),
                        GroomerRate = c.Double(nullable: false),
                        GroomerDOB = c.String(),
                    })
                .PrimaryKey(t => t.GroomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Groomers");
        }
    }
}

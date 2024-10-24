namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserNameSurname = c.String(),
                        UserEmail = c.String(),
                        UserMessage = c.String(),
                        AdminAddress = c.String(),
                        AdminPhoneNumber = c.String(),
                        AdminEmail = c.String(),
                        AdminMapUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}

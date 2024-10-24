namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Contacts", "Description", c => c.String());
            AddColumn("dbo.Contacts", "Image", c => c.String());
            AddColumn("dbo.Contacts", "Address", c => c.String());
            AddColumn("dbo.Contacts", "PhoneNumber", c => c.String());
            AddColumn("dbo.Contacts", "Email", c => c.String());
            AddColumn("dbo.Contacts", "MapUrl", c => c.String());
            DropColumn("dbo.Contacts", "ContactDescription");
            DropColumn("dbo.Contacts", "UserNameSurname");
            DropColumn("dbo.Contacts", "UserEmail");
            DropColumn("dbo.Contacts", "UserMessage");
            DropColumn("dbo.Contacts", "AdminAddress");
            DropColumn("dbo.Contacts", "AdminPhoneNumber");
            DropColumn("dbo.Contacts", "AdminEmail");
            DropColumn("dbo.Contacts", "AdminMapUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "AdminMapUrl", c => c.String());
            AddColumn("dbo.Contacts", "AdminEmail", c => c.String());
            AddColumn("dbo.Contacts", "AdminPhoneNumber", c => c.String());
            AddColumn("dbo.Contacts", "AdminAddress", c => c.String());
            AddColumn("dbo.Contacts", "UserMessage", c => c.String());
            AddColumn("dbo.Contacts", "UserEmail", c => c.String());
            AddColumn("dbo.Contacts", "UserNameSurname", c => c.String());
            AddColumn("dbo.Contacts", "ContactDescription", c => c.String());
            DropColumn("dbo.Contacts", "MapUrl");
            DropColumn("dbo.Contacts", "Email");
            DropColumn("dbo.Contacts", "PhoneNumber");
            DropColumn("dbo.Contacts", "Address");
            DropColumn("dbo.Contacts", "Image");
            DropColumn("dbo.Contacts", "Description");
            DropTable("dbo.UserMessages");
        }
    }
}

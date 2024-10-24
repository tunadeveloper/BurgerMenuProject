namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "ContactDescription");
        }
    }
}

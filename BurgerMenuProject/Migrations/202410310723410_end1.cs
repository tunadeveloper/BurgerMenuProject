namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class end1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contacts", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Description", c => c.String());
        }
    }
}

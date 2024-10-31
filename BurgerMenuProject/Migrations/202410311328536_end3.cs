namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class end3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Messages", "IsRead");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "IsRead", c => c.Boolean(nullable: false));
        }
    }
}

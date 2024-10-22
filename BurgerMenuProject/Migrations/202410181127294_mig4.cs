namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "DealofTheDay", c => c.Boolean(nullable: false));
            DropColumn("dbo.DealOfTheDays", "DealofTheDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DealOfTheDays", "DealofTheDay", c => c.Boolean(nullable: false));
            DropColumn("dbo.Products", "DealofTheDay");
        }
    }
}

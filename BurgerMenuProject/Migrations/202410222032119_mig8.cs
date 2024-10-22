namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "WelcomeImage", c => c.String());
            AddColumn("dbo.Abouts", "AboutImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "AboutImage");
            DropColumn("dbo.Abouts", "WelcomeImage");
        }
    }
}

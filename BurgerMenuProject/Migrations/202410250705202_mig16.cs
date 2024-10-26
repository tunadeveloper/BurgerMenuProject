namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "PeopleCount", c => c.String());
            DropColumn("dbo.Reservations", "PeopeCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "PeopeCount", c => c.String());
            DropColumn("dbo.Reservations", "PeopleCount");
        }
    }
}

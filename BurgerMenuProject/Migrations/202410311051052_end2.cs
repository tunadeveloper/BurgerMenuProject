namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class end2 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.DealOfTheDays");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DealOfTheDays",
                c => new
                    {
                        DealOfTheDayId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DealOfTheDayId);
            
        }
    }
}

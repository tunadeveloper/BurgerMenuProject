namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ImageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Galleries");
        }
    }
}

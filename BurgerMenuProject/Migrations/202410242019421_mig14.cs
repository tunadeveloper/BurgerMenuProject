namespace BurgerMenuProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig14 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SocialMedianame = c.String(),
                        SocialMediaUrl = c.String(),
                        SocialMediaIcon = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMedias");
        }
    }
}

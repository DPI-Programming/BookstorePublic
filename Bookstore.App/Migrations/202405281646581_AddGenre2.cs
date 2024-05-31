namespace Bookstore.App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        LastUpdatedBy = c.String(),
                        ModificationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Genres");
        }
    }
}

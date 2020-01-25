namespace Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Image = c.String(),
                        IsFavorite = c.Boolean(nullable: false),
                        Available = c.Boolean(nullable: false),
                        CategotyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategotyId, cascadeDelete: true)
                .Index(t => t.CategotyId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CategotyId", "dbo.Categories");
            DropIndex("dbo.Cars", new[] { "CategotyId" });
            DropTable("dbo.Categories");
            DropTable("dbo.Cars");
        }
    }
}

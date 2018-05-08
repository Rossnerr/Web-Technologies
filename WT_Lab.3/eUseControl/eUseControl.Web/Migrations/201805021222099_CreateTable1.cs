namespace eUseControl.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "BrandId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "BrandId");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "Brand");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Brand", c => c.String(nullable: false, maxLength: 50));
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropColumn("dbo.Products", "BrandId");
            DropTable("dbo.Brands");
        }
    }
}

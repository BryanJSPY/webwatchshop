namespace WatchShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AAA : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Items", new[] { "brandId" });
            DropIndex("dbo.Items", new[] { "categoryId" });
            CreateIndex("dbo.Items", "BrandId");
            CreateIndex("dbo.Items", "CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Items", new[] { "CategoryId" });
            DropIndex("dbo.Items", new[] { "BrandId" });
            CreateIndex("dbo.Items", "categoryId");
            CreateIndex("dbo.Items", "brandId");
        }
    }
}

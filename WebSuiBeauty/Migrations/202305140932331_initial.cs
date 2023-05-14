namespace WebSuiBeauty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTag", "TagId", "dbo.Tag");
            DropForeignKey("dbo.ProductTag", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetail", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.ProductCategory");
            DropForeignKey("dbo.OrderDetail", "OrderId", "dbo.Order");
            DropForeignKey("dbo.ContentTag", "TagId", "dbo.Tag");
            DropForeignKey("dbo.ContentTag", "ContentId", "dbo.Content");
            DropForeignKey("dbo.Content", "CategoryId", "dbo.ContentCategory");
            DropIndex("dbo.ProductTag", new[] { "TagId" });
            DropIndex("dbo.ProductTag", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.OrderDetail", new[] { "ProductId" });
            DropIndex("dbo.OrderDetail", new[] { "OrderId" });
            DropIndex("dbo.ContentTag", new[] { "TagId" });
            DropIndex("dbo.ContentTag", new[] { "ContentId" });
            DropIndex("dbo.Content", new[] { "CategoryId" });
            DropTable("dbo.ProductTag");
            DropTable("dbo.ProductCategory");
            DropTable("dbo.Products");
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.FeedBack");
            DropTable("dbo.Tag");
            DropTable("dbo.ContentTag");
            DropTable("dbo.Content");
            DropTable("dbo.ContentCategory");
            DropTable("dbo.ContactDetail");
        }
    }
}

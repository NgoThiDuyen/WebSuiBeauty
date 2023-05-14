namespace WebSuiBeauty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ContactDetail", "Lat");
            DropColumn("dbo.ContactDetail", "Lng");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContactDetail", "Lng", c => c.Double());
            AddColumn("dbo.ContactDetail", "Lat", c => c.Double());
        }
    }
}

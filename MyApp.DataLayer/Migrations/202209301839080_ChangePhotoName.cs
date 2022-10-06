namespace MyApp.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePhotoName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "PhotoName", c => c.String());
            DropColumn("dbo.Pessoas", "Photo_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoas", "Photo_Name", c => c.String());
            DropColumn("dbo.Pessoas", "PhotoName");
        }
    }
}

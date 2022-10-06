namespace DBCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Author", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Author", "Country");
        }
    }
}

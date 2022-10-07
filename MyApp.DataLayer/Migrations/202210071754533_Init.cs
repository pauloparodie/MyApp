namespace MyApp.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Cod = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Raca = c.String(),
                        DonoCod = c.Int(),
                    })
                .PrimaryKey(t => t.Cod)
                .ForeignKey("dbo.Pessoas", t => t.DonoCod)
                .Index(t => t.DonoCod);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Cod = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Pais = c.String(),
                        PhotoName = c.String(),
                    })
                .PrimaryKey(t => t.Cod);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "DonoCod", "dbo.Pessoas");
            DropIndex("dbo.Animals", new[] { "DonoCod" });
            DropTable("dbo.Pessoas");
            DropTable("dbo.Animals");
        }
    }
}

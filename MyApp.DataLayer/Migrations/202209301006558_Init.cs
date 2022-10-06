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
                        Dono = c.Int(),
                    })
                .PrimaryKey(t => t.Cod)
                .ForeignKey("dbo.Pessoas", t => t.Dono)
                .Index(t => t.Dono);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Cod = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Pais = c.String(),
                        Photo_Name = c.String(),
                    })
                .PrimaryKey(t => t.Cod);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "Dono", "dbo.Pessoas");
            DropIndex("dbo.Animals", new[] { "Dono" });
            DropTable("dbo.Pessoas");
            DropTable("dbo.Animals");
        }
    }
}

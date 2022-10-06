namespace DBCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        Cod = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Age = c.Int(),
                        AgeRequired = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cod);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        Cod = c.Int(nullable: false, identity: true),
                        Title = c.String(unicode: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cod)
                .ForeignKey("dbo.Author", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "AuthorId", "dbo.Author");
            DropIndex("dbo.Book", new[] { "AuthorId" });
            DropTable("dbo.Book");
            DropTable("dbo.Author");
        }
    }
}

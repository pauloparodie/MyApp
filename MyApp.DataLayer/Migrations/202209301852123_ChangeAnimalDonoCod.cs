namespace MyApp.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAnimalDonoCod : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Animals", name: "Dono", newName: "DonoCod");
            RenameIndex(table: "dbo.Animals", name: "IX_Dono", newName: "IX_DonoCod");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Animals", name: "IX_DonoCod", newName: "IX_Dono");
            RenameColumn(table: "dbo.Animals", name: "DonoCod", newName: "Dono");
        }
    }
}

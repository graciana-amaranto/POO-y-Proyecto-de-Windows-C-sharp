namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abmAvion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Avion", "LineaAerea_Id", c => c.Int());
            CreateIndex("dbo.Avion", "LineaAerea_Id");
            AddForeignKey("dbo.Avion", "LineaAerea_Id", "dbo.LineaAerea", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "LineaAerea_Id", "dbo.LineaAerea");
            DropIndex("dbo.Avion", new[] { "LineaAerea_Id" });
            DropColumn("dbo.Avion", "LineaAerea_Id");
        }
    }
}

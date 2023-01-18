namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiodeVariables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Avions", newName: "Avion");
            RenameTable(name: "dbo.LineaAereas", newName: "LineaAerea");
            AddColumn("dbo.Avion", "Capacidad", c => c.Int(nullable: false));
            AddColumn("dbo.Avion", "Denominacion", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.LineaAerea", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.LineaAerea", "FechaInicioActividades", c => c.DateTime(nullable: false));
            DropColumn("dbo.Avion", "Nombre");
            DropColumn("dbo.Avion", "FechaInicioActividades");
            DropColumn("dbo.LineaAerea", "Capacidad");
            DropColumn("dbo.LineaAerea", "Denominacion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LineaAerea", "Denominacion", c => c.String());
            AddColumn("dbo.LineaAerea", "Capacidad", c => c.Int(nullable: false));
            AddColumn("dbo.Avion", "FechaInicioActividades", c => c.DateTime(nullable: false));
            AddColumn("dbo.Avion", "Nombre", c => c.String());
            DropColumn("dbo.LineaAerea", "FechaInicioActividades");
            DropColumn("dbo.LineaAerea", "Nombre");
            DropColumn("dbo.Avion", "Denominacion");
            DropColumn("dbo.Avion", "Capacidad");
            RenameTable(name: "dbo.LineaAerea", newName: "LineaAereas");
            RenameTable(name: "dbo.Avion", newName: "Avions");
        }
    }
}

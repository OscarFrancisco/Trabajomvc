namespace Infraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "Telefono", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "Correo", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "NombreUsuario", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "NombreUsuario", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customer", "Correo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customer", "Telefono", c => c.String(nullable: false, maxLength: 10));
        }
    }
}

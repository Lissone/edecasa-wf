namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCompletadoInPedido : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedido", "Completado", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pedido", "Completado");
        }
    }
}

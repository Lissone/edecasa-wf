namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addVlMotoqueiroInPedido : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedido", "VlMotoqueiro", c => c.Single(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pedido", "VlMotoqueiro");
        }
    }
}

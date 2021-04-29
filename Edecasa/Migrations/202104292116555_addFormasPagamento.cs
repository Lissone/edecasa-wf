namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFormasPagamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FormasPagamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Pedido", "TpPagamentoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pedido", "TpPagamentoId");
            AddForeignKey("dbo.Pedido", "TpPagamentoId", "dbo.FormasPagamento", "Id", cascadeDelete: true);
            DropColumn("dbo.Pedido", "TpPagamento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pedido", "TpPagamento", c => c.String());
            DropForeignKey("dbo.Pedido", "TpPagamentoId", "dbo.FormasPagamento");
            DropIndex("dbo.Pedido", new[] { "TpPagamentoId" });
            DropColumn("dbo.Pedido", "TpPagamentoId");
            DropTable("dbo.FormasPagamento");
        }
    }
}

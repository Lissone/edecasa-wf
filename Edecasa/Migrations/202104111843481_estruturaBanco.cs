namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estruturaBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Telefone = c.String(),
                        Rua = c.String(),
                        Bairro = c.String(),
                        Numero = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TpPagamento = c.String(),
                        Valor = c.Single(nullable: false),
                        Taxa = c.Single(nullable: false),
                        Data = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                        PedidoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedidos", t => t.PedidoId, cascadeDelete: true)
                .ForeignKey("dbo.Produtos", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId)
                .Index(t => t.PedidoId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Tamanho = c.String(),
                        VlPequeno = c.Single(nullable: false),
                        VlGrande = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ProdutoId", "dbo.Produtos");
            DropForeignKey("dbo.Items", "PedidoId", "dbo.Pedidos");
            DropForeignKey("dbo.Pedidos", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Items", new[] { "PedidoId" });
            DropIndex("dbo.Items", new[] { "ProdutoId" });
            DropIndex("dbo.Pedidos", new[] { "ClienteId" });
            DropTable("dbo.Produtos");
            DropTable("dbo.Items");
            DropTable("dbo.Pedidos");
            DropTable("dbo.Clientes");
        }
    }
}

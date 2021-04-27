namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databasestructured : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Telefone = c.String(maxLength: 12),
                        Rua = c.String(),
                        Bairro = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Telefone, unique: true, name: "Ix_Telefone");
            
            CreateTable(
                "dbo.Pedido",
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
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Tamanho = c.String(),
                        ProdutoId = c.Int(nullable: false),
                        PizzaId = c.Int(),
                        PedidoId = c.Int(nullable: false),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedido", t => t.PedidoId, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.Produto_Id)
                .ForeignKey("dbo.Produto", t => t.PizzaId)
                .ForeignKey("dbo.Produto", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId)
                .Index(t => t.PizzaId)
                .Index(t => t.PedidoId)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Categoria = c.String(),
                        VlPequeno = c.Double(nullable: false),
                        VlGrande = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.Item", "PizzaId", "dbo.Produto");
            DropForeignKey("dbo.Item", "Produto_Id", "dbo.Produto");
            DropForeignKey("dbo.Item", "PedidoId", "dbo.Pedido");
            DropForeignKey("dbo.Pedido", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Item", new[] { "Produto_Id" });
            DropIndex("dbo.Item", new[] { "PedidoId" });
            DropIndex("dbo.Item", new[] { "PizzaId" });
            DropIndex("dbo.Item", new[] { "ProdutoId" });
            DropIndex("dbo.Pedido", new[] { "ClienteId" });
            DropIndex("dbo.Cliente", "Ix_Telefone");
            DropTable("dbo.Produto");
            DropTable("dbo.Item");
            DropTable("dbo.Pedido");
            DropTable("dbo.Cliente");
        }
    }
}

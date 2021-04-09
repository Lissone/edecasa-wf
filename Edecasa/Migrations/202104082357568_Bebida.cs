namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bebida : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bebidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Tamanho = c.Int(nullable: false),
                        Valor = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bebidas");
        }
    }
}

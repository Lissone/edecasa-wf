namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategoryInProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Categoria", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "Categoria");
        }
    }
}

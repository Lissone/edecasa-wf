namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPizzaInItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "PizzaId", c => c.Int());
            CreateIndex("dbo.Item", "PizzaId");
            AddForeignKey("dbo.Item", "PizzaId", "dbo.Produto", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "PizzaId", "dbo.Produto");
            DropIndex("dbo.Item", new[] { "PizzaId" });
            DropColumn("dbo.Item", "PizzaId");
        }
    }
}

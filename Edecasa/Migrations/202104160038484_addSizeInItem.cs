namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSizeInItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "Tamanho", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Item", "Tamanho");
        }
    }
}

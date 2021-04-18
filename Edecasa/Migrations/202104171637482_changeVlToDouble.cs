namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeVlToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produto", "VlPequeno", c => c.Double(nullable: false));
            AlterColumn("dbo.Produto", "VlGrande", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produto", "VlGrande", c => c.Single(nullable: false));
            AlterColumn("dbo.Produto", "VlPequeno", c => c.Single(nullable: false));
        }
    }
}

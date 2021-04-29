namespace Edecasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMotoqueiro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Motoqueiro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Motoqueiro");
        }
    }
}

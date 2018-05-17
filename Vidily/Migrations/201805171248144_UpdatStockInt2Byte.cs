namespace Vidily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatStockInt2Byte : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Stock", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Stock", c => c.Int(nullable: false));
        }
    }
}

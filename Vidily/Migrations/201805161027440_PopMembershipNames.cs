namespace Vidily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopMembershipNames : DbMigration
    {
        public override void Up()
        {
            Sql("update membershiptypes set name = 'Pay as You Go'  from membershiptypes where id = 1");
            Sql("update membershiptypes set name = 'Monthly'  from membershiptypes where id = 2");
            Sql("update membershiptypes set name = 'Quaterly' from membershiptypes  where id = 3");
            Sql("update membershiptypes set name = 'Annually'  from membershiptypes where id = 4");

        }
        
        public override void Down()
        {
        }
    }
}

namespace Vidily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fimgenres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FilmGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Genre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "FilmGenresId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "FilmGenresId");
            AddForeignKey("dbo.Movies", "FilmGenresId", "dbo.FilmGenres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "FilmGenresId", "dbo.FilmGenres");
            DropIndex("dbo.Movies", new[] { "FilmGenresId" });
            DropColumn("dbo.Movies", "FilmGenresId");
            DropTable("dbo.FilmGenres");
        }
    }
}

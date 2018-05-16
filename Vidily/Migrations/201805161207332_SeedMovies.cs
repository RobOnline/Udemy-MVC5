namespace Vidily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMovies : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "FilmGenres_Id", "dbo.FilmGenres");
            DropIndex("dbo.Movies", new[] { "FilmGenres_Id" });
            RenameColumn(table: "dbo.Movies", name: "FilmGenres_Id", newName: "FilmGenresId");
            AlterColumn("dbo.Movies", "FilmGenresId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "FilmGenresId");
            AddForeignKey("dbo.Movies", "FilmGenresId", "dbo.FilmGenres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "FilmGenresId", "dbo.FilmGenres");
            DropIndex("dbo.Movies", new[] { "FilmGenresId" });
            AlterColumn("dbo.Movies", "FilmGenresId", c => c.Byte());
            RenameColumn(table: "dbo.Movies", name: "FilmGenresId", newName: "FilmGenres_Id");
            CreateIndex("dbo.Movies", "FilmGenres_Id");
            AddForeignKey("dbo.Movies", "FilmGenres_Id", "dbo.FilmGenres", "Id");
        }
    }
}

namespace Vidily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieModel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FilmGenres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Genre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "FilmGenres_Id", c => c.Byte());
            CreateIndex("dbo.Movies", "FilmGenres_Id");
            AddForeignKey("dbo.Movies", "FilmGenres_Id", "dbo.FilmGenres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "FilmGenres_Id", "dbo.FilmGenres");
            DropIndex("dbo.Movies", new[] { "FilmGenres_Id" });
            DropColumn("dbo.Movies", "FilmGenres_Id");
            DropTable("dbo.FilmGenres");
        }
    }
}

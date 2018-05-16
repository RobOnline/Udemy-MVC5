namespace Vidily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMovieModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "FilmGenres_Id", "dbo.FilmGenres");
            DropIndex("dbo.Movies", new[] { "FilmGenres_Id" });
            DropColumn("dbo.Movies", "FilmGenresId");
            DropColumn("dbo.Movies", "FilmGenres_Id");
            DropTable("dbo.FilmGenres");
        }
        
        public override void Down()
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
            AddColumn("dbo.Movies", "FilmGenresId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "FilmGenres_Id");
            AddForeignKey("dbo.Movies", "FilmGenres_Id", "dbo.FilmGenres", "Id");
        }
    }
}

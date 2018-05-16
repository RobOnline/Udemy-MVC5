namespace Vidily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genreid2byte : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "FilmGenresId", "dbo.FilmGenres");
            DropIndex("dbo.Movies", new[] { "FilmGenresId" });
            DropPrimaryKey("dbo.FilmGenres");
            AddColumn("dbo.Movies", "FilmGenres_Id", c => c.Byte());
            AlterColumn("dbo.FilmGenres", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.FilmGenres", "Id");
            CreateIndex("dbo.Movies", "FilmGenres_Id");
            AddForeignKey("dbo.Movies", "FilmGenres_Id", "dbo.FilmGenres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "FilmGenres_Id", "dbo.FilmGenres");
            DropIndex("dbo.Movies", new[] { "FilmGenres_Id" });
            DropPrimaryKey("dbo.FilmGenres");
            AlterColumn("dbo.FilmGenres", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Movies", "FilmGenres_Id");
            AddPrimaryKey("dbo.FilmGenres", "Id");
            CreateIndex("dbo.Movies", "FilmGenresId");
            AddForeignKey("dbo.Movies", "FilmGenresId", "dbo.FilmGenres", "Id", cascadeDelete: true);
        }
    }
}

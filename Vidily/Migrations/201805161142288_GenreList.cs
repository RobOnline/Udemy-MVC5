namespace Vidily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreList : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into FilmGenres (Genre) values ('Action')");
            Sql("Insert into FilmGenres (Genre) values ('Adventure')");
            Sql("Insert into FilmGenres (Genre) values ('Comedy')");
            Sql("Insert into FilmGenres (Genre) values ('Drama')");
            Sql("Insert into FilmGenres (Genre) values ('Horror')");
            Sql("Insert into FilmGenres (Genre) values ('Musical')");
            Sql("Insert into FilmGenres (Genre) values ('Science Fiction')");
            Sql("Insert into FilmGenres (Genre) values ('Western')");
            Sql("Insert into FilmGenres (Genre) values ('War')");
            Sql("Insert into FilmGenres (Genre) values ('Crime')");
        }
        
        public override void Down()
        {
        }
    }
}

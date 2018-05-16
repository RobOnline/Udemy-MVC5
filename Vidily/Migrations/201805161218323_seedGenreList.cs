namespace Vidily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedGenreList : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into FilmGenres (id,Genre) values (1,'Action')");
            Sql("Insert into FilmGenres (id,Genre) values (2,'Adventure')");
            Sql("Insert into FilmGenres (id,Genre) values (3,'Comedy')");
            Sql("Insert into FilmGenres (id,Genre) values (4,'Drama')");
            Sql("Insert into FilmGenres (id,Genre) values (5,'Horror')");
            Sql("Insert into FilmGenres (id,Genre) values (6,'Musical')");
            Sql("Insert into FilmGenres (id,Genre) values (7,'Science Fiction')");
            Sql("Insert into FilmGenres (id,Genre) values (8,'Western')");
            Sql("Insert into FilmGenres (id,Genre) values (9,'War')");
            Sql("Insert into FilmGenres (id,Genre) values (10,'Crime')");
        }
        
        public override void Down()
        {
        }
    }
}

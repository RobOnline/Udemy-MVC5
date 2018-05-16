namespace Vidily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMovieList : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('Throw Mama From the Train',04/06/1988,16/05/2018,10)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('The Usual Suspects',25/08/1995,16/05/2018,10)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('Dude! Wheres My Car?',09/02/2000,16/05/2018,3)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('Dumb and Dumber',07/04/1995,16/05/2018,3)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('American Pie',08/10/1999,16/05/2018,3)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('Alien',30/09/1979,16/05/2018,5)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('Last House on the left',30/08/1972,16/05/2018,5)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('The Hills have eyes',22/06/1977,16/05/2018,5)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('Pride and Prejudice',16/09/2005,16/05/2018,4)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('The Greatest Showman',26/12/2017,16/05/2018,4)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('Mamma Mia! Here We Go Again,20/07/2018,16/05/2018,6)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,FilmGenresid) values('Moana',02/12/2016,16/05/2018,6)");

        }
        
        public override void Down()
        {
        }
    }
}

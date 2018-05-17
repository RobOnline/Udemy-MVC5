
using System;
using System.Linq;
using System.Web.Mvc;
using Vidily.Models;
using System.Data.Entity;
using System.Web.UI.WebControls;
using Vidily.ViewModels;

namespace Vidily.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()

        {

            var movies = _context.Movies.Include(m => m.FilmGenres).SortBy("Name").SortBy("FilmGenresID").ToList();

            return View(movies);

        }




        [Route("movies/details/{id}")]
        [Route("movies/details")]
        public ActionResult Details(int? id)
        {
            if (String.IsNullOrEmpty(id.ToString()))
            {
                id = 0;
            }
            var movie = _context.Movies.Include(m => m.FilmGenres).SingleOrDefault(m => m.Id == id);
            return View(movie);
        }

        // EDIT ACTOIN

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);
            var viewModel = new MovieFormViewModel(movie)
            {
                FilmGenreses = _context.FilmGenreses.ToList()
                
            };

            return View("MovieForm", viewModel);
        }

        //SAVE ACTION
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    FilmGenreses = _context.FilmGenreses.ToList()
                    
                    


                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(m =>  m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.FilmGenresId = movie.FilmGenresId;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.Stock = movie.Stock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        //NEW ACtion
        public ViewResult New()
        {
            var filmegenres = _context.FilmGenreses.ToList();
            var viewModel = new MovieFormViewModel()
            {
                FilmGenreses = filmegenres,
                
            };
            return View("MovieForm", viewModel);
        }
    }
}

using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
using System.Linq;
using System;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ApplicationDbContext _context;

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
            if (User.IsInRole("CanManageMovies"))
                return View("List");
            else
                return View("ReadOnlyList");
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
                return HttpNotFound();

            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.GenreId == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ViewResult New()
        {
            var movieViewModel = new movieViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", movieViewModel);
        }


        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var movieViewModel = new movieViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", movieViewModel);
        }


        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;

                movieInDb.ReleaseDate = movie.ReleaseDate;
            }
            _context.SaveChanges();


            return RedirectToAction("index", "Movies");
        }
    }
}


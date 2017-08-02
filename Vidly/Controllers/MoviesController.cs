using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { ID = 1, Name = "Shrek"},
                new Movie { ID = 2, Name = "Wall-e"}
            };
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            /* Don't use ViewData or ViewBag
            ViewData["Movie"] = movie;
            ViewBag.Movie = movie;
            */

            return View(viewModel);
            //return View(movie);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home",new { page = 1, sortBy = "name" });
        }


        /* PRACTICE
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }


        /
        // movies
        // Question mark is nullable in case none is entered
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            
            
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("PageIndex={0}&sortBy={1}",pageIndex,sortBy));
            
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        // regex & range for entering multiple contraints. Look up Asp.net MVC Attribute Route Constraints
        [Route("movies/release/{year}/{month:regex(\\d{2}):range(1,12)}")] 
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
    }
    
}

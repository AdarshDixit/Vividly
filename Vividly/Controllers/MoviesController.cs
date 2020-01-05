using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vividly.Models;

namespace Vividly.Controllers
{
    public class MoviesController : Controller
    {
        [Route("Movies/AllMovies")]
        public ActionResult AllMovies()
        {
            var viewModel = new MoviesViewModel
            {
                Movies = this.GetAllMovies()
            };

            return View(viewModel);
        }

        private List<Movie> GetAllMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Name = "Avengers"
                }
            };
        }
    }
}
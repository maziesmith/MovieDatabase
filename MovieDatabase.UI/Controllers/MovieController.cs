using Microsoft.AspNetCore.Mvc;
using MovieDatabase.BL;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.UI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieManager _mgr;

        public MovieController()
        {
            _mgr = new MovieManager();
        }

        // GET
        public IActionResult Index(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
            {
                return View(_mgr.GetAllMedia());
            }

            return View(_mgr.GetMediaByTitle(searchString));
        }

        public IActionResult DetailMovie(int id)
        {
            return View(_mgr.GetMovie(id));
        }

        public IActionResult DetailSeries(int id)
        {
            return View(_mgr.GetSeries(id));
        }

        [HttpGet]
        public IActionResult EditMovie(int id)
        {
            Movie movie = _mgr.GetMovie(id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        [HttpPost]
        public IActionResult EditMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            _mgr.ChangeMovie(movie);
            return RedirectToAction("Index");
        }

        public IActionResult EditSeries(int id)
        {
            return View(_mgr.GetSeries(id));
        }

        [HttpGet]
        public IActionResult DeleteMedia(int id)
        {
            _mgr.RemoveMedia(_mgr.GetMedia(id));
            return RedirectToAction("Index");
        }
    }
}
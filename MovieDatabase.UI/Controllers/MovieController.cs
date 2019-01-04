using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;
using MovieDatabase.BL;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.UI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieManager _mgr = new MovieManager();

        public MovieController()
        {
            Actor a1 = new Actor {ActorId = 1, Name = "Robert Downey Jr"};
            Actor a2 = new Actor {ActorId = 2, Name = "Sandra Bullock"};
            Actor a3 = new Actor {ActorId = 3, Name = "Scarlett Johanson"};
            Actor a4 = new Actor {ActorId = 4, Name = "Elisabeth Olsen"};
            Actor a5 = new Actor {ActorId = 5, Name = "Jon Favreau"};
            Actor a6 = new Actor {ActorId = 6, Name = "Leonardo DiCaprio"};
            Actor a7 = new Actor {ActorId = 7, Name = "Dave Batista"};
            Movie m1 = new Movie
            {
                Id = 1,
                Title = "Iron man",
                WatchDate = new DateTime(2015, 1, 5),
                Actors = new Collection<Actor> {a1, a2, a3}
            };
            Movie m2 = new Movie
            {
                Id = 2,
                Title = "The Wolf of Wallstreet",
                WatchDate = new DateTime(2017, 4, 14),
                Actors = new Collection<Actor> {a1, a2}
            };
            Movie m3 = new Movie
            {
                Id = 3,
                Title = "Captain America",
                WatchDate = new DateTime(2013, 1, 9),
                Actors = new Collection<Actor> {a1, a4, a5}
            };
            Movie m4 = new Movie
            {
                Id = 4,
                Title = "Terminator",
                WatchDate = new DateTime(2018, 5, 5),
                Actors = new Collection<Actor> {a3}
            };
            Movie m5 = new Movie
            {
                Id = 5,
                Title = "Birdbox",
                WatchDate = new DateTime(2015, 7, 5),
                Actors = new Collection<Actor> {a6, a7, a3}
            };
            Series s1 = new Series
            {
                Id = 6,
                Title = "Vikings",
                Season = 1,
                Channel = "History",
                Actors = new List<Actor> {new Actor {Name = "Travis Fimmel"}}
            };
            _mgr.AddMovie(m1);
            _mgr.AddMovie(m2);
            _mgr.AddMovie(m3);
            _mgr.AddMovie(m4);
            _mgr.AddMovie(m5);
            _mgr.AddSeries(s1);
        }

        // GET
        public IActionResult Index()
        {
            return
                RedirectToAction("ListWatched", "Movie");
        }

        public IActionResult ListWatched()
        {
            return View(_mgr.GetAllMedia());
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
            //ViewBag.Actors = _mgr.GetActors();
            if (movie == null) return NotFound();
            return View(movie);
        }

        [HttpPost]
        public IActionResult EditMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("EditMovie", new {id = movie.Id});
            }
            _mgr.ChangeMovie(movie);
            return RedirectToAction("Index");
        }

        public IActionResult EditSeries(int id)
        {
            return View(_mgr.GetSeries(id));
        }
    }
}
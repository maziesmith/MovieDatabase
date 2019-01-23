using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieDatabase.BL;
using MovieDatabase.BL.Domain;
using MovieDatabase.UI.Models;

namespace MovieDatabase.UI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieManager _movieManager = new MovieManager();
        private readonly IActorManager _actorManager = new ActorManager();

        /**
         * Returns a list of all media
         * @param string to filter by title
         */
        public IActionResult Index(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                return View(_movieManager.GetByTitle(searchString));
            }

            return View(_movieManager.GetAll());
        }

        /**
         * Detailed overview of a movie
         */
        public IActionResult Detail(int id)
        {
            return View(_movieManager.Get(id));
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            Media media = _movieManager.Get(id);
            if (media == null) return NotFound(); //TODO: handle not found
            return View(media);
        }

        /**
         * Change some data
         */
        [HttpPut]
        public IActionResult Edit(Media media)
        {
            if (!ModelState.IsValid)
            {
                return View(media);
            }

            _movieManager.Change(media);

            return RedirectToAction("Index");
        }


        /**
         * Removes item from list in Index.cshtml
         */
        public IActionResult Delete(int id)
        {
            _movieManager.Remove(_movieManager.Get(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        /**
         * Add new Media
         */
        [HttpPost]
        public IActionResult Create(MediaViewModel mediaViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(mediaViewModel);
            }

            Media media = ViewModelToMedia(mediaViewModel);
            _movieManager.Add(media);
            return RedirectToAction("Index");
        }

        private Media ViewModelToMedia(MediaViewModel model)
        {
            Media m = model.Media;
            m.ActorActs = new List<ActorAct>();
            foreach (string name in model.Actors)
            {
                ActorAct aa = new ActorAct();
                if (!_actorManager.Exists(name))
                {
                    aa.Actor = new Actor {Name = name};
                    aa.Media = m;
                }
                else
                {
                    aa.Actor = _actorManager.GetByName(name);
                }

                aa.Media = m;
                m.ActorActs.Add(aa);
            }

            return m;
        }
    }
}
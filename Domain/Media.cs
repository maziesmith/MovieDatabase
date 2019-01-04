using System.Linq;

namespace MovieDatabase.BL.Domain
{
    using System;
    using System.Collections.Generic;

    public abstract class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? Priority { get; set; }
        public int? Rating { get; set; }
        public MediaType MediaType { get; set; }
        public Genre Genre { get; set; }
        public bool IsPresent { get; set; }
        public DateTime? WatchDate { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<ActorAct> ActorActs { get; set; }

        public IEnumerable<Actor> TopThreeActors()
        {
            return Actors.Take(3);
        }

        public override string ToString()
        {
            return string.Format("Title: {0}\nRelease date: {1}\n", Title, ReleaseDate);
        }
    }
}